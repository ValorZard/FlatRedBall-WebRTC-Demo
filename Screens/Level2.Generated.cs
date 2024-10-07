#pragma warning disable
#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
#define SUPPORTS_GLUEVIEW_2
using Color = Microsoft.Xna.Framework.Color;
using System.Linq;
using FlatRedBall;
using System;
using System.Collections.Generic;
using System.Text;
namespace test_webrtc.Screens
{
    public partial class Level2 : GameScreen, FlatRedBall.Gum.IGumScreenOwner
    {
        #if DEBUG
        public static bool HasBeenLoadedWithGlobalContentManager { get; private set; }= false;
        #endif
        protected static global::test_webrtc.GumRuntimes.Level2GumRuntime Level2Gum;
        protected static global::FlatRedBall.TileGraphics.LayeredTileMap Level2Map;
        
        global::test_webrtc.FormsControls.Screens.Level2GumForms Forms;
        global::test_webrtc.GumRuntimes.Level2GumRuntime GumScreen;
        public Level2 () 
        	: this ("Level2")
        {
        }
        public Level2 (string contentManagerName) 
        	: base (contentManagerName)
        {
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<Player> PlayerList in Screens\Level2 (Screen) because it has its InstantiatedByBase set to true
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            Map = Level2Map;
            mSolidCollision = new FlatRedBall.TileCollisions.TileShapeCollection(); mSolidCollision.Name = "SolidCollision";
            mCloudCollision = new FlatRedBall.TileCollisions.TileShapeCollection(); mCloudCollision.Name = "CloudCollision";
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<Player> PlayerList in Screens\Level2 (Screen) because it has its InstantiatedByBase set to true
            // skipping instantiation of Player Player1 in Screens\Level2 (Screen) because it has its InstantiatedByBase set to true
            GumScreen = Level2Gum;
            Forms = Level2Gum.FormsControl ?? new global::test_webrtc.FormsControls.Screens.Level2GumForms(Level2Gum);
            
            
            base.Initialize(addToManagers);
            this.Name = "Level2";
        }
        public override void AddToManagers () 
        {
            mAccumulatedPausedTime = TimeManager.CurrentTime;
            mTimeScreenWasCreated = FlatRedBall.TimeManager.CurrentTime;
            Level2Gum.AddToManagers(global::RenderingLibrary.SystemManagers.Default, null);
            Level2Map.AddToManagers(mLayer);
            InitializeFactoriesAndSorting();
            
            
            base.AddToManagers();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                Level2Gum?.AnimateSelf(FlatRedBall.TimeManager.SecondDifference);
                Level2Map?.AnimateSelf();;
            }
            else
            {
            }
            base.Activity(firstTimeCalled);
            if (!IsActivityFinished)
            {
                CustomActivity(firstTimeCalled);
            }
        }
        public override void ActivityEditMode () 
        {
            if (FlatRedBall.Screens.ScreenManager.IsInEditMode)
            {
                CustomActivityEditMode();
                base.ActivityEditMode();
            }
        }
        public override void Destroy () 
        {
            base.Destroy();
            Level2Gum.RemoveFromManagers();
            Level2Gum = null;
            Level2Map.Destroy();
            Level2Map = null;
            
            if (Map != null)
            {
                Map.Destroy();
            }
            if (SolidCollision != null)
            {
                SolidCollision.Visible = false;
            }
            if (CloudCollision != null)
            {
                CloudCollision.Visible = false;
            }
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public override void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            base.PostInitialize();
            if (Map!= null)
            {
            }
            if (SolidCollision!= null)
            {
            }
            if (CloudCollision!= null)
            {
            }
            if (PlayerList!= null)
            {
                if (Player1!= null)
                {
                    if (Player1.Parent == null)
                    {
                        base.Player1.X = 64f;
                    }
                    else
                    {
                        base.Player1.RelativeX = 64f;
                    }
                    if (Player1.Parent == null)
                    {
                        base.Player1.Y = -64f;
                    }
                    else
                    {
                        base.Player1.RelativeY = -64f;
                    }
                }
            }
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public override void AddToManagersBottomUp () 
        {
            base.AddToManagersBottomUp();
        }
        public override void RemoveFromManagers () 
        {
            base.RemoveFromManagers();
            Level2Map.Destroy();
            if (Map != null)
            {
                Map.Destroy();
            }
            if (SolidCollision != null)
            {
                SolidCollision.Visible = false;
            }
            if (CloudCollision != null)
            {
                CloudCollision.Visible = false;
            }
        }
        public override void AssignCustomVariables (bool callOnContainedElements) 
        {
            base.AssignCustomVariables(callOnContainedElements);
            if (callOnContainedElements)
            {
            }
            if (Player1.Parent == null)
            {
                base.Player1.X = 64f;
            }
            else
            {
                base.Player1.RelativeX = 64f;
            }
            if (Player1.Parent == null)
            {
                base.Player1.Y = -64f;
            }
            else
            {
                base.Player1.RelativeY = -64f;
            }
            
        }
        public override void ConvertToManuallyUpdated () 
        {
            base.ConvertToManuallyUpdated();
        }
        public static new void LoadStaticContent (string contentManagerName) 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            global::test_webrtc.Screens.GameScreen.LoadStaticContent(contentManagerName);
            // Set the content manager for Gum
            var contentManagerWrapper = new FlatRedBall.Gum.ContentManagerWrapper();
            contentManagerWrapper.ContentManagerName = contentManagerName;
            RenderingLibrary.Content.LoaderManager.Self.ContentLoader = contentManagerWrapper;
            // Access the GumProject just in case it's async loaded
            var throwaway = GlobalContent.GumProject;
            #if DEBUG
            if (contentManagerName == FlatRedBall.FlatRedBallServices.GlobalContentManager)
            {
                HasBeenLoadedWithGlobalContentManager = true;
            }
            else if (HasBeenLoadedWithGlobalContentManager)
            {
                throw new System.Exception( "Level2 has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
            }
            #endif
            if(Level2Gum == null)
{
 var wasSuspended = Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended;
 Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = true;
 Level2Gum = (global::test_webrtc.GumRuntimes.Level2GumRuntime)GumRuntime.ElementSaveExtensions.CreateGueForElement(Gum.Managers.ObjectFinder.Self.GetElementSave("Level2Gum"), true);
 Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = wasSuspended;
 if(!wasSuspended) { Level2Gum.UpdateFontRecursive();Level2Gum.UpdateLayout(); }
}
            Level2Map = FlatRedBall.TileGraphics.LayeredTileMap.FromTiledMapSave("Content/Screens/Level2/Level2Map.tmx", contentManagerName);
            CustomLoadStaticContent(contentManagerName);
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public override void PauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Pause();
            base.PauseThisScreen();
        }
        public override void UnpauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Unpause();
            base.UnpauseThisScreen();
        }
        private void InitializeFactoriesAndSorting () 
        {
        }
        [System.Obsolete("Use GetFile instead")]
        public static new object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "Level2Gum":
                    return Level2Gum;
                case  "Level2Map":
                    return Level2Map;
            }
            return null;
        }
        public static new object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "Level2Gum":
                    return Level2Gum;
                case  "Level2Map":
                    return Level2Map;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "Level2Gum":
                    return Level2Gum;
                case  "Level2Map":
                    return Level2Map;
            }
            return null;
        }
        public static void Reload (object whatToReload) 
        {
        }
        protected override void RefreshLayoutInternal (object sender, EventArgs e) 
        {
            Level2Gum?.UpdateLayout();
            base.RefreshLayoutInternal(sender, e);
        }
        partial void CustomActivityEditMode();
    }
}
