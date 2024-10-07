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
    public abstract partial class GameScreen : FlatRedBall.Screens.Screen, FlatRedBall.Gum.IGumScreenOwner
    {
        #if DEBUG
        public static bool HasBeenLoadedWithGlobalContentManager { get; private set; }= false;
        #endif
        protected static global::test_webrtc.GumRuntimes.GameScreenGumRuntime GameScreenGum;
        
        protected global::FlatRedBall.Math.PositionedObjectList<global::test_webrtc.Entities.Player> PlayerList = new global::FlatRedBall.Math.PositionedObjectList<global::test_webrtc.Entities.Player>();
        protected global::test_webrtc.Entities.Player Player1;
        protected global::FlatRedBall.TileGraphics.LayeredTileMap Map;
        protected global::FlatRedBall.TileCollisions.TileShapeCollection mSolidCollision;
        public global::FlatRedBall.TileCollisions.TileShapeCollection SolidCollision
        {
            get
            {
                return mSolidCollision;
            }
            protected set
            {
                mSolidCollision = value;
            }
        }
        protected global::FlatRedBall.TileCollisions.TileShapeCollection mCloudCollision;
        public global::FlatRedBall.TileCollisions.TileShapeCollection CloudCollision
        {
            get
            {
                return mCloudCollision;
            }
            protected set
            {
                mCloudCollision = value;
            }
        }
        private global::FlatRedBall.Graphics.Layer HudLayer;
        private global::test_webrtc.GumRuntimes.GameScreenGumRuntime GumScreen;
        private global::FlatRedBall.Math.Collision.DelegateListVsSingleRelationship<Entities.Player, FlatRedBall.TileCollisions.TileShapeCollection> PlayerVsCloudCollision;
        private global::FlatRedBall.Math.Collision.DelegateListVsSingleRelationship<Entities.Player, FlatRedBall.TileCollisions.TileShapeCollection> PlayerVsSolidCollision;
        private global::FlatRedBall.Entities.CameraControllingEntity CameraControllingEntityInstance;
        global::Gum.Wireframe.GraphicalUiElement FlatRedBall.Gum.IGumScreenOwner.GumScreen { get; }
        void FlatRedBall.Gum.IGumScreenOwner.RefreshLayout() => RefreshLayoutInternal(null, null);
        global::test_webrtc.FormsControls.Screens.GameScreenGumForms Forms;
        protected global::RenderingLibrary.Graphics.Layer HudLayerGum;
        public GameScreen () 
        	: this ("GameScreen")
        {
        }
        public GameScreen (string contentManagerName) 
        	: base (contentManagerName)
        {
            PlayerList.Name = "PlayerList";
            // Not instantiating for FlatRedBall.TileGraphics.LayeredTileMap Map in Screens\GameScreen (Screen) because properties on the object prevent it
            // Not instantiating for FlatRedBall.TileCollisions.TileShapeCollection SolidCollision in Screens\GameScreen (Screen) because properties on the object prevent it
            // Not instantiating for FlatRedBall.TileCollisions.TileShapeCollection CloudCollision in Screens\GameScreen (Screen) because properties on the object prevent it
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            GumScreen = GameScreenGum;
            PlayerList?.Clear();
            Player1 = new global::test_webrtc.Entities.Player(ContentManagerName, false);
            Player1.Name = "Player1";
            Player1.CreationSource = "Glue";
            // Not instantiating for FlatRedBall.TileGraphics.LayeredTileMap Map in Screens\GameScreen (Screen) because properties on the object prevent it
            // Not instantiating for FlatRedBall.TileCollisions.TileShapeCollection SolidCollision in Screens\GameScreen (Screen) because properties on the object prevent it
            // Not instantiating for FlatRedBall.TileCollisions.TileShapeCollection CloudCollision in Screens\GameScreen (Screen) because properties on the object prevent it
            HudLayer = new global::FlatRedBall.Graphics.Layer();
            HudLayer.Name = "HudLayer";
            CameraControllingEntityInstance = new global::FlatRedBall.Entities.CameraControllingEntity();
            CameraControllingEntityInstance.Name = "CameraControllingEntityInstance";
            CameraControllingEntityInstance.CreationSource = "Glue";
            Forms = GameScreenGum.FormsControl ?? new global::test_webrtc.FormsControls.Screens.GameScreenGumForms(GameScreenGum);
            FlatRedBall.Math.Collision.CollisionManager.Self.BeforeCollision += HandleBeforeCollisionGenerated;
            FillCollisionForSolidCollision();
            FillCollisionForCloudCollision();
            {
    var temp = new FlatRedBall.Math.Collision.DelegateListVsSingleRelationship<Entities.Player, FlatRedBall.TileCollisions.TileShapeCollection>(PlayerList, CloudCollision);
    temp.CollisionFunction = PlayerListvCloudCollisionPlatformFunction;
    bool PlayerListvCloudCollisionPlatformFunction(Entities.Player first, FlatRedBall.TileCollisions.TileShapeCollection second)
    {
        return first.CollideAgainst(second, true);
    }
    ;
    FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Add(temp);
    PlayerVsCloudCollision = temp;
}
PlayerVsCloudCollision.Name = "PlayerVsCloudCollision";
PlayerVsCloudCollision.CollisionOccurred += (first, second) =>
{
}
;

            {
    var temp = new FlatRedBall.Math.Collision.DelegateListVsSingleRelationship<Entities.Player, FlatRedBall.TileCollisions.TileShapeCollection>(PlayerList, SolidCollision);
    temp.CollisionFunction = PlayerListvSolidCollisionPlatformFunction;
    bool PlayerListvSolidCollisionPlatformFunction(Entities.Player first, FlatRedBall.TileCollisions.TileShapeCollection second)
    {
        return first.CollideAgainst(second, false);
    }
    ;
    FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Add(temp);
    PlayerVsSolidCollision = temp;
}
PlayerVsSolidCollision.Name = "PlayerVsSolidCollision";
PlayerVsSolidCollision.CollisionOccurred += (first, second) =>
{
}
;

            
            
            PostInitialize();
            base.Initialize(addToManagers);
            this.Name = "GameScreen";
            if (addToManagers)
            {
                AddToManagers();
            }
        }
        public override void AddToManagers () 
        {
            mAccumulatedPausedTime = TimeManager.CurrentTime;
            mTimeScreenWasCreated = FlatRedBall.TimeManager.CurrentTime;
            GameScreenGum.AddToManagers(global::RenderingLibrary.SystemManagers.Default, null); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged += RefreshLayoutInternal;
            FlatRedBall.SpriteManager.AddLayer(HudLayer);
            HudLayerGum = RenderingLibrary.SystemManagers.Default.Renderer.AddLayer();
            HudLayerGum.Name = "HudLayerGum";
            FlatRedBall.Gum.GumIdb.Self.AddGumLayerToFrbLayer(HudLayerGum, HudLayer);
            InitializeFactoriesAndSorting();
            Player1.AddToManagers(mLayer);
            FlatRedBall.SpriteManager.AddPositionedObject(CameraControllingEntityInstance); CameraControllingEntityInstance.Activity();
            var Map_gameplayLayer = Map.MapLayers.FindByName("GameplayLayer");
            if (Map_gameplayLayer != null)
            {
                Map_gameplayLayer.ForceUpdateDependencies();
                // What if the map's Z isn't 0? Add its Z to make up for that
                Map.Z = Map.Z - Map_gameplayLayer.Z;
            }
            FlatRedBall.TileEntities.TileEntityInstantiator.CreateEntitiesFrom(Map);
            base.AddToManagers();
            AddToManagersBottomUp();
            BeforeCustomInitialize?.Invoke();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                GameScreenGum?.AnimateSelf(FlatRedBall.TimeManager.SecondDifference);
                for (int i = PlayerList.Count - 1; i > -1; i--)
                {
                    if (i < PlayerList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        PlayerList[i].Activity();
                    }
                }
                CameraControllingEntityInstance.Activity();
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
                for (int i = FlatRedBall.SpriteManager.ManagedPositionedObjects.Count - 1; i > -1; i--)
                {
                    var item = FlatRedBall.SpriteManager.ManagedPositionedObjects[i];
                    if (item is FlatRedBall.Entities.IEntity entity)
                    {
                        entity.ActivityEditMode();
                    }
                }
                CustomActivityEditMode();
                base.ActivityEditMode();
            }
        }
        public override void Destroy () 
        {
            RenderingLibrary.SystemManagers.Default.Renderer.RemoveLayer(HudLayerGum);
            base.Destroy();
            Factories.PlayerFactory.Destroy();
            Factories.PlayerFactory.DefaultLayer = null;
            GameScreenGum.RemoveFromManagers(); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= RefreshLayoutInternal;
            GameScreenGum = null;
            
            PlayerList.MakeOneWay();
            for (int i = PlayerList.Count - 1; i > -1; i--)
            {
                PlayerList[i].Destroy();
            }
            if (HudLayer != null)
            {
                FlatRedBall.SpriteManager.RemoveLayer(HudLayer);
            }
            if (CameraControllingEntityInstance != null)
            {
                FlatRedBall.SpriteManager.RemovePositionedObject(CameraControllingEntityInstance);;
            }
            PlayerList.MakeTwoWay();
            FlatRedBall.Math.Collision.CollisionManager.Self.BeforeCollision -= HandleBeforeCollisionGenerated;
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (!PlayerList.Contains(Player1))
            {
                PlayerList.Add(Player1);
            }
            if (Player1.Parent == null)
            {
                Player1.X = 64f;
            }
            else
            {
                Player1.RelativeX = 64f;
            }
            if (Player1.Parent == null)
            {
                Player1.Y = -64f;
            }
            else
            {
                Player1.RelativeY = -64f;
            }
            if (Map!= null)
            {
            }
            if (SolidCollision!= null)
            {
            }
            if (CloudCollision!= null)
            {
            }
            CameraControllingEntityInstance.Targets = PlayerList;
            CameraControllingEntityInstance.Map = Map;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp () 
        {
            CameraSetup.ResetCamera(SpriteManager.Camera);
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            for (int i = PlayerList.Count - 1; i > -1; i--)
            {
                PlayerList[i].Destroy();
            }
            if (HudLayer != null)
            {
                FlatRedBall.SpriteManager.RemoveLayer(HudLayer);
            }
            if (CameraControllingEntityInstance != null)
            {
                FlatRedBall.SpriteManager.RemovePositionedObject(CameraControllingEntityInstance);;
            }
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
                Player1.AssignCustomVariables(true);
            }
            if (Player1.Parent == null)
            {
                Player1.X = 64f;
            }
            else
            {
                Player1.RelativeX = 64f;
            }
            if (Player1.Parent == null)
            {
                Player1.Y = -64f;
            }
            else
            {
                Player1.RelativeY = -64f;
            }
            if (Map != null)
            {
            }
            if (SolidCollision != null)
            {
            }
            if (CloudCollision != null)
            {
            }
            CameraControllingEntityInstance.Targets = PlayerList;
            CameraControllingEntityInstance.Map = Map;
        }
        public virtual void ConvertToManuallyUpdated () 
        {
            for (int i = 0; i < PlayerList.Count; i++)
            {
                PlayerList[i].ConvertToManuallyUpdated();
            }
            if (Map != null)
            {
            }
            if (SolidCollision != null)
            {
            }
            if (CloudCollision != null)
            {
            }
        }
        public static void LoadStaticContent (string contentManagerName) 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
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
                throw new System.Exception( "GameScreen has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
            }
            #endif
            if(GameScreenGum == null)
{
 var wasSuspended = Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended;
 Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = true;
 GameScreenGum = (global::test_webrtc.GumRuntimes.GameScreenGumRuntime)GumRuntime.ElementSaveExtensions.CreateGueForElement(Gum.Managers.ObjectFinder.Self.GetElementSave("GameScreenGum"), true);
 Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = wasSuspended;
 if(!wasSuspended) { GameScreenGum.UpdateFontRecursive();GameScreenGum.UpdateLayout(); }
}
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
            Factories.PlayerFactory.Initialize(ContentManagerName);
            Factories.PlayerFactory.DefaultLayer = this.DefaultLayer;
            Factories.PlayerFactory.AddList(PlayerList);
        }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "GameScreenGum":
                    return GameScreenGum;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "GameScreenGum":
                    return GameScreenGum;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "GameScreenGum":
                    return GameScreenGum;
            }
            return null;
        }
        public static void Reload (object whatToReload) 
        {
        }
        protected virtual void RefreshLayoutInternal (object sender, EventArgs e) 
        {
            GameScreenGum?.UpdateLayout();
        }
        void HandleBeforeCollisionGenerated () 
        {
            for (int i = 0; i < PlayerList.Count; i++)
            {
                var item = PlayerList[i];
                item.GroundCollidedAgainst.Clear();
                item.LastFrameItemsCollidedAgainst.Clear();
                foreach (var name in item.ItemsCollidedAgainst)
                {
                    item.LastFrameItemsCollidedAgainst.Add(name);
                }
                item.ItemsCollidedAgainst.Clear();
                item.LastFrameObjectsCollidedAgainst.Clear();
                foreach (var name in item.ObjectsCollidedAgainst)
                {
                    item.LastFrameObjectsCollidedAgainst.Add(name);
                }
                item.ObjectsCollidedAgainst.Clear();
            }
        }
        protected virtual void FillCollisionForSolidCollision () 
        {
            if (SolidCollision != null)
            {
                // normally we wait to set variables until after the object is created, but in this case if the
                // TileShapeCollection doesn't have its Visible set before creating the tiles, it can result in
                // really bad performance issues, as shapes will be made visible, then invisible. Really bad perf!
                SolidCollision.Visible = false;
                FlatRedBall.TileCollisions.TileShapeCollectionLayeredTileMapExtensions.AddCollisionFromTilesWithType(SolidCollision, Map, "SolidCollision", false);
            }
        }
        protected virtual void FillCollisionForCloudCollision () 
        {
            if (CloudCollision != null)
            {
                // normally we wait to set variables until after the object is created, but in this case if the
                // TileShapeCollection doesn't have its Visible set before creating the tiles, it can result in
                // really bad performance issues, as shapes will be made visible, then invisible. Really bad perf!
                CloudCollision.Visible = false;
                CloudCollision.RepositionUpdateStyle = FlatRedBall.TileCollisions.RepositionUpdateStyle.Upward;
                FlatRedBall.TileCollisions.TileShapeCollectionLayeredTileMapExtensions.AddCollisionFromTilesWithType(CloudCollision, Map, "CloudCollision", false);
            }
        }
        partial void CustomActivityEditMode();
    }
    public partial class GameScreenVariant
    {
        public string Name { get; set; }
        public override string ToString() {return Name; }
        public Type Type { get; set; }
        public Performance.IEntityFactory Factory { get; set; }
        public Func<string, object> GetFile {get; private set; }
        public Action<string> LoadStaticContent { get; private set; }
        public GameScreen CreateNew (Microsoft.Xna.Framework.Vector3 position) 
        {
            if (this.Factory != null)
            {
                var toReturn = Factory.CreateNew(position.X, position.Y) as GameScreen;
                return toReturn;
            }
            else
            {
                return null;
            }
        }
        public GameScreen CreateNew (float x = 0, float y = 0) 
        {
            if (this.Factory != null)
            {
                var toReturn = Factory.CreateNew(x, y) as GameScreen;
                return toReturn;
            }
            else
            {
                return null;
            }
        }
        public static GameScreenVariant FromName (string name) 
        {
            switch(name)
            {
                case "test_webrtc.Screens.Level1":
                case  "Level1":
                    return Level1;
                case "test_webrtc.Screens.Level2":
                case  "Level2":
                    return Level2;
                case "test_webrtc.Screens.GameScreen":
                case  "GameScreen":
                    return GameScreen;
            }
            return null;
        }
        public static GameScreenVariant Level1 { get; private set; } = new GameScreenVariant
        {
            Name = "Level1",
            Type = typeof(Screens.Level1),
            GetFile = global::test_webrtc.Screens.Level1.GetFile,
            LoadStaticContent = global::test_webrtc.Screens.Level1.LoadStaticContent,
        }
        ;
        public static GameScreenVariant Level2 { get; private set; } = new GameScreenVariant
        {
            Name = "Level2",
            Type = typeof(Screens.Level2),
            GetFile = global::test_webrtc.Screens.Level2.GetFile,
            LoadStaticContent = global::test_webrtc.Screens.Level2.LoadStaticContent,
        }
        ;
        public static GameScreenVariant GameScreen { get; private set; } = new GameScreenVariant
        {
            Name = "GameScreen",
            Type = typeof(Screens.GameScreen),
            GetFile = global::test_webrtc.Screens.GameScreen.GetFile,
            LoadStaticContent = global::test_webrtc.Screens.GameScreen.LoadStaticContent,
        }
        ;
        public static List<GameScreenVariant> All = new List<GameScreenVariant>{
            Level1,
            Level2,
        };
    }
}
