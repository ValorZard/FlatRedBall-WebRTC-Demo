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
			Forms.ButtonStandardInstance.Click += ButtonStandardInstance_Click;

        }

        // this button starts server
		private void ButtonStandardInstance_Click(object sender, EventArgs e)
		{
            var game1 = FlatRedBallServices.Game as Game1;
            game1.StartConnection();
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
