using System.Linq;
namespace test_webrtc.GumRuntimes.Controls
{
    public partial class KeyboardKeyRuntime : global::test_webrtc.GumRuntimes.ContainerRuntime, global::test_webrtc.GumRuntimes.IButtonBehavior
    {
        #region State Enums
        public enum VariableState
        {
            Default
        }
        public enum ButtonCategory
        {
            Enabled,
            Disabled,
            Highlighted,
            Pushed,
            Focused,
            HighlightedFocused,
            DisabledFocused
        }
        #endregion
        #region State Fields
        VariableState mCurrentVariableState;
        ButtonCategory? mCurrentButtonCategoryState;
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
                        Background.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                        Background.CurrentStyleCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                        TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                        TextInstance.CurrentStyleCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory.Normal;
                        FocusedIndicator.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Warning;
                        FocusedIndicator.CurrentStyleCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
                        ExposeChildrenEvents = false;
                        Height = 20f;
                        Width = 20f;
                        Background.Height = -2f;
                        Background.Width = -2f;
                        TextInstance.Height = 0f;
                        TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        TextInstance.Text = "A";
                        TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        TextInstance.Width = 0f;
                        TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        TextInstance.X = 0f;
                        TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        TextInstance.Y = 0f;
                        TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        FocusedIndicator.Height = 2f;
                        FocusedIndicator.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        FocusedIndicator.Visible = false;
                        FocusedIndicator.Width = -4f;
                        FocusedIndicator.Y = -4f;
                        FocusedIndicator.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        FocusedIndicator.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        break;
                }
            }
        }
        public ButtonCategory? CurrentButtonCategoryState
        {
            get
            {
                return mCurrentButtonCategoryState;
            }
            set
            {
                if (value != null)
                {
                    mCurrentButtonCategoryState = value;
                    switch(mCurrentButtonCategoryState)
                    {
                        case  ButtonCategory.Enabled:
                            Background.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                            TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                            FocusedIndicator.Visible = false;
                            break;
                        case  ButtonCategory.Disabled:
                            Background.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                            TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Gray;
                            FocusedIndicator.Visible = false;
                            break;
                        case  ButtonCategory.Highlighted:
                            Background.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                            TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                            FocusedIndicator.Visible = false;
                            break;
                        case  ButtonCategory.Pushed:
                            Background.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryDark;
                            TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                            FocusedIndicator.Visible = false;
                            break;
                        case  ButtonCategory.Focused:
                            Background.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                            TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                            FocusedIndicator.Visible = true;
                            break;
                        case  ButtonCategory.HighlightedFocused:
                            Background.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                            TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                            FocusedIndicator.Visible = true;
                            break;
                        case  ButtonCategory.DisabledFocused:
                            Background.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                            TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Gray;
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
            bool setBackgroundCurrentColorCategoryStateFirstValue = false;
            bool setBackgroundCurrentColorCategoryStateSecondValue = false;
            global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory BackgroundCurrentColorCategoryStateFirstValue= global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory BackgroundCurrentColorCategoryStateSecondValue= global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            bool setBackgroundHeightFirstValue = false;
            bool setBackgroundHeightSecondValue = false;
            float BackgroundHeightFirstValue= 0;
            float BackgroundHeightSecondValue= 0;
            bool setBackgroundCurrentStyleCategoryStateFirstValue = false;
            bool setBackgroundCurrentStyleCategoryStateSecondValue = false;
            global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory BackgroundCurrentStyleCategoryStateFirstValue= global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory BackgroundCurrentStyleCategoryStateSecondValue= global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            bool setBackgroundWidthFirstValue = false;
            bool setBackgroundWidthSecondValue = false;
            float BackgroundWidthFirstValue= 0;
            float BackgroundWidthSecondValue= 0;
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
            bool setFocusedIndicatorWidthFirstValue = false;
            bool setFocusedIndicatorWidthSecondValue = false;
            float FocusedIndicatorWidthFirstValue= 0;
            float FocusedIndicatorWidthSecondValue= 0;
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
            bool setTextInstanceXFirstValue = false;
            bool setTextInstanceXSecondValue = false;
            float TextInstanceXFirstValue= 0;
            float TextInstanceXSecondValue= 0;
            bool setTextInstanceYFirstValue = false;
            bool setTextInstanceYSecondValue = false;
            float TextInstanceYFirstValue= 0;
            float TextInstanceYSecondValue= 0;
            bool setWidthFirstValue = false;
            bool setWidthSecondValue = false;
            float WidthFirstValue= 0;
            float WidthSecondValue= 0;
            switch(firstState)
            {
                case  VariableState.Default:
                    setBackgroundCurrentColorCategoryStateFirstValue = true;
                    BackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    setBackgroundHeightFirstValue = true;
                    BackgroundHeightFirstValue = -2f;
                    setBackgroundCurrentStyleCategoryStateFirstValue = true;
                    BackgroundCurrentStyleCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                    setBackgroundWidthFirstValue = true;
                    BackgroundWidthFirstValue = -2f;
                    if (interpolationValue < 1)
                    {
                        this.ExposeChildrenEvents = false;
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
                    setFocusedIndicatorWidthFirstValue = true;
                    FocusedIndicatorWidthFirstValue = -4f;
                    setFocusedIndicatorYFirstValue = true;
                    FocusedIndicatorYFirstValue = -4f;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setHeightFirstValue = true;
                    HeightFirstValue = 20f;
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    setTextInstanceHeightFirstValue = true;
                    TextInstanceHeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    setTextInstanceCurrentStyleCategoryStateFirstValue = true;
                    TextInstanceCurrentStyleCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory.Normal;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.Text = "A";
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    setTextInstanceWidthFirstValue = true;
                    TextInstanceWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setTextInstanceXFirstValue = true;
                    TextInstanceXFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                    setWidthFirstValue = true;
                    WidthFirstValue = 20f;
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    setBackgroundCurrentColorCategoryStateSecondValue = true;
                    BackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    setBackgroundHeightSecondValue = true;
                    BackgroundHeightSecondValue = -2f;
                    setBackgroundCurrentStyleCategoryStateSecondValue = true;
                    BackgroundCurrentStyleCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                    setBackgroundWidthSecondValue = true;
                    BackgroundWidthSecondValue = -2f;
                    if (interpolationValue >= 1)
                    {
                        this.ExposeChildrenEvents = false;
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
                    setFocusedIndicatorWidthSecondValue = true;
                    FocusedIndicatorWidthSecondValue = -4f;
                    setFocusedIndicatorYSecondValue = true;
                    FocusedIndicatorYSecondValue = -4f;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setHeightSecondValue = true;
                    HeightSecondValue = 20f;
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    setTextInstanceHeightSecondValue = true;
                    TextInstanceHeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    setTextInstanceCurrentStyleCategoryStateSecondValue = true;
                    TextInstanceCurrentStyleCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory.Normal;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.Text = "A";
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    setTextInstanceWidthSecondValue = true;
                    TextInstanceWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setTextInstanceXSecondValue = true;
                    TextInstanceXSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                    setWidthSecondValue = true;
                    WidthSecondValue = 20f;
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
            if (setBackgroundHeightFirstValue && setBackgroundHeightSecondValue)
            {
                Background.Height = BackgroundHeightFirstValue * (1 - interpolationValue) + BackgroundHeightSecondValue * interpolationValue;
            }
            if (setBackgroundCurrentStyleCategoryStateFirstValue && setBackgroundCurrentStyleCategoryStateSecondValue)
            {
                Background.InterpolateBetween(BackgroundCurrentStyleCategoryStateFirstValue, BackgroundCurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setBackgroundWidthFirstValue && setBackgroundWidthSecondValue)
            {
                Background.Width = BackgroundWidthFirstValue * (1 - interpolationValue) + BackgroundWidthSecondValue * interpolationValue;
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
            if (setFocusedIndicatorWidthFirstValue && setFocusedIndicatorWidthSecondValue)
            {
                FocusedIndicator.Width = FocusedIndicatorWidthFirstValue * (1 - interpolationValue) + FocusedIndicatorWidthSecondValue * interpolationValue;
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
            if (setTextInstanceXFirstValue && setTextInstanceXSecondValue)
            {
                TextInstance.X = TextInstanceXFirstValue * (1 - interpolationValue) + TextInstanceXSecondValue * interpolationValue;
            }
            if (setTextInstanceYFirstValue && setTextInstanceYSecondValue)
            {
                TextInstance.Y = TextInstanceYFirstValue * (1 - interpolationValue) + TextInstanceYSecondValue * interpolationValue;
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
        public void InterpolateBetween (ButtonCategory firstState, ButtonCategory secondState, float interpolationValue) 
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
            bool setTextInstanceCurrentColorCategoryStateFirstValue = false;
            bool setTextInstanceCurrentColorCategoryStateSecondValue = false;
            global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateFirstValue= global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Black;
            global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateSecondValue= global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Black;
            switch(firstState)
            {
                case  ButtonCategory.Enabled:
                    setBackgroundCurrentColorCategoryStateFirstValue = true;
                    BackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  ButtonCategory.Disabled:
                    setBackgroundCurrentColorCategoryStateFirstValue = true;
                    BackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
                case  ButtonCategory.Highlighted:
                    setBackgroundCurrentColorCategoryStateFirstValue = true;
                    BackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  ButtonCategory.Pushed:
                    setBackgroundCurrentColorCategoryStateFirstValue = true;
                    BackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryDark;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  ButtonCategory.Focused:
                    setBackgroundCurrentColorCategoryStateFirstValue = true;
                    BackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  ButtonCategory.HighlightedFocused:
                    setBackgroundCurrentColorCategoryStateFirstValue = true;
                    BackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  ButtonCategory.DisabledFocused:
                    setBackgroundCurrentColorCategoryStateFirstValue = true;
                    BackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
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
                case  ButtonCategory.Enabled:
                    setBackgroundCurrentColorCategoryStateSecondValue = true;
                    BackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  ButtonCategory.Disabled:
                    setBackgroundCurrentColorCategoryStateSecondValue = true;
                    BackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
                case  ButtonCategory.Highlighted:
                    setBackgroundCurrentColorCategoryStateSecondValue = true;
                    BackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  ButtonCategory.Pushed:
                    setBackgroundCurrentColorCategoryStateSecondValue = true;
                    BackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryDark;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  ButtonCategory.Focused:
                    setBackgroundCurrentColorCategoryStateSecondValue = true;
                    BackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  ButtonCategory.HighlightedFocused:
                    setBackgroundCurrentColorCategoryStateSecondValue = true;
                    BackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  ButtonCategory.DisabledFocused:
                    setBackgroundCurrentColorCategoryStateSecondValue = true;
                    BackgroundCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
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
            if (setBackgroundCurrentColorCategoryStateFirstValue && setBackgroundCurrentColorCategoryStateSecondValue)
            {
                Background.InterpolateBetween(BackgroundCurrentColorCategoryStateFirstValue, BackgroundCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setTextInstanceCurrentColorCategoryStateFirstValue && setTextInstanceCurrentColorCategoryStateSecondValue)
            {
                TextInstance.InterpolateBetween(TextInstanceCurrentColorCategoryStateFirstValue, TextInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (interpolationValue < 1)
            {
                mCurrentButtonCategoryState = firstState;
            }
            else
            {
                mCurrentButtonCategoryState = secondState;
            }
            if (shouldSuspend)
            {
                ResumeLayout(suspendRecursively);
            }
        }
        #endregion
        #region State Interpolate To
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (global::test_webrtc.GumRuntimes.Controls.KeyboardKeyRuntime.VariableState fromState,global::test_webrtc.GumRuntimes.Controls.KeyboardKeyRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (global::test_webrtc.GumRuntimes.Controls.KeyboardKeyRuntime.ButtonCategory fromState,global::test_webrtc.GumRuntimes.Controls.KeyboardKeyRuntime.ButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (ButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "ButtonCategory").States.First(item => item.Name == toState.ToString());
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
            tweener.Ended += ()=> this.CurrentButtonCategoryState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (ButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
            tweener.Ended += ()=> this.CurrentButtonCategoryState = toState;
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
                        Name = "ExposeChildrenEvents",
                        Type = "bool",
                        Value = ExposeChildrenEvents
                    }
                    );
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
                        Name = "Background.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = Background.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Height",
                        Type = "float",
                        Value = Background.Height
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
                        Name = "Background.Width",
                        Type = "float",
                        Value = Background.Width
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
                        Name = "FocusedIndicator.Width",
                        Type = "float",
                        Value = FocusedIndicator.Width
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
                        Name = "ExposeChildrenEvents",
                        Type = "bool",
                        Value = ExposeChildrenEvents
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Height",
                        Type = "float",
                        Value = Height + 20f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Width",
                        Type = "float",
                        Value = Width + 20f
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
                        Name = "Background.Height",
                        Type = "float",
                        Value = Background.Height + -2f
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
                        Name = "Background.Width",
                        Type = "float",
                        Value = Background.Width + -2f
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
                        Value = TextInstance.Height + 0f
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
                        Value = TextInstance.Width + 0f
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
                        Name = "FocusedIndicator.Width",
                        Type = "float",
                        Value = FocusedIndicator.Width + -4f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Y",
                        Type = "float",
                        Value = FocusedIndicator.Y + -4f
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
        private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (ButtonCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  ButtonCategory.Enabled:
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
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  ButtonCategory.Disabled:
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
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  ButtonCategory.Highlighted:
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
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  ButtonCategory.Pushed:
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
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  ButtonCategory.Focused:
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
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  ButtonCategory.HighlightedFocused:
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
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  ButtonCategory.DisabledFocused:
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
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
        private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (ButtonCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  ButtonCategory.Enabled:
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
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  ButtonCategory.Disabled:
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
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  ButtonCategory.Highlighted:
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
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  ButtonCategory.Pushed:
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
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  ButtonCategory.Focused:
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
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  ButtonCategory.HighlightedFocused:
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
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  ButtonCategory.DisabledFocused:
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
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                else if (category.Name == "ButtonCategory")
                {
                    if(state.Name == "Enabled") this.mCurrentButtonCategoryState = ButtonCategory.Enabled;
                    if(state.Name == "Disabled") this.mCurrentButtonCategoryState = ButtonCategory.Disabled;
                    if(state.Name == "Highlighted") this.mCurrentButtonCategoryState = ButtonCategory.Highlighted;
                    if(state.Name == "Pushed") this.mCurrentButtonCategoryState = ButtonCategory.Pushed;
                    if(state.Name == "Focused") this.mCurrentButtonCategoryState = ButtonCategory.Focused;
                    if(state.Name == "HighlightedFocused") this.mCurrentButtonCategoryState = ButtonCategory.HighlightedFocused;
                    if(state.Name == "DisabledFocused") this.mCurrentButtonCategoryState = ButtonCategory.DisabledFocused;
                }
            }
            base.ApplyState(state);
        }
        global::test_webrtc.GumRuntimes.IButtonBehavior.ButtonCategory global::test_webrtc.GumRuntimes.IButtonBehavior.CurrentButtonCategoryState
        {
            set
            {
                switch(value)
                {
                    case  global::test_webrtc.GumRuntimes.IButtonBehavior.ButtonCategory.Enabled:
                        this.CurrentButtonCategoryState = ButtonCategory.Enabled;
                        break;
                    case  global::test_webrtc.GumRuntimes.IButtonBehavior.ButtonCategory.Disabled:
                        this.CurrentButtonCategoryState = ButtonCategory.Disabled;
                        break;
                    case  global::test_webrtc.GumRuntimes.IButtonBehavior.ButtonCategory.Highlighted:
                        this.CurrentButtonCategoryState = ButtonCategory.Highlighted;
                        break;
                    case  global::test_webrtc.GumRuntimes.IButtonBehavior.ButtonCategory.Pushed:
                        this.CurrentButtonCategoryState = ButtonCategory.Pushed;
                        break;
                    case  global::test_webrtc.GumRuntimes.IButtonBehavior.ButtonCategory.HighlightedFocused:
                        this.CurrentButtonCategoryState = ButtonCategory.HighlightedFocused;
                        break;
                    case  global::test_webrtc.GumRuntimes.IButtonBehavior.ButtonCategory.Focused:
                        this.CurrentButtonCategoryState = ButtonCategory.Focused;
                        break;
                    case  global::test_webrtc.GumRuntimes.IButtonBehavior.ButtonCategory.DisabledFocused:
                        this.CurrentButtonCategoryState = ButtonCategory.DisabledFocused;
                        break;
                }
            }
        }
        private bool tryCreateFormsObject;
        public global::test_webrtc.GumRuntimes.NineSliceRuntime Background { get; set; }
        public global::test_webrtc.GumRuntimes.TextRuntime TextInstance { get; set; }
        public global::test_webrtc.GumRuntimes.NineSliceRuntime FocusedIndicator { get; set; }
        public string Text
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
                    TextChanged?.Invoke(this, null);
                }
            }
        }
        public event System.EventHandler TextChanged;
        public KeyboardKeyRuntime () 
        	: this(true, true)
        {
        }
        public KeyboardKeyRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        	: base(false, tryCreateFormsObject)
        {
            this.tryCreateFormsObject = tryCreateFormsObject;
            this.ExposeChildrenEvents = false;
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Controls/KeyboardKey");
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
            FocusedIndicator = this.GetGraphicalUiElementByName("FocusedIndicator") as global::test_webrtc.GumRuntimes.NineSliceRuntime;
            if (tryCreateFormsObject)
            {
                FormsControlAsObject = new FlatRedBall.Forms.Controls.Button(this);
            }
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
        public FlatRedBall.Forms.Controls.Button FormsControl {get => (FlatRedBall.Forms.Controls.Button) FormsControlAsObject;}
    }
}
