using System;
using System.Collections.Generic;
using System.Reflection;

using FlatRedBall;
using FlatRedBall.Graphics;
using FlatRedBall.Screens;
using Microsoft.Xna.Framework;

using System.Linq;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Serilog;
using Serilog.Extensions.Logging;
using SIPSorcery.Net;
using SIPSorcery.Sys;
using WebSocketSharp.Server;

namespace test_webrtc
{
    public partial class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;

        
        partial void GeneratedInitializeEarly();
        partial void GeneratedInitialize();
        partial void GeneratedUpdate(Microsoft.Xna.Framework.GameTime gameTime);
        partial void GeneratedDrawEarly(Microsoft.Xna.Framework.GameTime gameTime);
        partial void GeneratedDraw(Microsoft.Xna.Framework.GameTime gameTime);


		private const int WEBSOCKET_PORT = 8081;
		private const string STUN_URL = "stun:stun.sipsorcery.com";
		private const int JAVASCRIPT_SHA256_MAX_IN_SIZE = 65535;
		private const int SHA256_OUTPUT_SIZE = 32;
		private const int MAX_LOADTEST_COUNT = 100;

		private static uint _loadTestPayloadSize = 0;
		private static int _loadTestCount = 0;

		public Game1() : base()
        {

			graphics = new GraphicsDeviceManager(this);

#if  ANDROID || IOS
            graphics.IsFullScreen = true;
#elif WINDOWS || DESKTOP_GL
            graphics.PreferredBackBufferWidth = 800;
            graphics.PreferredBackBufferHeight = 600;
#endif
        }

        protected override void Initialize()
        {
            #if IOS
            var bounds = UIKit.UIScreen.MainScreen.Bounds;
            var nativeScale = UIKit.UIScreen.MainScreen.Scale;
            var screenWidth = (int)(bounds.Width * nativeScale);
            var screenHeight = (int)(bounds.Height * nativeScale);
            graphics.PreferredBackBufferWidth = screenWidth;
            graphics.PreferredBackBufferHeight = screenHeight;
            #endif
        
            GeneratedInitializeEarly();

            FlatRedBallServices.InitializeFlatRedBall(this, graphics);

            GeneratedInitialize();

            base.Initialize();
        }

		public void StartConnection()
		{
			FlatRedBall.Debugging.Debugger.CommandLineWrite("WebRTC Get Started Data Channel");

			// Start web socket.
			FlatRedBall.Debugging.Debugger.CommandLineWrite("Starting web socket server...");
			var webSocketServer = new WebSocketServer(IPAddress.Any, WEBSOCKET_PORT);
			webSocketServer.AddWebSocketService<WebRTCWebSocketPeer>("/", (peer) =>
			{
				peer.CreatePeerConnection = CreatePeerConnection;
			});
			webSocketServer.Start();

			FlatRedBall.Debugging.Debugger.CommandLineWrite($"Waiting for web socket connections on {webSocketServer.Address}:{webSocketServer.Port}...");
			FlatRedBall.Debugging.Debugger.CommandLineWrite("Press ctrl-c to exit.");

			// Ctrl-c will gracefully exit the call at any point.
			ManualResetEvent exitMre = new ManualResetEvent(false);
			Console.CancelKeyPress += delegate (object sender, ConsoleCancelEventArgs e)
			{
				e.Cancel = true;
				exitMre.Set();
			};

			// Wait for a signal saying the call failed, was cancelled with ctrl-c or completed.
			// if we comment this out, this probably will make it so that it never actually ends the call, which is probably fine?
			//exitMre.WaitOne();
		}

