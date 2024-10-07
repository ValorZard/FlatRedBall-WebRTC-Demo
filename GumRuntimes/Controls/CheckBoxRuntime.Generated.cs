using System.Linq;
namespace test_webrtc.GumRuntimes.Controls
{
    public partial class CheckBoxRuntime : global::test_webrtc.GumRuntimes.ContainerRuntime, global::test_webrtc.GumRuntimes.ICheckBoxBehavior
    {
        #region State Enums
        public enum VariableState
        {
            Default
        }
        public enum CheckBoxCategory
        {
            EnabledOn,
            EnabledOff,
            DisabledOn,
            DisabledOff,
            HighlightedOn,
            HighlightedOff,
            PushedOn,
            PushedOff,
            FocusedOn,
            FocusedOff,
            HighlightedFocusedOn,
            HighlightedFocusedOff,
            DisabledFocusedOn,
            DisabledFocusedOff
        }
        #endregion
        #region State Fields
        VariableState mCurrentVariableState;
        CheckBoxCategory? mCurrentCheckBoxCategoryState;
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
                        Check.Parent = this.GetGraphicalUiElementByName("CheckboxBackground") ?? this;
                        CheckboxBackground.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                        CheckboxBackground.CurrentStyleCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                        TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                        TextInstance.CurrentStyleCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory.Normal;
                        Check.CurrentIconCategoryState = global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory.Check;
                        Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                        FocusedIndicator.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Warning;
                        FocusedIndicator.CurrentStyleCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
                        Height = 24f;
                        Width = 128f;
                        CheckboxBackground.Height = 24f;
                        CheckboxBackground.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        CheckboxBackground.Width = 24f;
                        CheckboxBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        CheckboxBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        CheckboxBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        TextInstance.Height = 32f;
                        TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        TextInstance.Text = "Checkbox Label";
                        TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        TextInstance.Width = -28f;
                        TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        Check.Height = 0f;
                        Check.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        Check.Width = 0f;
                        Check.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        FocusedIndicator.Height = 2f;
                        FocusedIndicator.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        FocusedIndicator.Visible = false;
                        FocusedIndicator.Y = 2f;
                        FocusedIndicator.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        FocusedIndicator.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        break;
                }
            }
        }
        public CheckBoxCategory? CurrentCheckBoxCategoryState
        {
            get
            {
                return mCurrentCheckBoxCategoryState;
            }
            set
            {
                if (value != null)
                {
                    mCurrentCheckBoxCategoryState = value;
                    switch(mCurrentCheckBoxCategoryState)
                    {
                        case  CheckBoxCategory.EnabledOn:
                            CheckboxBackground.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                            TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                            Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            Check.Visible = true;
                            FocusedIndicator.Visible = false;
                            break;
                        case  CheckBoxCategory.EnabledOff:
                            CheckboxBackground.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                            TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                            Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            Check.Visible = false;
                            FocusedIndicator.Visible = false;
                            break;
                        case  CheckBoxCategory.DisabledOn:
                            CheckboxBackground.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                            TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Gray;
                            Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                            Check.Visible = true;
                            FocusedIndicator.Visible = false;
                            break;
                        case  CheckBoxCategory.DisabledOff:
                            CheckboxBackground.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                            TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Gray;
                            Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            Check.Visible = false;
                            FocusedIndicator.Visible = false;
                            break;
                        case  CheckBoxCategory.HighlightedOn:
                            CheckboxBackground.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                            TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                            Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            Check.Visible = true;
                            FocusedIndicator.Visible = false;
                            break;
                        case  CheckBoxCategory.HighlightedOff:
                            CheckboxBackground.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                            TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                            Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            Check.Visible = false;
                            FocusedIndicator.Visible = false;
                            break;
                        case  CheckBoxCategory.PushedOn:
                            CheckboxBackground.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                            TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                            Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            Check.Visible = true;
                            FocusedIndicator.Visible = false;
                            break;
                        case  CheckBoxCategory.PushedOff:
                            CheckboxBackground.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                            TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                            Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            Check.Visible = false;
                            FocusedIndicator.Visible = false;
                            break;
                        case  CheckBoxCategory.FocusedOn:
                            CheckboxBackground.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                            TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                            Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            Check.Visible = true;
                            FocusedIndicator.Visible = true;
                            break;
                        case  CheckBoxCategory.FocusedOff:
                            CheckboxBackground.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                            TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                            Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            Check.Visible = false;
                            FocusedIndicator.Visible = true;
                            break;
                        case  CheckBoxCategory.HighlightedFocusedOn:
                            CheckboxBackground.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                            TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                            Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            Check.Visible = true;
                            FocusedIndicator.Visible = true;
                            break;
                        case  CheckBoxCategory.HighlightedFocusedOff:
                            CheckboxBackground.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                            TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                            Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            Check.Visible = false;
                            FocusedIndicator.Visible = true;
                            break;
                        case  CheckBoxCategory.DisabledFocusedOn:
                            CheckboxBackground.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                            TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Gray;
                            Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                            Check.Visible = true;
                            FocusedIndicator.Visible = true;
                            break;
                        case  CheckBoxCategory.DisabledFocusedOff:
                            CheckboxBackground.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                            TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Gray;
                            Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            Check.Visible = false;
                            FocusedIndicator.Visible = true;
                            break;
                    }
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
            bool setCheckHeightFirstValue = false;
            bool setCheckHeightSecondValue = false;
            float CheckHeightFirstValue= 0;
            float CheckHeightSecondValue= 0;
            bool setCheckCurrentIconCategoryStateFirstValue = false;
            bool setCheckCurrentIconCategoryStateSecondValue = false;
            global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory CheckCurrentIconCategoryStateFirstValue= global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory.None;
            global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory CheckCurrentIconCategoryStateSecondValue= global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory.None;
            bool setCheckWidthFirstValue = false;
            bool setCheckWidthSecondValue = false;
            float CheckWidthFirstValue= 0;
            float CheckWidthSecondValue= 0;
            bool setCheckboxBackgroundCurrentColorCategoryStateFirstValue = false;
            bool setCheckboxBackgroundCurrentColorCategoryStateSecondValue = false;
            global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory CheckboxBackgroundCurrentColorCategoryStateFirstValue= global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory CheckboxBackgroundCurrentColorCategoryStateSecondValue= global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            bool setCheckboxBackgroundHeightFirstValue = false;
            bool setCheckboxBackgroundHeightSecondValue = false;
            float CheckboxBackgroundHeightFirstValue= 0;
            float CheckboxBackgroundHeightSecondValue= 0;
            bool setCheckboxBackgroundCurrentStyleCategoryStateFirstValue = false;
            bool setCheckboxBackgroundCurrentStyleCategoryStateSecondValue = false;
            global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory CheckboxBackgroundCurrentStyleCategoryStateFirstValue= global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory CheckboxBackgroundCurrentStyleCategoryStateSecondValue= global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            bool setCheckboxBackgroundWidthFirstValue = false;
            bool setCheckboxBackgroundWidthSecondValue = false;
            float CheckboxBackgroundWidthFirstValue= 0;
            float CheckboxBackgroundWidthSecondValue= 0;
            bool setFocusedIndicatorCurrentColorCategoryStateFirstValue = false;
            bool setFocusedIndicatorCurrentColorCategoryStateSecondValue = false;
            global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory FocusedIndicatorCurrentColorCategoryStateFirstValue= global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory FocusedIndicatorCurrentColorCategoryStateSecondValue= global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            bool setFocusedIndicatorHeightFirstValue = false;
            bool setFocusedIndicatorHeightSecondValue = false;
            float FocusedIndicatorHeightFirstValue= 0;
            float FocusedIndicatorHeightSecondValue= 0;
            bool setFocusedIndicatorCurrentStyleCategoryStateFirstValue = false;
            bool setFocusedIndicatorCurrentStyleCategoryStateSecondValue = false;
            global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory FocusedIndicatorCurrentStyleCategoryStateFirstValue= global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory FocusedIndicatorCurrentStyleCategoryStateSecondValue= global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            bool setFocusedIndicatorYFirstValue = false;
            bool setFocusedIndicatorYSecondValue = false;
            float FocusedIndicatorYFirstValue= 0;
            float FocusedIndicatorYSecondValue= 0;
            bool setHeightFirstValue = false;
            bool setHeightSecondValue = false;
            float HeightFirstValue= 0;
            float HeightSecondValue= 0;
            bool setTextInstanceCurrentColorCategoryStateFirstValue = false;
            bool setTextInstanceCurrentColorCategoryStateSecondValue = false;
            global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateFirstValue= global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Black;
            global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateSecondValue= global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Black;
            bool setTextInstanceHeightFirstValue = false;
            bool setTextInstanceHeightSecondValue = false;
            float TextInstanceHeightFirstValue= 0;
            float TextInstanceHeightSecondValue= 0;
            bool setTextInstanceCurrentStyleCategoryStateFirstValue = false;
            bool setTextInstanceCurrentStyleCategoryStateSecondValue = false;
            global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory TextInstanceCurrentStyleCategoryStateFirstValue= global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory.Tiny;
            global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory TextInstanceCurrentStyleCategoryStateSecondValue= global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory.Tiny;
            bool setTextInstanceWidthFirstValue = false;
            bool setTextInstanceWidthSecondValue = false;
            float TextInstanceWidthFirstValue= 0;
            float TextInstanceWidthSecondValue= 0;
            bool setWidthFirstValue = false;
            bool setWidthSecondValue = false;
            float WidthFirstValue= 0;
            float WidthSecondValue= 0;
            switch(firstState)
            {
                case  VariableState.Default:
                    setCheckHeightFirstValue = true;
                    CheckHeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.Check.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setCheckCurrentIconCategoryStateFirstValue = true;
                    CheckCurrentIconCategoryStateFirstValue = global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory.Check;
                    if (interpolationValue < 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Check.Parent = this.GetGraphicalUiElementByName("CheckboxBackground") ?? this;
                    }
                    setCheckWidthFirstValue = true;
                    CheckWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.Check.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateFirstValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    setCheckboxBackgroundHeightFirstValue = true;
                    CheckboxBackgroundHeightFirstValue = 24f;
                    if (interpolationValue < 1)
                    {
                        this.CheckboxBackground.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setCheckboxBackgroundCurrentStyleCategoryStateFirstValue = true;
                    CheckboxBackgroundCurrentStyleCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                    setCheckboxBackgroundWidthFirstValue = true;
                    CheckboxBackgroundWidthFirstValue = 24f;
                    if (interpolationValue < 1)
                    {
                        this.CheckboxBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    if (interpolationValue < 1)
                    {
                        this.CheckboxBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.CheckboxBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setFocusedIndicatorCurrentColorCategoryStateFirstValue = true;
                    FocusedIndicatorCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Warning;
                    setFocusedIndicatorHeightFirstValue = true;
                    FocusedIndicatorHeightFirstValue = 2f;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setFocusedIndicatorCurrentStyleCategoryStateFirstValue = true;
                    FocusedIndicatorCurrentStyleCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setFocusedIndicatorYFirstValue = true;
                    FocusedIndicatorYFirstValue = 2f;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setHeightFirstValue = true;
                    HeightFirstValue = 24f;
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    setTextInstanceHeightFirstValue = true;
                    TextInstanceHeightFirstValue = 32f;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    setTextInstanceCurrentStyleCategoryStateFirstValue = true;
                    TextInstanceCurrentStyleCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory.Normal;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.Text = "Checkbox Label";
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    setTextInstanceWidthFirstValue = true;
                    TextInstanceWidthFirstValue = -28f;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setWidthFirstValue = true;
                    WidthFirstValue = 128f;
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    setCheckHeightSecondValue = true;
                    CheckHeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.Check.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setCheckCurrentIconCategoryStateSecondValue = true;
                    CheckCurrentIconCategoryStateSecondValue = global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory.Check;
                    if (interpolationValue >= 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Check.Parent = this.GetGraphicalUiElementByName("CheckboxBackground") ?? this;
                    }
                    setCheckWidthSecondValue = true;
                    CheckWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.Check.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateSecondValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    setCheckboxBackgroundHeightSecondValue = true;
                    CheckboxBackgroundHeightSecondValue = 24f;
                    if (interpolationValue >= 1)
                    {
                        this.CheckboxBackground.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setCheckboxBackgroundCurrentStyleCategoryStateSecondValue = true;
                    CheckboxBackgroundCurrentStyleCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                    setCheckboxBackgroundWidthSecondValue = true;
                    CheckboxBackgroundWidthSecondValue = 24f;
                    if (interpolationValue >= 1)
                    {
                        this.CheckboxBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.CheckboxBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.CheckboxBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setFocusedIndicatorCurrentColorCategoryStateSecondValue = true;
                    FocusedIndicatorCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Warning;
                    setFocusedIndicatorHeightSecondValue = true;
                    FocusedIndicatorHeightSecondValue = 2f;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setFocusedIndicatorCurrentStyleCategoryStateSecondValue = true;
                    FocusedIndicatorCurrentStyleCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setFocusedIndicatorYSecondValue = true;
                    FocusedIndicatorYSecondValue = 2f;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setHeightSecondValue = true;
                    HeightSecondValue = 24f;
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    setTextInstanceHeightSecondValue = true;
                    TextInstanceHeightSecondValue = 32f;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    setTextInstanceCurrentStyleCategoryStateSecondValue = true;
                    TextInstanceCurrentStyleCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory.Normal;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.Text = "Checkbox Label";
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    setTextInstanceWidthSecondValue = true;
                    TextInstanceWidthSecondValue = -28f;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setWidthSecondValue = true;
                    WidthSecondValue = 128f;
                    break;
            }
            var wasSuppressed = mIsLayoutSuspended;
            var shouldSuspend = wasSuppressed == false;
            var suspendRecursively = true;
            if (shouldSuspend)
            {
                SuspendLayout(suspendRecursively);
            }
            if (setCheckHeightFirstValue && setCheckHeightSecondValue)
            {
                Check.Height = CheckHeightFirstValue * (1 - interpolationValue) + CheckHeightSecondValue * interpolationValue;
            }
            if (setCheckCurrentIconCategoryStateFirstValue && setCheckCurrentIconCategoryStateSecondValue)
            {
                Check.InterpolateBetween(CheckCurrentIconCategoryStateFirstValue, CheckCurrentIconCategoryStateSecondValue, interpolationValue);
            }
            if (setCheckWidthFirstValue && setCheckWidthSecondValue)
            {
                Check.Width = CheckWidthFirstValue * (1 - interpolationValue) + CheckWidthSecondValue * interpolationValue;
            }
            if (setCheckboxBackgroundCurrentColorCategoryStateFirstValue && setCheckboxBackgroundCurrentColorCategoryStateSecondValue)
            {
                CheckboxBackground.InterpolateBetween(CheckboxBackgroundCurrentColorCategoryStateFirstValue, CheckboxBackgroundCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setCheckboxBackgroundHeightFirstValue && setCheckboxBackgroundHeightSecondValue)
            {
                CheckboxBackground.Height = CheckboxBackgroundHeightFirstValue * (1 - interpolationValue) + CheckboxBackgroundHeightSecondValue * interpolationValue;
            }
            if (setCheckboxBackgroundCurrentStyleCategoryStateFirstValue && setCheckboxBackgroundCurrentStyleCategoryStateSecondValue)
            {
                CheckboxBackground.InterpolateBetween(CheckboxBackgroundCurrentStyleCategoryStateFirstValue, CheckboxBackgroundCurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setCheckboxBackgroundWidthFirstValue && setCheckboxBackgroundWidthSecondValue)
            {
                CheckboxBackground.Width = CheckboxBackgroundWidthFirstValue * (1 - interpolationValue) + CheckboxBackgroundWidthSecondValue * interpolationValue;
            }
            if (setFocusedIndicatorCurrentColorCategoryStateFirstValue && setFocusedIndicatorCurrentColorCategoryStateSecondValue)
            {
                FocusedIndicator.InterpolateBetween(FocusedIndicatorCurrentColorCategoryStateFirstValue, FocusedIndicatorCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setFocusedIndicatorHeightFirstValue && setFocusedIndicatorHeightSecondValue)
            {
                FocusedIndicator.Height = FocusedIndicatorHeightFirstValue * (1 - interpolationValue) + FocusedIndicatorHeightSecondValue * interpolationValue;
            }
            if (setFocusedIndicatorCurrentStyleCategoryStateFirstValue && setFocusedIndicatorCurrentStyleCategoryStateSecondValue)
            {
                FocusedIndicator.InterpolateBetween(FocusedIndicatorCurrentStyleCategoryStateFirstValue, FocusedIndicatorCurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setFocusedIndicatorYFirstValue && setFocusedIndicatorYSecondValue)
            {
                FocusedIndicator.Y = FocusedIndicatorYFirstValue * (1 - interpolationValue) + FocusedIndicatorYSecondValue * interpolationValue;
            }
            if (setHeightFirstValue && setHeightSecondValue)
            {
                Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
            }
            if (setTextInstanceCurrentColorCategoryStateFirstValue && setTextInstanceCurrentColorCategoryStateSecondValue)
            {
                TextInstance.InterpolateBetween(TextInstanceCurrentColorCategoryStateFirstValue, TextInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setTextInstanceHeightFirstValue && setTextInstanceHeightSecondValue)
            {
                TextInstance.Height = TextInstanceHeightFirstValue * (1 - interpolationValue) + TextInstanceHeightSecondValue * interpolationValue;
            }
            if (setTextInstanceCurrentStyleCategoryStateFirstValue && setTextInstanceCurrentStyleCategoryStateSecondValue)
            {
                TextInstance.InterpolateBetween(TextInstanceCurrentStyleCategoryStateFirstValue, TextInstanceCurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setTextInstanceWidthFirstValue && setTextInstanceWidthSecondValue)
            {
                TextInstance.Width = TextInstanceWidthFirstValue * (1 - interpolationValue) + TextInstanceWidthSecondValue * interpolationValue;
            }
            if (setWidthFirstValue && setWidthSecondValue)
            {
                Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
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
        public void InterpolateBetween (CheckBoxCategory firstState, CheckBoxCategory secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            bool setCheckboxBackgroundCurrentColorCategoryStateFirstValue = false;
            bool setCheckboxBackgroundCurrentColorCategoryStateSecondValue = false;
            global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory CheckboxBackgroundCurrentColorCategoryStateFirstValue= global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory CheckboxBackgroundCurrentColorCategoryStateSecondValue= global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            bool setTextInstanceCurrentColorCategoryStateFirstValue = false;
            bool setTextInstanceCurrentColorCategoryStateSecondValue = false;
            global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateFirstValue= global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Black;
            global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateSecondValue= global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Black;
            switch(firstState)
            {
                case  CheckBoxCategory.EnabledOn:
                    if (interpolationValue < 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Check.Visible = true;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateFirstValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  CheckBoxCategory.EnabledOff:
                    if (interpolationValue < 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Check.Visible = false;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateFirstValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  CheckBoxCategory.DisabledOn:
                    if (interpolationValue < 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Check.Visible = true;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateFirstValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
                case  CheckBoxCategory.DisabledOff:
                    if (interpolationValue < 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Check.Visible = false;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateFirstValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
                case  CheckBoxCategory.HighlightedOn:
                    if (interpolationValue < 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Check.Visible = true;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateFirstValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  CheckBoxCategory.HighlightedOff:
                    if (interpolationValue < 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Check.Visible = false;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateFirstValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  CheckBoxCategory.PushedOn:
                    if (interpolationValue < 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Check.Visible = true;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateFirstValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  CheckBoxCategory.PushedOff:
                    if (interpolationValue < 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Check.Visible = false;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateFirstValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  CheckBoxCategory.FocusedOn:
                    if (interpolationValue < 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Check.Visible = true;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateFirstValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  CheckBoxCategory.FocusedOff:
                    if (interpolationValue < 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Check.Visible = false;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateFirstValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  CheckBoxCategory.HighlightedFocusedOn:
                    if (interpolationValue < 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Check.Visible = true;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateFirstValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  CheckBoxCategory.HighlightedFocusedOff:
                    if (interpolationValue < 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Check.Visible = false;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateFirstValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  CheckBoxCategory.DisabledFocusedOn:
                    if (interpolationValue < 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Check.Visible = true;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateFirstValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
                case  CheckBoxCategory.DisabledFocusedOff:
                    if (interpolationValue < 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Check.Visible = false;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateFirstValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
            }
            switch(secondState)
            {
                case  CheckBoxCategory.EnabledOn:
                    if (interpolationValue >= 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Check.Visible = true;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateSecondValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  CheckBoxCategory.EnabledOff:
                    if (interpolationValue >= 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Check.Visible = false;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateSecondValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  CheckBoxCategory.DisabledOn:
                    if (interpolationValue >= 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Check.Visible = true;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateSecondValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
                case  CheckBoxCategory.DisabledOff:
                    if (interpolationValue >= 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Check.Visible = false;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateSecondValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
                case  CheckBoxCategory.HighlightedOn:
                    if (interpolationValue >= 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Check.Visible = true;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateSecondValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  CheckBoxCategory.HighlightedOff:
                    if (interpolationValue >= 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Check.Visible = false;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateSecondValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  CheckBoxCategory.PushedOn:
                    if (interpolationValue >= 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Check.Visible = true;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateSecondValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  CheckBoxCategory.PushedOff:
                    if (interpolationValue >= 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Check.Visible = false;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateSecondValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  CheckBoxCategory.FocusedOn:
                    if (interpolationValue >= 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Check.Visible = true;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateSecondValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  CheckBoxCategory.FocusedOff:
                    if (interpolationValue >= 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Check.Visible = false;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateSecondValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  CheckBoxCategory.HighlightedFocusedOn:
                    if (interpolationValue >= 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Check.Visible = true;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateSecondValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  CheckBoxCategory.HighlightedFocusedOff:
                    if (interpolationValue >= 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Check.Visible = false;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateSecondValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  CheckBoxCategory.DisabledFocusedOn:
                    if (interpolationValue >= 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Check.Visible = true;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateSecondValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
                case  CheckBoxCategory.DisabledFocusedOff:
                    if (interpolationValue >= 1)
                    {
                        this.Check.IconColor = global::test_webrtc.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Check.Visible = false;
                    }
                    setCheckboxBackgroundCurrentColorCategoryStateSecondValue = true;
                    CheckboxBackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
            }
            var wasSuppressed = mIsLayoutSuspended;
            var shouldSuspend = wasSuppressed == false;
            var suspendRecursively = true;
            if (shouldSuspend)
            {
                SuspendLayout(suspendRecursively);
            }
            if (setCheckboxBackgroundCurrentColorCategoryStateFirstValue && setCheckboxBackgroundCurrentColorCategoryStateSecondValue)
            {
                CheckboxBackground.InterpolateBetween(CheckboxBackgroundCurrentColorCategoryStateFirstValue, CheckboxBackgroundCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setTextInstanceCurrentColorCategoryStateFirstValue && setTextInstanceCurrentColorCategoryStateSecondValue)
            {
                TextInstance.InterpolateBetween(TextInstanceCurrentColorCategoryStateFirstValue, TextInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (interpolationValue < 1)
            {
                mCurrentCheckBoxCategoryState = firstState;
            }
            else
            {
                mCurrentCheckBoxCategoryState = secondState;
            }
            if (shouldSuspend)
            {
                ResumeLayout(suspendRecursively);
            }
        }
        #endregion
        #region State Interpolate To
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (global::test_webrtc.GumRuntimes.Controls.CheckBoxRuntime.VariableState fromState,global::test_webrtc.GumRuntimes.Controls.CheckBoxRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (global::test_webrtc.GumRuntimes.Controls.CheckBoxRuntime.CheckBoxCategory fromState,global::test_webrtc.GumRuntimes.Controls.CheckBoxRuntime.CheckBoxCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (CheckBoxCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "CheckBoxCategory").States.First(item => item.Name == toState.ToString());
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
            tweener.Ended += ()=> this.CurrentCheckBoxCategoryState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (CheckBoxCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
            tweener.Ended += ()=> this.CurrentCheckBoxCategoryState = toState;
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
            Check.StopAnimations();
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
                        Name = "Width",
                        Type = "float",
                        Value = Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.Height",
                        Type = "float",
                        Value = CheckboxBackground.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.Height Units",
                        Type = "DimensionUnitType",
                        Value = CheckboxBackground.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = CheckboxBackground.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.Width",
                        Type = "float",
                        Value = CheckboxBackground.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.Width Units",
                        Type = "DimensionUnitType",
                        Value = CheckboxBackground.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.X Origin",
                        Type = "HorizontalAlignment",
                        Value = CheckboxBackground.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.X Units",
                        Type = "PositionUnitType",
                        Value = CheckboxBackground.XUnits
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
                        Name = "TextInstance.Height",
                        Type = "float",
                        Value = TextInstance.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = TextInstance.HeightUnits
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
                        Name = "TextInstance.Width",
                        Type = "float",
                        Value = TextInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = TextInstance.WidthUnits
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
                        Name = "Check.Height",
                        Type = "float",
                        Value = Check.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Height Units",
                        Type = "DimensionUnitType",
                        Value = Check.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.IconCategoryState",
                        Type = "IconCategory",
                        Value = Check.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Parent",
                        Type = "string",
                        Value = Check.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Width",
                        Type = "float",
                        Value = Check.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Width Units",
                        Type = "DimensionUnitType",
                        Value = Check.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = FocusedIndicator.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Height",
                        Type = "float",
                        Value = FocusedIndicator.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Height Units",
                        Type = "DimensionUnitType",
                        Value = FocusedIndicator.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = FocusedIndicator.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Y",
                        Type = "float",
                        Value = FocusedIndicator.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Y Origin",
                        Type = "VerticalAlignment",
                        Value = FocusedIndicator.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Y Units",
                        Type = "PositionUnitType",
                        Value = FocusedIndicator.YUnits
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
                        Value = Height + 24f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Width",
                        Type = "float",
                        Value = Width + 128f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.Height",
                        Type = "float",
                        Value = CheckboxBackground.Height + 24f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.Height Units",
                        Type = "DimensionUnitType",
                        Value = CheckboxBackground.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = CheckboxBackground.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.Width",
                        Type = "float",
                        Value = CheckboxBackground.Width + 24f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.Width Units",
                        Type = "DimensionUnitType",
                        Value = CheckboxBackground.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.X Origin",
                        Type = "HorizontalAlignment",
                        Value = CheckboxBackground.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.X Units",
                        Type = "PositionUnitType",
                        Value = CheckboxBackground.XUnits
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
                        Name = "TextInstance.Height",
                        Type = "float",
                        Value = TextInstance.Height + 32f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = TextInstance.HeightUnits
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
                        Name = "TextInstance.Width",
                        Type = "float",
                        Value = TextInstance.Width + -28f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = TextInstance.WidthUnits
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
                        Name = "Check.Height",
                        Type = "float",
                        Value = Check.Height + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Height Units",
                        Type = "DimensionUnitType",
                        Value = Check.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.IconCategoryState",
                        Type = "IconCategory",
                        Value = Check.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Parent",
                        Type = "string",
                        Value = Check.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Width",
                        Type = "float",
                        Value = Check.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Width Units",
                        Type = "DimensionUnitType",
                        Value = Check.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = FocusedIndicator.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Height",
                        Type = "float",
                        Value = FocusedIndicator.Height + 2f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Height Units",
                        Type = "DimensionUnitType",
                        Value = FocusedIndicator.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = FocusedIndicator.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Y",
                        Type = "float",
                        Value = FocusedIndicator.Y + 2f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Y Origin",
                        Type = "VerticalAlignment",
                        Value = FocusedIndicator.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Y Units",
                        Type = "PositionUnitType",
                        Value = FocusedIndicator.YUnits
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (CheckBoxCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  CheckBoxCategory.EnabledOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.EnabledOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.DisabledOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.DisabledOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.HighlightedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.HighlightedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.PushedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.PushedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.FocusedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.FocusedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.HighlightedFocusedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.HighlightedFocusedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.DisabledFocusedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.DisabledFocusedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (CheckBoxCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  CheckBoxCategory.EnabledOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.EnabledOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.DisabledOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.DisabledOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.HighlightedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.HighlightedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.PushedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.PushedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.FocusedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.FocusedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.HighlightedFocusedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.HighlightedFocusedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.DisabledFocusedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  CheckBoxCategory.DisabledFocusedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CheckboxBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CheckboxBackground.CurrentColorCategoryState
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
                        Name = "Check.IconColor",
                        Type = "ColorCategory",
                        Value = Check.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Check.Visible",
                        Type = "bool",
                        Value = Check.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
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
                else if (category.Name == "CheckBoxCategory")
                {
                    if(state.Name == "EnabledOn") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.EnabledOn;
                    if(state.Name == "EnabledOff") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.EnabledOff;
                    if(state.Name == "DisabledOn") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.DisabledOn;
                    if(state.Name == "DisabledOff") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.DisabledOff;
                    if(state.Name == "HighlightedOn") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.HighlightedOn;
                    if(state.Name == "HighlightedOff") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.HighlightedOff;
                    if(state.Name == "PushedOn") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.PushedOn;
                    if(state.Name == "PushedOff") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.PushedOff;
                    if(state.Name == "FocusedOn") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.FocusedOn;
                    if(state.Name == "FocusedOff") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.FocusedOff;
                    if(state.Name == "HighlightedFocusedOn") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.HighlightedFocusedOn;
                    if(state.Name == "HighlightedFocusedOff") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.HighlightedFocusedOff;
                    if(state.Name == "DisabledFocusedOn") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.DisabledFocusedOn;
                    if(state.Name == "DisabledFocusedOff") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.DisabledFocusedOff;
                }
            }
            base.ApplyState(state);
        }
        global::test_webrtc.GumRuntimes.ICheckBoxBehavior.CheckBoxCategory global::test_webrtc.GumRuntimes.ICheckBoxBehavior.CurrentCheckBoxCategoryState
        {
            set
            {
                switch(value)
                {
                    case  global::test_webrtc.GumRuntimes.ICheckBoxBehavior.CheckBoxCategory.EnabledOn:
                        this.CurrentCheckBoxCategoryState = CheckBoxCategory.EnabledOn;
                        break;
                    case  global::test_webrtc.GumRuntimes.ICheckBoxBehavior.CheckBoxCategory.EnabledOff:
                        this.CurrentCheckBoxCategoryState = CheckBoxCategory.EnabledOff;
                        break;
                    case  global::test_webrtc.GumRuntimes.ICheckBoxBehavior.CheckBoxCategory.DisabledOn:
                        this.CurrentCheckBoxCategoryState = CheckBoxCategory.DisabledOn;
                        break;
                    case  global::test_webrtc.GumRuntimes.ICheckBoxBehavior.CheckBoxCategory.DisabledOff:
                        this.CurrentCheckBoxCategoryState = CheckBoxCategory.DisabledOff;
                        break;
                    case  global::test_webrtc.GumRuntimes.ICheckBoxBehavior.CheckBoxCategory.HighlightedOn:
                        this.CurrentCheckBoxCategoryState = CheckBoxCategory.HighlightedOn;
                        break;
                    case  global::test_webrtc.GumRuntimes.ICheckBoxBehavior.CheckBoxCategory.HighlightedOff:
                        this.CurrentCheckBoxCategoryState = CheckBoxCategory.HighlightedOff;
                        break;
                    case  global::test_webrtc.GumRuntimes.ICheckBoxBehavior.CheckBoxCategory.PushedOn:
                        this.CurrentCheckBoxCategoryState = CheckBoxCategory.PushedOn;
                        break;
                    case  global::test_webrtc.GumRuntimes.ICheckBoxBehavior.CheckBoxCategory.PushedOff:
                        this.CurrentCheckBoxCategoryState = CheckBoxCategory.PushedOff;
                        break;
                    case  global::test_webrtc.GumRuntimes.ICheckBoxBehavior.CheckBoxCategory.FocusedOn:
                        this.CurrentCheckBoxCategoryState = CheckBoxCategory.FocusedOn;
                        break;
                    case  global::test_webrtc.GumRuntimes.ICheckBoxBehavior.CheckBoxCategory.FocusedOff:
                        this.CurrentCheckBoxCategoryState = CheckBoxCategory.FocusedOff;
                        break;
                    case  global::test_webrtc.GumRuntimes.ICheckBoxBehavior.CheckBoxCategory.HighlightedFocusedOn:
                        this.CurrentCheckBoxCategoryState = CheckBoxCategory.HighlightedFocusedOn;
                        break;
                    case  global::test_webrtc.GumRuntimes.ICheckBoxBehavior.CheckBoxCategory.HighlightedFocusedOff:
                        this.CurrentCheckBoxCategoryState = CheckBoxCategory.HighlightedFocusedOff;
                        break;
                    case  global::test_webrtc.GumRuntimes.ICheckBoxBehavior.CheckBoxCategory.DisabledFocusedOn:
                        this.CurrentCheckBoxCategoryState = CheckBoxCategory.DisabledFocusedOn;
                        break;
                    case  global::test_webrtc.GumRuntimes.ICheckBoxBehavior.CheckBoxCategory.DisabledFocusedOff:
                        this.CurrentCheckBoxCategoryState = CheckBoxCategory.DisabledFocusedOff;
                        break;
                }
            }
        }
        private bool tryCreateFormsObject;
        public global::test_webrtc.GumRuntimes.NineSliceRuntime CheckboxBackground { get; set; }
        public global::test_webrtc.GumRuntimes.TextRuntime TextInstance { get; set; }
        public global::test_webrtc.GumRuntimes.Elements.IconRuntime Check { get; set; }
        public global::test_webrtc.GumRuntimes.NineSliceRuntime FocusedIndicator { get; set; }
        public string CheckboxDisplayText
        {
            get
            {
                return TextInstance.Text;
            }
            set
            {
                if (TextInstance.Text != value)
                {
                    TextInstance.Text = value;
                    CheckboxDisplayTextChanged?.Invoke(this, null);
                }
            }
        }
        public event FlatRedBall.Gui.WindowEvent CheckClick;
        public event System.EventHandler CheckboxDisplayTextChanged;
        public CheckBoxRuntime () 
        	: this(true, true)
        {
        }
        public CheckBoxRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        	: base(false, tryCreateFormsObject)
        {
            this.tryCreateFormsObject = tryCreateFormsObject;
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Controls/CheckBox");
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
            CheckboxBackground = this.GetGraphicalUiElementByName("CheckboxBackground") as global::test_webrtc.GumRuntimes.NineSliceRuntime;
            TextInstance = this.GetGraphicalUiElementByName("TextInstance") as global::test_webrtc.GumRuntimes.TextRuntime;
            Check = this.GetGraphicalUiElementByName("Check") as global::test_webrtc.GumRuntimes.Elements.IconRuntime;
            FocusedIndicator = this.GetGraphicalUiElementByName("FocusedIndicator") as global::test_webrtc.GumRuntimes.NineSliceRuntime;
            Check.Click += (unused) => CheckClick?.Invoke(this);
            if (tryCreateFormsObject)
            {
                FormsControlAsObject = new FlatRedBall.Forms.Controls.CheckBox(this);
            }
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
        public FlatRedBall.Forms.Controls.CheckBox FormsControl {get => (FlatRedBall.Forms.Controls.CheckBox) FormsControlAsObject;}
    }
}
