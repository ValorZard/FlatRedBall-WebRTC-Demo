using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Gui;
using FlatRedBall.Math;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Localization;
using Microsoft.Xna.Framework;




namespace test_webrtc.Screens
{
    public partial class GameScreen
    {

        void CustomInitialize()
        {
			Forms.StartServerButton.Click += StartServerButton_Click;
			Forms.StartClientButton.Click += StartClientButton_Click;
        }

		// this button starts server
		private void StartServerButton_Click(object sender, EventArgs e)
		{
            var game1 = FlatRedBallServices.Game as Game1;
            game1.StartServer();
		}

		private void StartClientButton_Click(object sender, EventArgs e)
		{
			var game1 = FlatRedBallServices.Game as Game1;
			game1.StartClient();
		}

		void CustomActivity(bool firstTimeCalled)
        {


        }

        void CustomDestroy()
        {


        }

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

    }
}
