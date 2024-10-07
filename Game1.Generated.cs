// The following #defines come from the version of your GLUJ/GLUX file. For more information see https://docs.flatredball.com/flatredball/glue-reference/glujglux
#define PreVersion
#define HasFormsObject
#define AddedGeneratedGame1
#define ListsHaveAssociateWithFactoryBool
#define GumGueHasGetAnimation
#define CsvInheritanceSupport
#define IPositionedSizedObjectInEngine
#define NugetPackageInCsproj
#define SupportsEditMode
#define SupportsShapeCollectionAddToManagerMakeAutomaticallyUpdated
#define ScreensHaveActivityEditMode
#define SupportsNamedSubcollisions
#define TimeManagerHasDelaySeconds
#define GumTextHasIsBold
#define GlueSavedToJson
#define IEntityInFrb
#define SeparateJsonFilesForElements
#define GumSupportsAchxAnimation
#define StartupInGeneratedGame
#define RemoveAutoLocalizationOfVariables
#define GumHasMIsLayoutSuspendedPublic
#define SpriteHasUseAnimationTextureFlip
#define RemoveIsScrollableEntityList
#define HasGetGridLine
#define HasScreenManagerAfterScreenDestroyed
#define ScreenManagerHasPersistentPolygons
#define ShapeManagerCollideAgainstClosest
#define SpriteHasTolerateMissingAnimations
#define AnimationLayerHasName
#define IPlatformer
#define GumDefaults2
#define IStackableInEngine
#define ICollidableHasItemsCollidedAgainst
#define CollisionRelationshipManualPhysics
#define GumSupportsStackSpacing
#define CollisionRelationshipsSupportMoveSoft
#define GeneratedCameraSetupFile
#define ShapeCollectionHasMaxAxisAlignedRectanglesRadiusX
#define AutoNameCollisionListsAsSingle
#define GumHasIgnoredByParentSize
#define GumTextObjectsUpdateTextWith0ChildDepth
#define HasFrameworkElementManager
#define HasGumSkiaElements
#define ITiledTileMetadataInFrb
#define DamageableHasHealth
#define HasGame1GenerateEarly
#define ICollidableHasObjectsCollidedAgainst
#define HasIRepeatPressableInput
#define AllTiledFilesGenerated
#define RemoveRedundantDerivedData
#define GraphicalUiElementProtectedAnimationProperties
#define GraphicalUiElementINotifyPropertyChanged
#define GumTextObjectsHaveTextOverflowProperties
#define TileShapeCollectionAddToLayerSupportsAutomaticallyUpdated
#define ISongInFrb
#define RendererHasExternalEffectManager
#define SpriteHasSetCollisionFromAnimation
#define HasIGumScreenOwner
#define ScreenIsINameable
#define SpriteManagerHasInsertLayer
#define GumUsesSystemTypes
#define GumCommonCodeReferencing
#define GumTextSupportsBbCode
#define DamageDealingToggles
#define VariantsInsteadOfTypes
#define ITopDownEntity
#define CaseSensitiveLoading
#define ScreensHaveDefaultLayer
#define HasFrbServicesGraphicsDeviceManager
#define ShapeCollectionHasLastCollisionCallDeepCheckCount
#define ScreenHasCancellationToken
#define GameCanStartInEditMode