		protected override void Update(GameTime gameTime)
        {
            FlatRedBallServices.Update(gameTime);

            FlatRedBall.Screens.ScreenManager.Activity();

            GeneratedUpdate(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GeneratedDrawEarly(gameTime);

            FlatRedBallServices.Draw();

            GeneratedDraw(gameTime);

            base.Draw(gameTime);
        }

		private async static Task<RTCPeerConnection> CreatePeerConnection()
		{
			RTCConfiguration config = new RTCConfiguration
			{
				iceServers = new List<RTCIceServer> { new RTCIceServer { urls = STUN_URL } }
			};
			var pc = new RTCPeerConnection(config);
			pc.ondatachannel += (rdc) =>
			{
				rdc.onopen += () => FlatRedBall.Debugging.Debugger.CommandLineWrite($"Data channel {rdc.label} opened.");
				rdc.onclose += () => FlatRedBall.Debugging.Debugger.CommandLineWrite($"Data channel {rdc.label} closed.");
				rdc.onmessage += (datachan, type, data) =>
				{
					switch (type)
					{
						case DataChannelPayloadProtocols.WebRTC_Binary_Empty:
						case DataChannelPayloadProtocols.WebRTC_String_Empty:
							FlatRedBall.Debugging.Debugger.CommandLineWrite($"Data channel {datachan.label} empty message type {type}.");
							break;

						case DataChannelPayloadProtocols.WebRTC_Binary:
							string jsSha256 = DoJavscriptSHA256(data);
							FlatRedBall.Debugging.Debugger.CommandLineWrite($"Data channel {datachan.label} received {data.Length} bytes, js mirror sha256 {jsSha256}.");
							rdc.send(jsSha256);

							if (_loadTestCount > 0)
							{
								DoLoadTestIteration(rdc, _loadTestPayloadSize);
								_loadTestCount--;
							}

							break;

						case DataChannelPayloadProtocols.WebRTC_String:
							var msg = Encoding.UTF8.GetString(data);
							FlatRedBall.Debugging.Debugger.CommandLineWrite($"Data channel {datachan.label} message {type} received: {msg}.");

							var loadTestMatch = Regex.Match(msg, @"^\s*(?<sendSize>\d+)\s*x\s*(?<testCount>\d+)");

							if (loadTestMatch.Success)
							{
								uint sendSize = uint.Parse(loadTestMatch.Result("${sendSize}"));
								_loadTestCount = int.Parse(loadTestMatch.Result("${testCount}"));
								_loadTestCount = (_loadTestCount <= 0 || _loadTestCount > MAX_LOADTEST_COUNT) ? MAX_LOADTEST_COUNT : _loadTestCount;
								_loadTestPayloadSize = (sendSize > pc.sctp.maxMessageSize) ? pc.sctp.maxMessageSize : sendSize;

								FlatRedBall.Debugging.Debugger.CommandLineWrite($"Starting data channel binary load test, payload size {sendSize}, test count {_loadTestCount}.");
								DoLoadTestIteration(rdc, _loadTestPayloadSize);
								_loadTestCount--;
							}
							else
							{
								// Do a string echo.
								rdc.send($"echo: {msg}");
							}
							break;
					}
				};
			};

			var dc = await pc.createDataChannel("test", null);

			pc.onconnectionstatechange += (state) =>
			{
				FlatRedBall.Debugging.Debugger.CommandLineWrite($"Peer connection state change to {state}.");

				if (state == RTCPeerConnectionState.failed)
				{
					pc.Close("ice disconnection");
				}
			};

			// Diagnostics.
			//pc.OnReceiveReport += (re, media, rr) => logger.LogDebug($"RTCP Receive for {media} from {re}\n{rr.GetDebugSummary()}");
			//pc.OnSendReport += (media, sr) => logger.LogDebug($"RTCP Send for {media}\n{sr.GetDebugSummary()}");
			//pc.GetRtpChannel().OnStunMessageReceived += (msg, ep, isRelay) => logger.LogDebug($"STUN {msg.Header.MessageType} received from {ep}.");
			pc.oniceconnectionstatechange += (state) => FlatRedBall.Debugging.Debugger.CommandLineWrite($"ICE connection state change to {state}.");
			pc.onsignalingstatechange += () => FlatRedBall.Debugging.Debugger.CommandLineWrite($"Signalling state changed to {pc.signalingState}.");

			return pc;
		}

		private static void DoLoadTestIteration(RTCDataChannel dc, uint payloadSize)
		{
			var rndBuffer = new byte[payloadSize];
			Crypto.GetRandomBytes(rndBuffer);
			FlatRedBall.Debugging.Debugger.CommandLineWrite($"Data channel sending {payloadSize} random bytes, hash {DoJavscriptSHA256(rndBuffer)}.");
			dc.send(rndBuffer);
		}

		/// <summary>
		/// The Javascript hash function only allows a maximum input of 65535 bytes. In order to hash
		/// larger buffers for testing purposes the buffer is split into 65535 slices and then the hashes
		/// of each of the slices hashed.
		/// </summary>
		/// <param name="buffer">The buffer to perform the Javascript SHA256 hash of hashes on.</param>
		/// <returns>A hex string of the resultant hash.</returns>
		private static string DoJavscriptSHA256(byte[] buffer)
		{
			int iters = (buffer.Length <= JAVASCRIPT_SHA256_MAX_IN_SIZE) ? 1 : buffer.Length / JAVASCRIPT_SHA256_MAX_IN_SIZE;
			iters += (buffer.Length > iters * JAVASCRIPT_SHA256_MAX_IN_SIZE) ? 1 : 0;

			byte[] hashOfHashes = new byte[iters * SHA256_OUTPUT_SIZE];

			for (int i = 0; i < iters; i++)
			{
				int startPosn = i * JAVASCRIPT_SHA256_MAX_IN_SIZE;
				int length = JAVASCRIPT_SHA256_MAX_IN_SIZE;
				length = (startPosn + length > buffer.Length) ? buffer.Length - startPosn : length;

				var slice = new ArraySegment<byte>(buffer, startPosn, length);

				using (var sha256 = SHA256.Create())
				{
					Buffer.BlockCopy(sha256.ComputeHash(slice.ToArray()), 0, hashOfHashes, i * SHA256_OUTPUT_SIZE, SHA256_OUTPUT_SIZE);
				}
			}

			using (var sha256 = SHA256.Create())
			{
				return sha256.ComputeHash(hashOfHashes).HexStr();
			}
		}
	}
}
