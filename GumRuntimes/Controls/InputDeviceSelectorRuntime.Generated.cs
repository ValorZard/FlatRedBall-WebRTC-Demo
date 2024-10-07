using System.Linq;
namespace test_webrtc.GumRuntimes.Controls
{
    public partial class InputDeviceSelectorRuntime : global::test_webrtc.GumRuntimes.ContainerRuntime, global::test_webrtc.GumRuntimes.IInputDeviceSelectorBehavior
    {
        #region State Enums
        public enum VariableState
        {
            Default
        }
        #endregion
        #region State Fields
        VariableState mCurrentVariableState;
        #endregion
        #region State Properties
        public VariableState CurrentVariableState
        {
            get
            {
                return mCurrentVariableState;
            }
            set
            {
                mCurrentVariableState = value;
                switch(mCurrentVariableState)
                {
                    case  VariableState.Default:
                        TextInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance1") ?? this;
                        TextInstance1.Parent = this.GetGraphicalUiElementByName("ContainerInstance2") ?? this;
                        InputDeviceSelectionItemInstance.Parent = this.GetGraphicalUiElementByName("InputDeviceContainerInstance") ?? this;
                        InputDeviceSelectionItemInstance1.Parent = this.GetGraphicalUiElementByName("InputDeviceContainerInstance") ?? this;
                        InputDeviceSelectionItemInstance2.Parent = this.GetGraphicalUiElementByName("InputDeviceContainerInstance") ?? this;
                        InputDeviceSelectionItemInstance3.Parent = this.GetGraphicalUiElementByName("InputDeviceContainerInstance") ?? this;
                        Background.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                        Background.CurrentStyleCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Panel;
                        TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                        TextInstance.CurrentStyleCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory.H1;
                        TextInstance1.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                        TextInstance1.CurrentStyleCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory.H1;
                        Height = 6f;
                        HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        Width = 60f;
                        WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        X = 0f;
                        XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        Y = 0f;
                        YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        TextInstance.Text = "Press A / Space to Join";
                        TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        TextInstance.X = 0f;
                        TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        TextInstance.Y = 0f;
                        TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        TextInstance1.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        TextInstance1.Text = "Press Start / Enter to Continue";
                        TextInstance1.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        TextInstance1.X = 0f;
                        TextInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        TextInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        TextInstance1.Y = 0f;
                        TextInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        TextInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        ContainerInstance1.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        ContainerInstance1.Height = 31f;
                        ContainerInstance1.Width = 0f;
                        ContainerInstance1.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        ContainerInstance1.X = 0f;
                        ContainerInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        ContainerInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        ContainerInstance1.Y = 27f;
                        ContainerInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        ContainerInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        InputDeviceContainerInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        InputDeviceContainerInstance.Height = 20f;
                        InputDeviceContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        InputDeviceContainerInstance.StackSpacing = 4f;
                        InputDeviceContainerInstance.Width = 0f;
                        InputDeviceContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        InputDeviceContainerInstance.X = 0f;
                        InputDeviceContainerInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        InputDeviceContainerInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        InputDeviceContainerInstance.Y = 89f;
                        InputDeviceContainerInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        InputDeviceContainerInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        ContainerInstance2.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        ContainerInstance2.Height = 31f;
                        ContainerInstance2.Width = 0f;
                        ContainerInstance2.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        ContainerInstance2.X = 0f;
                        ContainerInstance2.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        ContainerInstance2.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        ContainerInstance2.Y = 228f;
                        ContainerInstance2.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        ContainerInstance2.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        break;
                }
            }
        }
        #endregion
        #region State Interpolation
        public void InterpolateBetween (VariableState firstState, VariableState secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            bool setBackgroundCurrentColorCategoryStateFirstValue = false;
            bool setBackgroundCurrentColorCategoryStateSecondValue = false;
            global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory BackgroundCurrentColorCategoryStateFirstValue= global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory BackgroundCurrentColorCategoryStateSecondValue= global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            bool setBackgroundCurrentStyleCategoryStateFirstValue = false;
            bool setBackgroundCurrentStyleCategoryStateSecondValue = false;
            global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory BackgroundCurrentStyleCategoryStateFirstValue= global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory BackgroundCurrentStyleCategoryStateSecondValue= global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            bool setContainerInstance1HeightFirstValue = false;
            bool setContainerInstance1HeightSecondValue = false;
            float ContainerInstance1HeightFirstValue= 0;
            float ContainerInstance1HeightSecondValue= 0;
            bool setContainerInstance1WidthFirstValue = false;
            bool setContainerInstance1WidthSecondValue = false;
            float ContainerInstance1WidthFirstValue= 0;
            float ContainerInstance1WidthSecondValue= 0;
            bool setContainerInstance1XFirstValue = false;
            bool setContainerInstance1XSecondValue = false;
            float ContainerInstance1XFirstValue= 0;
            float ContainerInstance1XSecondValue= 0;
            bool setContainerInstance1YFirstValue = false;
            bool setContainerInstance1YSecondValue = false;
            float ContainerInstance1YFirstValue= 0;
            float ContainerInstance1YSecondValue= 0;
            bool setContainerInstance2HeightFirstValue = false;
            bool setContainerInstance2HeightSecondValue = false;
            float ContainerInstance2HeightFirstValue= 0;
            float ContainerInstance2HeightSecondValue= 0;
            bool setContainerInstance2WidthFirstValue = false;
            bool setContainerInstance2WidthSecondValue = false;
            float ContainerInstance2WidthFirstValue= 0;
            float ContainerInstance2WidthSecondValue= 0;
            bool setContainerInstance2XFirstValue = false;
            bool setContainerInstance2XSecondValue = false;
            float ContainerInstance2XFirstValue= 0;
            float ContainerInstance2XSecondValue= 0;
            bool setContainerInstance2YFirstValue = false;
            bool setContainerInstance2YSecondValue = false;
            float ContainerInstance2YFirstValue= 0;
            float ContainerInstance2YSecondValue= 0;
            bool setHeightFirstValue = false;
            bool setHeightSecondValue = false;
            float HeightFirstValue= 0;
            float HeightSecondValue= 0;
            bool setInputDeviceContainerInstanceHeightFirstValue = false;
            bool setInputDeviceContainerInstanceHeightSecondValue = false;
            float InputDeviceContainerInstanceHeightFirstValue= 0;
            float InputDeviceContainerInstanceHeightSecondValue= 0;
            bool setInputDeviceContainerInstanceStackSpacingFirstValue = false;
            bool setInputDeviceContainerInstanceStackSpacingSecondValue = false;
            float InputDeviceContainerInstanceStackSpacingFirstValue= 0;
            float InputDeviceContainerInstanceStackSpacingSecondValue= 0;
            bool setInputDeviceContainerInstanceWidthFirstValue = false;
            bool setInputDeviceContainerInstanceWidthSecondValue = false;
            float InputDeviceContainerInstanceWidthFirstValue= 0;
            float InputDeviceContainerInstanceWidthSecondValue= 0;
            bool setInputDeviceContainerInstanceXFirstValue = false;
            bool setInputDeviceContainerInstanceXSecondValue = false;
            float InputDeviceContainerInstanceXFirstValue= 0;
            float InputDeviceContainerInstanceXSecondValue= 0;
            bool setInputDeviceContainerInstanceYFirstValue = false;
            bool setInputDeviceContainerInstanceYSecondValue = false;
            float InputDeviceContainerInstanceYFirstValue= 0;
            float InputDeviceContainerInstanceYSecondValue= 0;
            bool setTextInstanceCurrentColorCategoryStateFirstValue = false;
            bool setTextInstanceCurrentColorCategoryStateSecondValue = false;
            global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateFirstValue= global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Black;
            global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateSecondValue= global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Black;
            bool setTextInstanceCurrentStyleCategoryStateFirstValue = false;
            bool setTextInstanceCurrentStyleCategoryStateSecondValue = false;
            global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory TextInstanceCurrentStyleCategoryStateFirstValue= global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory.Tiny;
            global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory TextInstanceCurrentStyleCategoryStateSecondValue= global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory.Tiny;
            bool setTextInstanceXFirstValue = false;
            bool setTextInstanceXSecondValue = false;
            float TextInstanceXFirstValue= 0;
            float TextInstanceXSecondValue= 0;
            bool setTextInstanceYFirstValue = false;
            bool setTextInstanceYSecondValue = false;
            float TextInstanceYFirstValue= 0;
            float TextInstanceYSecondValue= 0;
            bool setTextInstance1CurrentColorCategoryStateFirstValue = false;
            bool setTextInstance1CurrentColorCategoryStateSecondValue = false;
            global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory TextInstance1CurrentColorCategoryStateFirstValue= global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Black;
            global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory TextInstance1CurrentColorCategoryStateSecondValue= global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Black;
            bool setTextInstance1CurrentStyleCategoryStateFirstValue = false;
            bool setTextInstance1CurrentStyleCategoryStateSecondValue = false;
            global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory TextInstance1CurrentStyleCategoryStateFirstValue= global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory.Tiny;
            global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory TextInstance1CurrentStyleCategoryStateSecondValue= global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory.Tiny;
            bool setTextInstance1XFirstValue = false;
            bool setTextInstance1XSecondValue = false;
            float TextInstance1XFirstValue= 0;
            float TextInstance1XSecondValue= 0;
            bool setTextInstance1YFirstValue = false;
            bool setTextInstance1YSecondValue = false;
            float TextInstance1YFirstValue= 0;
            float TextInstance1YSecondValue= 0;
            bool setWidthFirstValue = false;
            bool setWidthSecondValue = false;
            float WidthFirstValue= 0;
            float WidthSecondValue= 0;
            bool setXFirstValue = false;
            bool setXSecondValue = false;
            float XFirstValue= 0;
            float XSecondValue= 0;
            bool setYFirstValue = false;
            bool setYSecondValue = false;
            float YFirstValue= 0;
            float YSecondValue= 0;
            switch(firstState)
            {
                case  VariableState.Default:
                    setBackgroundCurrentColorCategoryStateFirstValue = true;
                    BackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    setBackgroundCurrentStyleCategoryStateFirstValue = true;
                    BackgroundCurrentStyleCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Panel;
                    if (interpolationValue < 1)
                    {
                        this.ContainerInstance1.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                    }
                    setContainerInstance1HeightFirstValue = true;
                    ContainerInstance1HeightFirstValue = 31f;
                    setContainerInstance1WidthFirstValue = true;
                    ContainerInstance1WidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.ContainerInstance1.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    setContainerInstance1XFirstValue = true;
                    ContainerInstance1XFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.ContainerInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ContainerInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setContainerInstance1YFirstValue = true;
                    ContainerInstance1YFirstValue = 27f;
                    if (interpolationValue < 1)
                    {
                        this.ContainerInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ContainerInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ContainerInstance2.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                    }
                    setContainerInstance2HeightFirstValue = true;
                    ContainerInstance2HeightFirstValue = 31f;
                    setContainerInstance2WidthFirstValue = true;
                    ContainerInstance2WidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.ContainerInstance2.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    setContainerInstance2XFirstValue = true;
                    ContainerInstance2XFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.ContainerInstance2.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ContainerInstance2.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setContainerInstance2YFirstValue = true;
                    ContainerInstance2YFirstValue = 228f;
                    if (interpolationValue < 1)
                    {
                        this.ContainerInstance2.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ContainerInstance2.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setHeightFirstValue = true;
                    HeightFirstValue = 6f;
                    if (interpolationValue < 1)
                    {
                        this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceContainerInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                    }
                    setInputDeviceContainerInstanceHeightFirstValue = true;
                    InputDeviceContainerInstanceHeightFirstValue = 20f;
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    setInputDeviceContainerInstanceStackSpacingFirstValue = true;
                    InputDeviceContainerInstanceStackSpacingFirstValue = 4f;
                    setInputDeviceContainerInstanceWidthFirstValue = true;
                    InputDeviceContainerInstanceWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    setInputDeviceContainerInstanceXFirstValue = true;
                    InputDeviceContainerInstanceXFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceContainerInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceContainerInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setInputDeviceContainerInstanceYFirstValue = true;
                    InputDeviceContainerInstanceYFirstValue = 89f;
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceContainerInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceContainerInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceSelectionItemInstance.Parent = this.GetGraphicalUiElementByName("InputDeviceContainerInstance") ?? this;
                    }
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceSelectionItemInstance1.Parent = this.GetGraphicalUiElementByName("InputDeviceContainerInstance") ?? this;
                    }
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceSelectionItemInstance2.Parent = this.GetGraphicalUiElementByName("InputDeviceContainerInstance") ?? this;
                    }
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceSelectionItemInstance3.Parent = this.GetGraphicalUiElementByName("InputDeviceContainerInstance") ?? this;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance1") ?? this;
                    }
                    setTextInstanceCurrentStyleCategoryStateFirstValue = true;
                    TextInstanceCurrentStyleCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory.H1;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.Text = "Press A / Space to Join";
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    setTextInstanceXFirstValue = true;
                    TextInstanceXFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setTextInstanceYFirstValue = true;
                    TextInstanceYFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setTextInstance1CurrentColorCategoryStateFirstValue = true;
                    TextInstance1CurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance1.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance1.Parent = this.GetGraphicalUiElementByName("ContainerInstance2") ?? this;
                    }
                    setTextInstance1CurrentStyleCategoryStateFirstValue = true;
                    TextInstance1CurrentStyleCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory.H1;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance1.Text = "Press Start / Enter to Continue";
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance1.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    setTextInstance1XFirstValue = true;
                    TextInstance1XFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setTextInstance1YFirstValue = true;
                    TextInstance1YFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setWidthFirstValue = true;
                    WidthFirstValue = 60f;
                    if (interpolationValue < 1)
                    {
                        this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    setXFirstValue = true;
                    XFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setYFirstValue = true;
                    YFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    setBackgroundCurrentColorCategoryStateSecondValue = true;
                    BackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    setBackgroundCurrentStyleCategoryStateSecondValue = true;
                    BackgroundCurrentStyleCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Panel;
                    if (interpolationValue >= 1)
                    {
                        this.ContainerInstance1.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                    }
                    setContainerInstance1HeightSecondValue = true;
                    ContainerInstance1HeightSecondValue = 31f;
                    setContainerInstance1WidthSecondValue = true;
                    ContainerInstance1WidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.ContainerInstance1.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    setContainerInstance1XSecondValue = true;
                    ContainerInstance1XSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.ContainerInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ContainerInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setContainerInstance1YSecondValue = true;
                    ContainerInstance1YSecondValue = 27f;
                    if (interpolationValue >= 1)
                    {
                        this.ContainerInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ContainerInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ContainerInstance2.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                    }
                    setContainerInstance2HeightSecondValue = true;
                    ContainerInstance2HeightSecondValue = 31f;
                    setContainerInstance2WidthSecondValue = true;
                    ContainerInstance2WidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.ContainerInstance2.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    setContainerInstance2XSecondValue = true;
                    ContainerInstance2XSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.ContainerInstance2.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ContainerInstance2.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setContainerInstance2YSecondValue = true;
                    ContainerInstance2YSecondValue = 228f;
                    if (interpolationValue >= 1)
                    {
                        this.ContainerInstance2.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ContainerInstance2.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setHeightSecondValue = true;
                    HeightSecondValue = 6f;
                    if (interpolationValue >= 1)
                    {
                        this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceContainerInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                    }
                    setInputDeviceContainerInstanceHeightSecondValue = true;
                    InputDeviceContainerInstanceHeightSecondValue = 20f;
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    setInputDeviceContainerInstanceStackSpacingSecondValue = true;
                    InputDeviceContainerInstanceStackSpacingSecondValue = 4f;
                    setInputDeviceContainerInstanceWidthSecondValue = true;
                    InputDeviceContainerInstanceWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    setInputDeviceContainerInstanceXSecondValue = true;
                    InputDeviceContainerInstanceXSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceContainerInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceContainerInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setInputDeviceContainerInstanceYSecondValue = true;
                    InputDeviceContainerInstanceYSecondValue = 89f;
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceContainerInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceContainerInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceSelectionItemInstance.Parent = this.GetGraphicalUiElementByName("InputDeviceContainerInstance") ?? this;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceSelectionItemInstance1.Parent = this.GetGraphicalUiElementByName("InputDeviceContainerInstance") ?? this;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceSelectionItemInstance2.Parent = this.GetGraphicalUiElementByName("InputDeviceContainerInstance") ?? this;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceSelectionItemInstance3.Parent = this.GetGraphicalUiElementByName("InputDeviceContainerInstance") ?? this;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance1") ?? this;
                    }
                    setTextInstanceCurrentStyleCategoryStateSecondValue = true;
                    TextInstanceCurrentStyleCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory.H1;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.Text = "Press A / Space to Join";
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    setTextInstanceXSecondValue = true;
                    TextInstanceXSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setTextInstanceYSecondValue = true;
                    TextInstanceYSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setTextInstance1CurrentColorCategoryStateSecondValue = true;
                    TextInstance1CurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance1.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance1.Parent = this.GetGraphicalUiElementByName("ContainerInstance2") ?? this;
                    }
                    setTextInstance1CurrentStyleCategoryStateSecondValue = true;
                    TextInstance1CurrentStyleCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory.H1;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance1.Text = "Press Start / Enter to Continue";
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance1.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    setTextInstance1XSecondValue = true;
                    TextInstance1XSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setTextInstance1YSecondValue = true;
                    TextInstance1YSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setWidthSecondValue = true;
                    WidthSecondValue = 60f;
                    if (interpolationValue >= 1)
                    {
                        this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    setXSecondValue = true;
                    XSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setYSecondValue = true;
                    YSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    break;
            }
            var wasSuppressed = mIsLayoutSuspended;
            var shouldSuspend = wasSuppressed == false;
            var suspendRecursively = true;
            if (shouldSuspend)
            {
                SuspendLayout(suspendRecursively);
            }
            if (setBackgroundCurrentColorCategoryStateFirstValue && setBackgroundCurrentColorCategoryStateSecondValue)
            {
                Background.InterpolateBetween(BackgroundCurrentColorCategoryStateFirstValue, BackgroundCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setBackgroundCurrentStyleCategoryStateFirstValue && setBackgroundCurrentStyleCategoryStateSecondValue)
            {
                Background.InterpolateBetween(BackgroundCurrentStyleCategoryStateFirstValue, BackgroundCurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setContainerInstance1HeightFirstValue && setContainerInstance1HeightSecondValue)
            {
                ContainerInstance1.Height = ContainerInstance1HeightFirstValue * (1 - interpolationValue) + ContainerInstance1HeightSecondValue * interpolationValue;
            }
            if (setContainerInstance1WidthFirstValue && setContainerInstance1WidthSecondValue)
            {
                ContainerInstance1.Width = ContainerInstance1WidthFirstValue * (1 - interpolationValue) + ContainerInstance1WidthSecondValue * interpolationValue;
            }
            if (setContainerInstance1XFirstValue && setContainerInstance1XSecondValue)
            {
                ContainerInstance1.X = ContainerInstance1XFirstValue * (1 - interpolationValue) + ContainerInstance1XSecondValue * interpolationValue;
            }
            if (setContainerInstance1YFirstValue && setContainerInstance1YSecondValue)
            {
                ContainerInstance1.Y = ContainerInstance1YFirstValue * (1 - interpolationValue) + ContainerInstance1YSecondValue * interpolationValue;
            }
            if (setContainerInstance2HeightFirstValue && setContainerInstance2HeightSecondValue)
            {
                ContainerInstance2.Height = ContainerInstance2HeightFirstValue * (1 - interpolationValue) + ContainerInstance2HeightSecondValue * interpolationValue;
            }
            if (setContainerInstance2WidthFirstValue && setContainerInstance2WidthSecondValue)
            {
                ContainerInstance2.Width = ContainerInstance2WidthFirstValue * (1 - interpolationValue) + ContainerInstance2WidthSecondValue * interpolationValue;
            }
            if (setContainerInstance2XFirstValue && setContainerInstance2XSecondValue)
            {
                ContainerInstance2.X = ContainerInstance2XFirstValue * (1 - interpolationValue) + ContainerInstance2XSecondValue * interpolationValue;
            }
            if (setContainerInstance2YFirstValue && setContainerInstance2YSecondValue)
            {
                ContainerInstance2.Y = ContainerInstance2YFirstValue * (1 - interpolationValue) + ContainerInstance2YSecondValue * interpolationValue;
            }
            if (setHeightFirstValue && setHeightSecondValue)
            {
                Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
            }
            if (setInputDeviceContainerInstanceHeightFirstValue && setInputDeviceContainerInstanceHeightSecondValue)
            {
                InputDeviceContainerInstance.Height = InputDeviceContainerInstanceHeightFirstValue * (1 - interpolationValue) + InputDeviceContainerInstanceHeightSecondValue * interpolationValue;
            }
            if (setInputDeviceContainerInstanceStackSpacingFirstValue && setInputDeviceContainerInstanceStackSpacingSecondValue)
            {
                InputDeviceContainerInstance.StackSpacing = InputDeviceContainerInstanceStackSpacingFirstValue * (1 - interpolationValue) + InputDeviceContainerInstanceStackSpacingSecondValue * interpolationValue;
            }
            if (setInputDeviceContainerInstanceWidthFirstValue && setInputDeviceContainerInstanceWidthSecondValue)
            {
                InputDeviceContainerInstance.Width = InputDeviceContainerInstanceWidthFirstValue * (1 - interpolationValue) + InputDeviceContainerInstanceWidthSecondValue * interpolationValue;
            }
            if (setInputDeviceContainerInstanceXFirstValue && setInputDeviceContainerInstanceXSecondValue)
            {
                InputDeviceContainerInstance.X = InputDeviceContainerInstanceXFirstValue * (1 - interpolationValue) + InputDeviceContainerInstanceXSecondValue * interpolationValue;
            }
            if (setInputDeviceContainerInstanceYFirstValue && setInputDeviceContainerInstanceYSecondValue)
            {
                InputDeviceContainerInstance.Y = InputDeviceContainerInstanceYFirstValue * (1 - interpolationValue) + InputDeviceContainerInstanceYSecondValue * interpolationValue;
            }
            if (setTextInstanceCurrentColorCategoryStateFirstValue && setTextInstanceCurrentColorCategoryStateSecondValue)
            {
                TextInstance.InterpolateBetween(TextInstanceCurrentColorCategoryStateFirstValue, TextInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setTextInstanceCurrentStyleCategoryStateFirstValue && setTextInstanceCurrentStyleCategoryStateSecondValue)
            {
                TextInstance.InterpolateBetween(TextInstanceCurrentStyleCategoryStateFirstValue, TextInstanceCurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setTextInstanceXFirstValue && setTextInstanceXSecondValue)
            {
                TextInstance.X = TextInstanceXFirstValue * (1 - interpolationValue) + TextInstanceXSecondValue * interpolationValue;
            }
            if (setTextInstanceYFirstValue && setTextInstanceYSecondValue)
            {
                TextInstance.Y = TextInstanceYFirstValue * (1 - interpolationValue) + TextInstanceYSecondValue * interpolationValue;
            }
            if (setTextInstance1CurrentColorCategoryStateFirstValue && setTextInstance1CurrentColorCategoryStateSecondValue)
            {
                TextInstance1.InterpolateBetween(TextInstance1CurrentColorCategoryStateFirstValue, TextInstance1CurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setTextInstance1CurrentStyleCategoryStateFirstValue && setTextInstance1CurrentStyleCategoryStateSecondValue)
            {
                TextInstance1.InterpolateBetween(TextInstance1CurrentStyleCategoryStateFirstValue, TextInstance1CurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setTextInstance1XFirstValue && setTextInstance1XSecondValue)
            {
                TextInstance1.X = TextInstance1XFirstValue * (1 - interpolationValue) + TextInstance1XSecondValue * interpolationValue;
            }
            if (setTextInstance1YFirstValue && setTextInstance1YSecondValue)
            {
                TextInstance1.Y = TextInstance1YFirstValue * (1 - interpolationValue) + TextInstance1YSecondValue * interpolationValue;
            }
            if (setWidthFirstValue && setWidthSecondValue)
            {
                Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
            }
            if (setXFirstValue && setXSecondValue)
            {
                X = XFirstValue * (1 - interpolationValue) + XSecondValue * interpolationValue;
            }
            if (setYFirstValue && setYSecondValue)
            {
                Y = YFirstValue * (1 - interpolationValue) + YSecondValue * interpolationValue;
            }
            if (interpolationValue < 1)
            {
                mCurrentVariableState = firstState;
            }
            else
            {
                mCurrentVariableState = secondState;
            }
            if (shouldSuspend)
            {
                ResumeLayout(suspendRecursively);
            }
        }
        #endregion
        #region State Interpolate To
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (global::test_webrtc.GumRuntimes.Controls.InputDeviceSelectorRuntime.VariableState fromState,global::test_webrtc.GumRuntimes.Controls.InputDeviceSelectorRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
        {
            FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from:0, to:1, duration:(float)secondsToTake, type:interpolationType, easing:easing );
            if (owner == null)
            {
                tweener.Owner = this;
            }
            else
            {
                tweener.Owner = owner;
            }
            tweener.PositionChanged = newPosition => this.InterpolateBetween(fromState, toState, newPosition);
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.States.First(item => item.Name == toState.ToString());
            FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
            if (owner == null)
            {
                tweener.Owner = this;
            }
            else
            {
                tweener.Owner = owner;
            }
            tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
            tweener.Ended += ()=> this.CurrentVariableState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = AddToCurrentValuesWithState(toState);
            FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
            if (owner == null)
            {
                tweener.Owner = this;
            }
            else
            {
                tweener.Owner = owner;
            }
            tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
            tweener.Ended += ()=> this.CurrentVariableState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        #endregion
        #region State Animations
        #endregion
        public override void StopAnimations () 
        {
            base.StopAnimations();
            InputDeviceSelectionItemInstance.StopAnimations();
            InputDeviceSelectionItemInstance1.StopAnimations();
            InputDeviceSelectionItemInstance2.StopAnimations();
            InputDeviceSelectionItemInstance3.StopAnimations();
        }
        public override FlatRedBall.Gum.Animation.GumAnimation GetAnimation (string animationName) 
        {
            return base.GetAnimation(animationName);
        }
        #region Get Current Values on State
        private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (VariableState state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  VariableState.Default:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Height",
                        Type = "float",
                        Value = Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Height Units",
                        Type = "DimensionUnitType",
                        Value = HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Width",
                        Type = "float",
                        Value = Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Width Units",
                        Type = "DimensionUnitType",
                        Value = WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "X",
                        Type = "float",
                        Value = X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "X Origin",
                        Type = "HorizontalAlignment",
                        Value = XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "X Units",
                        Type = "PositionUnitType",
                        Value = XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Y",
                        Type = "float",
                        Value = Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Y Origin",
                        Type = "VerticalAlignment",
                        Value = YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Y Units",
                        Type = "PositionUnitType",
                        Value = YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = Background.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = Background.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.HorizontalAlignment",
                        Type = "HorizontalAlignment",
                        Value = TextInstance.HorizontalAlignment
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Parent",
                        Type = "string",
                        Value = TextInstance.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = TextInstance.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Text",
                        Type = "string",
                        Value = TextInstance.Text
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.VerticalAlignment",
                        Type = "VerticalAlignment",
                        Value = TextInstance.VerticalAlignment
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.X",
                        Type = "float",
                        Value = TextInstance.X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = TextInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.X Units",
                        Type = "PositionUnitType",
                        Value = TextInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Y",
                        Type = "float",
                        Value = TextInstance.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = TextInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = TextInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance1.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.HorizontalAlignment",
                        Type = "HorizontalAlignment",
                        Value = TextInstance1.HorizontalAlignment
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.Parent",
                        Type = "string",
                        Value = TextInstance1.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = TextInstance1.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.Text",
                        Type = "string",
                        Value = TextInstance1.Text
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.VerticalAlignment",
                        Type = "VerticalAlignment",
                        Value = TextInstance1.VerticalAlignment
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.X",
                        Type = "float",
                        Value = TextInstance1.X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.X Origin",
                        Type = "HorizontalAlignment",
                        Value = TextInstance1.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.X Units",
                        Type = "PositionUnitType",
                        Value = TextInstance1.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.Y",
                        Type = "float",
                        Value = TextInstance1.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.Y Origin",
                        Type = "VerticalAlignment",
                        Value = TextInstance1.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.Y Units",
                        Type = "PositionUnitType",
                        Value = TextInstance1.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance1.Children Layout",
                        Type = "ChildrenLayout",
                        Value = ContainerInstance1.ChildrenLayout
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance1.Height",
                        Type = "float",
                        Value = ContainerInstance1.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance1.Width",
                        Type = "float",
                        Value = ContainerInstance1.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance1.Width Units",
                        Type = "DimensionUnitType",
                        Value = ContainerInstance1.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance1.X",
                        Type = "float",
                        Value = ContainerInstance1.X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance1.X Origin",
                        Type = "HorizontalAlignment",
                        Value = ContainerInstance1.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance1.X Units",
                        Type = "PositionUnitType",
                        Value = ContainerInstance1.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance1.Y",
                        Type = "float",
                        Value = ContainerInstance1.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance1.Y Origin",
                        Type = "VerticalAlignment",
                        Value = ContainerInstance1.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance1.Y Units",
                        Type = "PositionUnitType",
                        Value = ContainerInstance1.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.Children Layout",
                        Type = "ChildrenLayout",
                        Value = InputDeviceContainerInstance.ChildrenLayout
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.Height",
                        Type = "float",
                        Value = InputDeviceContainerInstance.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = InputDeviceContainerInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.StackSpacing",
                        Type = "float",
                        Value = InputDeviceContainerInstance.StackSpacing
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.Width",
                        Type = "float",
                        Value = InputDeviceContainerInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = InputDeviceContainerInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.X",
                        Type = "float",
                        Value = InputDeviceContainerInstance.X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = InputDeviceContainerInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.X Units",
                        Type = "PositionUnitType",
                        Value = InputDeviceContainerInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.Y",
                        Type = "float",
                        Value = InputDeviceContainerInstance.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = InputDeviceContainerInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = InputDeviceContainerInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance2.Children Layout",
                        Type = "ChildrenLayout",
                        Value = ContainerInstance2.ChildrenLayout
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance2.Height",
                        Type = "float",
                        Value = ContainerInstance2.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance2.Width",
                        Type = "float",
                        Value = ContainerInstance2.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance2.Width Units",
                        Type = "DimensionUnitType",
                        Value = ContainerInstance2.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance2.X",
                        Type = "float",
                        Value = ContainerInstance2.X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance2.X Origin",
                        Type = "HorizontalAlignment",
                        Value = ContainerInstance2.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance2.X Units",
                        Type = "PositionUnitType",
                        Value = ContainerInstance2.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance2.Y",
                        Type = "float",
                        Value = ContainerInstance2.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance2.Y Origin",
                        Type = "VerticalAlignment",
                        Value = ContainerInstance2.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance2.Y Units",
                        Type = "PositionUnitType",
                        Value = ContainerInstance2.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceSelectionItemInstance.Parent",
                        Type = "string",
                        Value = InputDeviceSelectionItemInstance.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceSelectionItemInstance1.Parent",
                        Type = "string",
                        Value = InputDeviceSelectionItemInstance1.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceSelectionItemInstance2.Parent",
                        Type = "string",
                        Value = InputDeviceSelectionItemInstance2.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceSelectionItemInstance3.Parent",
                        Type = "string",
                        Value = InputDeviceSelectionItemInstance3.Parent
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (VariableState state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  VariableState.Default:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Height",
                        Type = "float",
                        Value = Height + 6f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Height Units",
                        Type = "DimensionUnitType",
                        Value = HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Width",
                        Type = "float",
                        Value = Width + 60f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Width Units",
                        Type = "DimensionUnitType",
                        Value = WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "X",
                        Type = "float",
                        Value = X + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "X Origin",
                        Type = "HorizontalAlignment",
                        Value = XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "X Units",
                        Type = "PositionUnitType",
                        Value = XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Y",
                        Type = "float",
                        Value = Y + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Y Origin",
                        Type = "VerticalAlignment",
                        Value = YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Y Units",
                        Type = "PositionUnitType",
                        Value = YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = Background.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = Background.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.HorizontalAlignment",
                        Type = "HorizontalAlignment",
                        Value = TextInstance.HorizontalAlignment
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Parent",
                        Type = "string",
                        Value = TextInstance.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = TextInstance.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Text",
                        Type = "string",
                        Value = TextInstance.Text
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.VerticalAlignment",
                        Type = "VerticalAlignment",
                        Value = TextInstance.VerticalAlignment
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.X",
                        Type = "float",
                        Value = TextInstance.X + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = TextInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.X Units",
                        Type = "PositionUnitType",
                        Value = TextInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Y",
                        Type = "float",
                        Value = TextInstance.Y + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = TextInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = TextInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance1.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.HorizontalAlignment",
                        Type = "HorizontalAlignment",
                        Value = TextInstance1.HorizontalAlignment
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.Parent",
                        Type = "string",
                        Value = TextInstance1.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = TextInstance1.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.Text",
                        Type = "string",
                        Value = TextInstance1.Text
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.VerticalAlignment",
                        Type = "VerticalAlignment",
                        Value = TextInstance1.VerticalAlignment
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.X",
                        Type = "float",
                        Value = TextInstance1.X + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.X Origin",
                        Type = "HorizontalAlignment",
                        Value = TextInstance1.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.X Units",
                        Type = "PositionUnitType",
                        Value = TextInstance1.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.Y",
                        Type = "float",
                        Value = TextInstance1.Y + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.Y Origin",
                        Type = "VerticalAlignment",
                        Value = TextInstance1.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance1.Y Units",
                        Type = "PositionUnitType",
                        Value = TextInstance1.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance1.Children Layout",
                        Type = "ChildrenLayout",
                        Value = ContainerInstance1.ChildrenLayout
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance1.Height",
                        Type = "float",
                        Value = ContainerInstance1.Height + 31f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance1.Width",
                        Type = "float",
                        Value = ContainerInstance1.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance1.Width Units",
                        Type = "DimensionUnitType",
                        Value = ContainerInstance1.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance1.X",
                        Type = "float",
                        Value = ContainerInstance1.X + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance1.X Origin",
                        Type = "HorizontalAlignment",
                        Value = ContainerInstance1.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance1.X Units",
                        Type = "PositionUnitType",
                        Value = ContainerInstance1.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance1.Y",
                        Type = "float",
                        Value = ContainerInstance1.Y + 27f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance1.Y Origin",
                        Type = "VerticalAlignment",
                        Value = ContainerInstance1.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance1.Y Units",
                        Type = "PositionUnitType",
                        Value = ContainerInstance1.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.Children Layout",
                        Type = "ChildrenLayout",
                        Value = InputDeviceContainerInstance.ChildrenLayout
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.Height",
                        Type = "float",
                        Value = InputDeviceContainerInstance.Height + 20f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = InputDeviceContainerInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.StackSpacing",
                        Type = "float",
                        Value = InputDeviceContainerInstance.StackSpacing + 4f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.Width",
                        Type = "float",
                        Value = InputDeviceContainerInstance.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = InputDeviceContainerInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.X",
                        Type = "float",
                        Value = InputDeviceContainerInstance.X + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = InputDeviceContainerInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.X Units",
                        Type = "PositionUnitType",
                        Value = InputDeviceContainerInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.Y",
                        Type = "float",
                        Value = InputDeviceContainerInstance.Y + 89f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = InputDeviceContainerInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceContainerInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = InputDeviceContainerInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance2.Children Layout",
                        Type = "ChildrenLayout",
                        Value = ContainerInstance2.ChildrenLayout
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance2.Height",
                        Type = "float",
                        Value = ContainerInstance2.Height + 31f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance2.Width",
                        Type = "float",
                        Value = ContainerInstance2.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance2.Width Units",
                        Type = "DimensionUnitType",
                        Value = ContainerInstance2.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance2.X",
                        Type = "float",
                        Value = ContainerInstance2.X + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance2.X Origin",
                        Type = "HorizontalAlignment",
                        Value = ContainerInstance2.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance2.X Units",
                        Type = "PositionUnitType",
                        Value = ContainerInstance2.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance2.Y",
                        Type = "float",
                        Value = ContainerInstance2.Y + 228f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance2.Y Origin",
                        Type = "VerticalAlignment",
                        Value = ContainerInstance2.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ContainerInstance2.Y Units",
                        Type = "PositionUnitType",
                        Value = ContainerInstance2.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceSelectionItemInstance.Parent",
                        Type = "string",
                        Value = InputDeviceSelectionItemInstance.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceSelectionItemInstance1.Parent",
                        Type = "string",
                        Value = InputDeviceSelectionItemInstance1.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceSelectionItemInstance2.Parent",
                        Type = "string",
                        Value = InputDeviceSelectionItemInstance2.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceSelectionItemInstance3.Parent",
                        Type = "string",
                        Value = InputDeviceSelectionItemInstance3.Parent
                    }
                    );
                    break;
            }
            return newState;
        }
        #endregion
        public override void ApplyState (Gum.DataTypes.Variables.StateSave state) 
        {
            bool matches = this.ElementSave.AllStates.Contains(state);
            if (matches)
            {
                var category = this.ElementSave.Categories.FirstOrDefault(item => item.States.Contains(state));
                if (category == null)
                {
                    if (state.Name == "Default") this.mCurrentVariableState = VariableState.Default;
                }
            }
            base.ApplyState(state);
        }
        private bool tryCreateFormsObject;
        public global::test_webrtc.GumRuntimes.NineSliceRuntime Background { get; set; }
        public global::test_webrtc.GumRuntimes.TextRuntime TextInstance { get; set; }
        public global::test_webrtc.GumRuntimes.TextRuntime TextInstance1 { get; set; }
        public global::test_webrtc.GumRuntimes.ContainerRuntime ContainerInstance1 { get; set; }
        public global::test_webrtc.GumRuntimes.ContainerRuntime InputDeviceContainerInstance { get; set; }
        public global::test_webrtc.GumRuntimes.ContainerRuntime ContainerInstance2 { get; set; }
        public global::test_webrtc.GumRuntimes.Controls.InputDeviceSelectionItemRuntime InputDeviceSelectionItemInstance { get; set; }
        public global::test_webrtc.GumRuntimes.Controls.InputDeviceSelectionItemRuntime InputDeviceSelectionItemInstance1 { get; set; }
        public global::test_webrtc.GumRuntimes.Controls.InputDeviceSelectionItemRuntime InputDeviceSelectionItemInstance2 { get; set; }
        public global::test_webrtc.GumRuntimes.Controls.InputDeviceSelectionItemRuntime InputDeviceSelectionItemInstance3 { get; set; }
        public event FlatRedBall.Gui.WindowEvent InputDeviceSelectionItemInstanceClick;
        public event FlatRedBall.Gui.WindowEvent InputDeviceSelectionItemInstance1Click;
        public event FlatRedBall.Gui.WindowEvent InputDeviceSelectionItemInstance2Click;
        public event FlatRedBall.Gui.WindowEvent InputDeviceSelectionItemInstance3Click;
        public InputDeviceSelectorRuntime () 
        	: this(true, true)
        {
        }
        public InputDeviceSelectorRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        	: base(false, tryCreateFormsObject)
        {
            this.tryCreateFormsObject = tryCreateFormsObject;
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Controls/InputDeviceSelector");
                this.ElementSave = elementSave;
                string oldDirectory = FlatRedBall.IO.FileManager.RelativeDirectory;
                FlatRedBall.IO.FileManager.RelativeDirectory = FlatRedBall.IO.FileManager.GetDirectory(Gum.Managers.ObjectFinder.Self.GumProjectSave.FullFileName);
                GumRuntime.ElementSaveExtensions.SetGraphicalUiElement(elementSave, this, RenderingLibrary.SystemManagers.Default);
                FlatRedBall.IO.FileManager.RelativeDirectory = oldDirectory;
            }
        }
        public override void SetInitialState () 
        {
            var wasSuppressed = this.IsLayoutSuspended;
            if(!wasSuppressed) this.SuspendLayout();
            base.SetInitialState();
            this.CurrentVariableState = VariableState.Default;
            if(!wasSuppressed) this.ResumeLayout();
            CallCustomInitialize();
        }
        public override void CreateChildrenRecursively (Gum.DataTypes.ElementSave elementSave, RenderingLibrary.ISystemManagers systemManagers) 
        {
            base.CreateChildrenRecursively(elementSave, systemManagers);
            this.AssignInternalReferences();
        }
        private void AssignInternalReferences () 
        {
            Background = this.GetGraphicalUiElementByName("Background") as global::test_webrtc.GumRuntimes.NineSliceRuntime;
            TextInstance = this.GetGraphicalUiElementByName("TextInstance") as global::test_webrtc.GumRuntimes.TextRuntime;
            TextInstance1 = this.GetGraphicalUiElementByName("TextInstance1") as global::test_webrtc.GumRuntimes.TextRuntime;
            ContainerInstance1 = this.GetGraphicalUiElementByName("ContainerInstance1") as global::test_webrtc.GumRuntimes.ContainerRuntime;
            InputDeviceContainerInstance = this.GetGraphicalUiElementByName("InputDeviceContainerInstance") as global::test_webrtc.GumRuntimes.ContainerRuntime;
            ContainerInstance2 = this.GetGraphicalUiElementByName("ContainerInstance2") as global::test_webrtc.GumRuntimes.ContainerRuntime;
            InputDeviceSelectionItemInstance = this.GetGraphicalUiElementByName("InputDeviceSelectionItemInstance") as global::test_webrtc.GumRuntimes.Controls.InputDeviceSelectionItemRuntime;
            InputDeviceSelectionItemInstance1 = this.GetGraphicalUiElementByName("InputDeviceSelectionItemInstance1") as global::test_webrtc.GumRuntimes.Controls.InputDeviceSelectionItemRuntime;
            InputDeviceSelectionItemInstance2 = this.GetGraphicalUiElementByName("InputDeviceSelectionItemInstance2") as global::test_webrtc.GumRuntimes.Controls.InputDeviceSelectionItemRuntime;
            InputDeviceSelectionItemInstance3 = this.GetGraphicalUiElementByName("InputDeviceSelectionItemInstance3") as global::test_webrtc.GumRuntimes.Controls.InputDeviceSelectionItemRuntime;
            InputDeviceSelectionItemInstance.Click += (unused) => InputDeviceSelectionItemInstanceClick?.Invoke(this);
            InputDeviceSelectionItemInstance1.Click += (unused) => InputDeviceSelectionItemInstance1Click?.Invoke(this);
            InputDeviceSelectionItemInstance2.Click += (unused) => InputDeviceSelectionItemInstance2Click?.Invoke(this);
            InputDeviceSelectionItemInstance3.Click += (unused) => InputDeviceSelectionItemInstance3Click?.Invoke(this);
            if (tryCreateFormsObject)
            {
                FormsControlAsObject = new FlatRedBall.Forms.Controls.Games.InputDeviceSelector(this);
            }
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
        public FlatRedBall.Forms.Controls.Games.InputDeviceSelector FormsControl {get => (FlatRedBall.Forms.Controls.Games.InputDeviceSelector) FormsControlAsObject;}
    }
}