using System.Linq;
namespace test_webrtc
{
    public partial class Game1
    {
        RenderingLibrary.Graphics.IRenderable GetRenderable (string name, global::RenderingLibrary.ISystemManagers managers) 
        {
            var asBaseType = Gum.Wireframe.RuntimeObjectCreator.TryHandleAsBaseType(name, managers);
            return asBaseType;
        }
        partial void GeneratedInitializeEarly () 
        {
            FlatRedBall.FlatRedBallServices.AddManager(FlatRedBall.Forms.Managers.FrameworkElementManager.Self);
        }
        partial void GeneratedInitialize () 
        {
            global::GumRuntime.ElementSaveExtensions.CustomCreateGraphicalComponentFunc = GetRenderable;
            global::Gum.Wireframe.GraphicalUiElement.SetPropertyOnRenderable = global::Gum.Wireframe.CustomSetPropertyOnRenderable.SetPropertyOnRenderable;
            global::Gum.Wireframe.GraphicalUiElement.UpdateFontFromProperties = global::Gum.Wireframe.CustomSetPropertyOnRenderable.UpdateToFontValues;
            global::Gum.Wireframe.GraphicalUiElement.ThrowExceptionsForMissingFiles = global::Gum.Wireframe.CustomSetPropertyOnRenderable.ThrowExceptionsForMissingFiles;
            global::Gum.Wireframe.GraphicalUiElement.AddRenderableToManagers = global::Gum.Wireframe.CustomSetPropertyOnRenderable.AddRenderableToManagers;
            global::Gum.Wireframe.GraphicalUiElement.RemoveRenderableFromManagers = global::Gum.Wireframe.CustomSetPropertyOnRenderable.RemoveRenderableFromManagers;
            global::test_webrtc.GlobalContent.Initialize();
            var args = System.Environment.GetCommandLineArgs();
            bool? changeResize = null;
            var resizeArgs = args.FirstOrDefault(item => item.StartsWith("AllowWindowResizing="));
            if (!string.IsNullOrEmpty(resizeArgs))
            {
                var afterEqual = resizeArgs.Split('=')[1];
                changeResize = bool.Parse(afterEqual);
            }
            if (changeResize != null)
            {
                CameraSetup.Data.AllowWindowResizing = changeResize.Value;
            }
            CameraSetup.SetupCamera(FlatRedBall.Camera.Main, graphics);
            #if WEB
            global::FlatRedBall.FlatRedBallServices.ForceClientSizeUpdates();
            #endif
            #if GameCanStartInEditMode || REFERENCES_FRB_SOURCE
            var isInEditMode = args.FirstOrDefault(item => item.StartsWith("IsInEditMode="));
            if (!string.IsNullOrEmpty(isInEditMode))
            {
                //I started working on this, but decided to drop it because it's more complicated than simply setting
                //IsNextScreenInEditMode. The code that handles SetEditMode dto needs to run, which is a bigger refator. 
                //I'll keep this code in here for now, and return later when I'm ready to do a bigger refactor. 
                //var afterEqual = isInEditMode.Split('=')[1];
                //FlatRedBall.Screens.ScreenManager.IsNextScreenInEditMode = bool.Parse(afterEqual);
                //this.IsMouseVisible = true;
            }
            #endif
            System.Type startScreenType = typeof(global::test_webrtc.Screens.Level1);
            var commandLineArgs = System.Environment.GetCommandLineArgs();
            if (commandLineArgs.Length > 0)
            {
                var thisAssembly = this.GetType().Assembly;
                // see if any of these are screens:
                foreach (var item in commandLineArgs)
                {
                    var type = thisAssembly.GetType(item);
                    if (type != null)
                    {
                        startScreenType = type;
                        break;
                    }
                }
            }
            if (startScreenType != null)
            {
                FlatRedBall.Screens.ScreenManager.Start(startScreenType);
            }
            // This value is used for parallax. If the game doesn't change its resolution, this this code should solve parallax with zooming cameras.
            global::FlatRedBall.TileGraphics.MapDrawableBatch.NativeCameraWidth = global::test_webrtc.CameraSetup.Data.ResolutionWidth;
            global::FlatRedBall.TileGraphics.MapDrawableBatch.NativeCameraHeight = global::test_webrtc.CameraSetup.Data.ResolutionHeight;
        }
        partial void GeneratedUpdate (Microsoft.Xna.Framework.GameTime gameTime) 
        {
        }
        partial void GeneratedDrawEarly (Microsoft.Xna.Framework.GameTime gameTime) 
        {
        }
        partial void GeneratedDraw (Microsoft.Xna.Framework.GameTime gameTime) 
        {
        }
    }
}
