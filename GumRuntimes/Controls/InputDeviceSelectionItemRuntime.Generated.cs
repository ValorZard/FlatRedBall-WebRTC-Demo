using System.Linq;
namespace test_webrtc.GumRuntimes.Controls
{
    public partial class InputDeviceSelectionItemRuntime : global::test_webrtc.GumRuntimes.ContainerRuntime, global::test_webrtc.GumRuntimes.IInputDeviceSelectionItemBehavior
    {
        #region State Enums
        public enum VariableState
        {
            Default
        }
        public enum JoinedCategory
        {
            NoInputDevice,
            HasInputDevice
        }
        #endregion
        #region State Fields
        VariableState mCurrentVariableState;
        JoinedCategory? mCurrentJoinedCategoryState;
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
                        Background.CurrentStyleCategoryState = global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Panel;
                        IconInstance.CurrentIconCategoryState = global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory.Gamepad;
                        TextInstance.CurrentColorCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                        TextInstance.CurrentStyleCategoryState = global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory.H2;
                        Height = 113f;
                        HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        IconInstance.X = 0f;
                        IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        IconInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        IconInstance.Y = 5f;
                        IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        IconInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        TextInstance.Height = -43f;
                        TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        TextInstance.Text = "Input Device Name Here With 3 Lines";
                        TextInstance.TextOverflowHorizontalMode = global::RenderingLibrary.Graphics.TextOverflowHorizontalMode.EllipsisLetter;
                        TextInstance.TextOverflowVerticalMode = global::RenderingLibrary.Graphics.TextOverflowVerticalMode.TruncateLine;
                        TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        TextInstance.Width = 0f;
                        TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        TextInstance.X = 0f;
                        TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        TextInstance.Y = 39f;
                        TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        RemoveDeviceButtonInstance.Height = 22f;
                        RemoveDeviceButtonInstance.Width = 22f;
                        RemoveDeviceButtonInstance.X = -4f;
                        RemoveDeviceButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        RemoveDeviceButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        RemoveDeviceButtonInstance.Y = 4f;
                        RemoveDeviceButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        RemoveDeviceButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        break;
                }
            }
        }
        public JoinedCategory? CurrentJoinedCategoryState
        {
            get
            {
                return mCurrentJoinedCategoryState;
            }
            set
            {
                if (value != null)
                {
                    mCurrentJoinedCategoryState = value;
                    switch(mCurrentJoinedCategoryState)
                    {
                        case  JoinedCategory.NoInputDevice:
                            IconInstance.CurrentIconCategoryState = global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory.None;
                            TextInstance.Visible = false;
                            RemoveDeviceButtonInstance.Visible = false;
                            break;
                        case  JoinedCategory.HasInputDevice:
                            IconInstance.CurrentIconCategoryState = global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory.Gamepad;
                            TextInstance.Visible = true;
                            RemoveDeviceButtonInstance.Visible = true;
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
            bool setBackgroundCurrentStyleCategoryStateFirstValue = false;
            bool setBackgroundCurrentStyleCategoryStateSecondValue = false;
            global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory BackgroundCurrentStyleCategoryStateFirstValue= global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory BackgroundCurrentStyleCategoryStateSecondValue= global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            bool setHeightFirstValue = false;
            bool setHeightSecondValue = false;
            float HeightFirstValue= 0;
            float HeightSecondValue= 0;
            bool setIconInstanceCurrentIconCategoryStateFirstValue = false;
            bool setIconInstanceCurrentIconCategoryStateSecondValue = false;
            global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory IconInstanceCurrentIconCategoryStateFirstValue= global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory.None;
            global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory IconInstanceCurrentIconCategoryStateSecondValue= global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory.None;
            bool setIconInstanceXFirstValue = false;
            bool setIconInstanceXSecondValue = false;
            float IconInstanceXFirstValue= 0;
            float IconInstanceXSecondValue= 0;
            bool setIconInstanceYFirstValue = false;
            bool setIconInstanceYSecondValue = false;
            float IconInstanceYFirstValue= 0;
            float IconInstanceYSecondValue= 0;
            bool setRemoveDeviceButtonInstanceHeightFirstValue = false;
            bool setRemoveDeviceButtonInstanceHeightSecondValue = false;
            float RemoveDeviceButtonInstanceHeightFirstValue= 0;
            float RemoveDeviceButtonInstanceHeightSecondValue= 0;
            bool setRemoveDeviceButtonInstanceWidthFirstValue = false;
            bool setRemoveDeviceButtonInstanceWidthSecondValue = false;
            float RemoveDeviceButtonInstanceWidthFirstValue= 0;
            float RemoveDeviceButtonInstanceWidthSecondValue= 0;
            bool setRemoveDeviceButtonInstanceXFirstValue = false;
            bool setRemoveDeviceButtonInstanceXSecondValue = false;
            float RemoveDeviceButtonInstanceXFirstValue= 0;
            float RemoveDeviceButtonInstanceXSecondValue= 0;
            bool setRemoveDeviceButtonInstanceYFirstValue = false;
            bool setRemoveDeviceButtonInstanceYSecondValue = false;
            float RemoveDeviceButtonInstanceYFirstValue= 0;
            float RemoveDeviceButtonInstanceYSecondValue= 0;
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
            switch(firstState)
            {
                case  VariableState.Default:
                    setBackgroundCurrentColorCategoryStateFirstValue = true;
                    BackgroundCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    setBackgroundCurrentStyleCategoryStateFirstValue = true;
                    BackgroundCurrentStyleCategoryStateFirstValue = global::test_webrtc.GumRuntimes.NineSliceRuntime.StyleCategory.Panel;
                    setHeightFirstValue = true;
                    HeightFirstValue = 113f;
                    if (interpolationValue < 1)
                    {
                        this.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setIconInstanceCurrentIconCategoryStateFirstValue = true;
                    IconInstanceCurrentIconCategoryStateFirstValue = global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory.Gamepad;
                    setIconInstanceXFirstValue = true;
                    IconInstanceXFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setIconInstanceYFirstValue = true;
                    IconInstanceYFirstValue = 5f;
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setRemoveDeviceButtonInstanceHeightFirstValue = true;
                    RemoveDeviceButtonInstanceHeightFirstValue = 22f;
                    setRemoveDeviceButtonInstanceWidthFirstValue = true;
                    RemoveDeviceButtonInstanceWidthFirstValue = 22f;
                    setRemoveDeviceButtonInstanceXFirstValue = true;
                    RemoveDeviceButtonInstanceXFirstValue = -4f;
                    if (interpolationValue < 1)
                    {
                        this.RemoveDeviceButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                    }
                    if (interpolationValue < 1)
                    {
                        this.RemoveDeviceButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setRemoveDeviceButtonInstanceYFirstValue = true;
                    RemoveDeviceButtonInstanceYFirstValue = 4f;
                    if (interpolationValue < 1)
                    {
                        this.RemoveDeviceButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue < 1)
                    {
                        this.RemoveDeviceButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    setTextInstanceHeightFirstValue = true;
                    TextInstanceHeightFirstValue = -43f;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    setTextInstanceCurrentStyleCategoryStateFirstValue = true;
                    TextInstanceCurrentStyleCategoryStateFirstValue = global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory.H2;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.Text = "Input Device Name Here With 3 Lines";
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.TextOverflowHorizontalMode = global::RenderingLibrary.Graphics.TextOverflowHorizontalMode.EllipsisLetter;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.TextOverflowVerticalMode = global::RenderingLibrary.Graphics.TextOverflowVerticalMode.TruncateLine;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
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
                    TextInstanceYFirstValue = 39f;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
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
                    setHeightSecondValue = true;
                    HeightSecondValue = 113f;
                    if (interpolationValue >= 1)
                    {
                        this.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setIconInstanceCurrentIconCategoryStateSecondValue = true;
                    IconInstanceCurrentIconCategoryStateSecondValue = global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory.Gamepad;
                    setIconInstanceXSecondValue = true;
                    IconInstanceXSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setIconInstanceYSecondValue = true;
                    IconInstanceYSecondValue = 5f;
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setRemoveDeviceButtonInstanceHeightSecondValue = true;
                    RemoveDeviceButtonInstanceHeightSecondValue = 22f;
                    setRemoveDeviceButtonInstanceWidthSecondValue = true;
                    RemoveDeviceButtonInstanceWidthSecondValue = 22f;
                    setRemoveDeviceButtonInstanceXSecondValue = true;
                    RemoveDeviceButtonInstanceXSecondValue = -4f;
                    if (interpolationValue >= 1)
                    {
                        this.RemoveDeviceButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.RemoveDeviceButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setRemoveDeviceButtonInstanceYSecondValue = true;
                    RemoveDeviceButtonInstanceYSecondValue = 4f;
                    if (interpolationValue >= 1)
                    {
                        this.RemoveDeviceButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.RemoveDeviceButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.ColorCategory.White;
                    setTextInstanceHeightSecondValue = true;
                    TextInstanceHeightSecondValue = -43f;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    setTextInstanceCurrentStyleCategoryStateSecondValue = true;
                    TextInstanceCurrentStyleCategoryStateSecondValue = global::test_webrtc.GumRuntimes.TextRuntime.StyleCategory.H2;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.Text = "Input Device Name Here With 3 Lines";
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.TextOverflowHorizontalMode = global::RenderingLibrary.Graphics.TextOverflowHorizontalMode.EllipsisLetter;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.TextOverflowVerticalMode = global::RenderingLibrary.Graphics.TextOverflowVerticalMode.TruncateLine;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
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
                    TextInstanceYSecondValue = 39f;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
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
            if (setHeightFirstValue && setHeightSecondValue)
            {
                Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
            }
            if (setIconInstanceCurrentIconCategoryStateFirstValue && setIconInstanceCurrentIconCategoryStateSecondValue)
            {
                IconInstance.InterpolateBetween(IconInstanceCurrentIconCategoryStateFirstValue, IconInstanceCurrentIconCategoryStateSecondValue, interpolationValue);
            }
            if (setIconInstanceXFirstValue && setIconInstanceXSecondValue)
            {
                IconInstance.X = IconInstanceXFirstValue * (1 - interpolationValue) + IconInstanceXSecondValue * interpolationValue;
            }
            if (setIconInstanceYFirstValue && setIconInstanceYSecondValue)
            {
                IconInstance.Y = IconInstanceYFirstValue * (1 - interpolationValue) + IconInstanceYSecondValue * interpolationValue;
            }
            if (setRemoveDeviceButtonInstanceHeightFirstValue && setRemoveDeviceButtonInstanceHeightSecondValue)
            {
                RemoveDeviceButtonInstance.Height = RemoveDeviceButtonInstanceHeightFirstValue * (1 - interpolationValue) + RemoveDeviceButtonInstanceHeightSecondValue * interpolationValue;
            }
            if (setRemoveDeviceButtonInstanceWidthFirstValue && setRemoveDeviceButtonInstanceWidthSecondValue)
            {
                RemoveDeviceButtonInstance.Width = RemoveDeviceButtonInstanceWidthFirstValue * (1 - interpolationValue) + RemoveDeviceButtonInstanceWidthSecondValue * interpolationValue;
            }
            if (setRemoveDeviceButtonInstanceXFirstValue && setRemoveDeviceButtonInstanceXSecondValue)
            {
                RemoveDeviceButtonInstance.X = RemoveDeviceButtonInstanceXFirstValue * (1 - interpolationValue) + RemoveDeviceButtonInstanceXSecondValue * interpolationValue;
            }
            if (setRemoveDeviceButtonInstanceYFirstValue && setRemoveDeviceButtonInstanceYSecondValue)
            {
                RemoveDeviceButtonInstance.Y = RemoveDeviceButtonInstanceYFirstValue * (1 - interpolationValue) + RemoveDeviceButtonInstanceYSecondValue * interpolationValue;
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
        public void InterpolateBetween (JoinedCategory firstState, JoinedCategory secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            bool setIconInstanceCurrentIconCategoryStateFirstValue = false;
            bool setIconInstanceCurrentIconCategoryStateSecondValue = false;
            global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory IconInstanceCurrentIconCategoryStateFirstValue= global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory.None;
            global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory IconInstanceCurrentIconCategoryStateSecondValue= global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory.None;
            switch(firstState)
            {
                case  JoinedCategory.NoInputDevice:
                    setIconInstanceCurrentIconCategoryStateFirstValue = true;
                    IconInstanceCurrentIconCategoryStateFirstValue = global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory.None;
                    if (interpolationValue < 1)
                    {
                        this.RemoveDeviceButtonInstance.Visible = false;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.Visible = false;
                    }
                    break;
                case  JoinedCategory.HasInputDevice:
                    setIconInstanceCurrentIconCategoryStateFirstValue = true;
                    IconInstanceCurrentIconCategoryStateFirstValue = global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory.Gamepad;
                    if (interpolationValue < 1)
                    {
                        this.RemoveDeviceButtonInstance.Visible = true;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.Visible = true;
                    }
                    break;
            }
            switch(secondState)
            {
                case  JoinedCategory.NoInputDevice:
                    setIconInstanceCurrentIconCategoryStateSecondValue = true;
                    IconInstanceCurrentIconCategoryStateSecondValue = global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory.None;
                    if (interpolationValue >= 1)
                    {
                        this.RemoveDeviceButtonInstance.Visible = false;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.Visible = false;
                    }
                    break;
                case  JoinedCategory.HasInputDevice:
                    setIconInstanceCurrentIconCategoryStateSecondValue = true;
                    IconInstanceCurrentIconCategoryStateSecondValue = global::test_webrtc.GumRuntimes.Elements.IconRuntime.IconCategory.Gamepad;
                    if (interpolationValue >= 1)
                    {
                        this.RemoveDeviceButtonInstance.Visible = true;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.Visible = true;
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
            if (setIconInstanceCurrentIconCategoryStateFirstValue && setIconInstanceCurrentIconCategoryStateSecondValue)
            {
                IconInstance.InterpolateBetween(IconInstanceCurrentIconCategoryStateFirstValue, IconInstanceCurrentIconCategoryStateSecondValue, interpolationValue);
            }
            if (interpolationValue < 1)
            {
                mCurrentJoinedCategoryState = firstState;
            }
            else
            {
                mCurrentJoinedCategoryState = secondState;
            }
            if (shouldSuspend)
            {
                ResumeLayout(suspendRecursively);
            }
        }
        #endregion
        #region State Interpolate To
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (global::test_webrtc.GumRuntimes.Controls.InputDeviceSelectionItemRuntime.VariableState fromState,global::test_webrtc.GumRuntimes.Controls.InputDeviceSelectionItemRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (global::test_webrtc.GumRuntimes.Controls.InputDeviceSelectionItemRuntime.JoinedCategory fromState,global::test_webrtc.GumRuntimes.Controls.InputDeviceSelectionItemRuntime.JoinedCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JoinedCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "JoinedCategory").States.First(item => item.Name == toState.ToString());
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
            tweener.Ended += ()=> this.CurrentJoinedCategoryState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (JoinedCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
            tweener.Ended += ()=> this.CurrentJoinedCategoryState = toState;
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
            IconInstance.StopAnimations();
            RemoveDeviceButtonInstance.StopAnimations();
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
                        Name = "IconInstance.IconCategoryState",
                        Type = "IconCategory",
                        Value = IconInstance.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X",
                        Type = "float",
                        Value = IconInstance.X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = IconInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X Units",
                        Type = "PositionUnitType",
                        Value = IconInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y",
                        Type = "float",
                        Value = IconInstance.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = IconInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = IconInstance.YUnits
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
                        Name = "TextInstance.TextOverflowHorizontalMode",
                        Type = "TextOverflowHorizontalMode",
                        Value = TextInstance.TextOverflowHorizontalMode
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.TextOverflowVerticalMode",
                        Type = "TextOverflowVerticalMode",
                        Value = TextInstance.TextOverflowVerticalMode
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
                        Name = "RemoveDeviceButtonInstance.Height",
                        Type = "float",
                        Value = RemoveDeviceButtonInstance.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RemoveDeviceButtonInstance.Width",
                        Type = "float",
                        Value = RemoveDeviceButtonInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RemoveDeviceButtonInstance.X",
                        Type = "float",
                        Value = RemoveDeviceButtonInstance.X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RemoveDeviceButtonInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = RemoveDeviceButtonInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RemoveDeviceButtonInstance.X Units",
                        Type = "PositionUnitType",
                        Value = RemoveDeviceButtonInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RemoveDeviceButtonInstance.Y",
                        Type = "float",
                        Value = RemoveDeviceButtonInstance.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RemoveDeviceButtonInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = RemoveDeviceButtonInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RemoveDeviceButtonInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = RemoveDeviceButtonInstance.YUnits
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
                        Value = Height + 113f
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
                        Name = "IconInstance.IconCategoryState",
                        Type = "IconCategory",
                        Value = IconInstance.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X",
                        Type = "float",
                        Value = IconInstance.X + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = IconInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X Units",
                        Type = "PositionUnitType",
                        Value = IconInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y",
                        Type = "float",
                        Value = IconInstance.Y + 5f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = IconInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = IconInstance.YUnits
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
                        Value = TextInstance.Height + -43f
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
                        Name = "TextInstance.TextOverflowHorizontalMode",
                        Type = "TextOverflowHorizontalMode",
                        Value = TextInstance.TextOverflowHorizontalMode
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.TextOverflowVerticalMode",
                        Type = "TextOverflowVerticalMode",
                        Value = TextInstance.TextOverflowVerticalMode
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
                        Value = TextInstance.Y + 39f
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
                        Name = "RemoveDeviceButtonInstance.Height",
                        Type = "float",
                        Value = RemoveDeviceButtonInstance.Height + 22f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RemoveDeviceButtonInstance.Width",
                        Type = "float",
                        Value = RemoveDeviceButtonInstance.Width + 22f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RemoveDeviceButtonInstance.X",
                        Type = "float",
                        Value = RemoveDeviceButtonInstance.X + -4f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RemoveDeviceButtonInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = RemoveDeviceButtonInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RemoveDeviceButtonInstance.X Units",
                        Type = "PositionUnitType",
                        Value = RemoveDeviceButtonInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RemoveDeviceButtonInstance.Y",
                        Type = "float",
                        Value = RemoveDeviceButtonInstance.Y + 4f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RemoveDeviceButtonInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = RemoveDeviceButtonInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RemoveDeviceButtonInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = RemoveDeviceButtonInstance.YUnits
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (JoinedCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  JoinedCategory.NoInputDevice:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconCategoryState",
                        Type = "string",
                        Value = IconInstance.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Visible",
                        Type = "bool",
                        Value = TextInstance.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RemoveDeviceButtonInstance.Visible",
                        Type = "bool",
                        Value = RemoveDeviceButtonInstance.Visible
                    }
                    );
                    break;
                case  JoinedCategory.HasInputDevice:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconCategoryState",
                        Type = "IconCategory",
                        Value = IconInstance.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Visible",
                        Type = "bool",
                        Value = TextInstance.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RemoveDeviceButtonInstance.Visible",
                        Type = "bool",
                        Value = RemoveDeviceButtonInstance.Visible
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (JoinedCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  JoinedCategory.NoInputDevice:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconCategoryState",
                        Type = "string",
                        Value = IconInstance.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Visible",
                        Type = "bool",
                        Value = TextInstance.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RemoveDeviceButtonInstance.Visible",
                        Type = "bool",
                        Value = RemoveDeviceButtonInstance.Visible
                    }
                    );
                    break;
                case  JoinedCategory.HasInputDevice:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconCategoryState",
                        Type = "IconCategory",
                        Value = IconInstance.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Visible",
                        Type = "bool",
                        Value = TextInstance.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RemoveDeviceButtonInstance.Visible",
                        Type = "bool",
                        Value = RemoveDeviceButtonInstance.Visible
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
                else if (category.Name == "JoinedCategory")
                {
                    if(state.Name == "NoInputDevice") this.mCurrentJoinedCategoryState = JoinedCategory.NoInputDevice;
                    if(state.Name == "HasInputDevice") this.mCurrentJoinedCategoryState = JoinedCategory.HasInputDevice;
                }
            }
            base.ApplyState(state);
        }
        global::test_webrtc.GumRuntimes.IInputDeviceSelectionItemBehavior.JoinedCategory global::test_webrtc.GumRuntimes.IInputDeviceSelectionItemBehavior.CurrentJoinedCategoryState
        {
            set
            {
                switch(value)
                {
                    case  global::test_webrtc.GumRuntimes.IInputDeviceSelectionItemBehavior.JoinedCategory.HasInputDevice:
                        this.CurrentJoinedCategoryState = JoinedCategory.HasInputDevice;
                        break;
                    case  global::test_webrtc.GumRuntimes.IInputDeviceSelectionItemBehavior.JoinedCategory.NoInputDevice:
                        this.CurrentJoinedCategoryState = JoinedCategory.NoInputDevice;
                        break;
                }
            }
        }
        private bool tryCreateFormsObject;
        public global::test_webrtc.GumRuntimes.NineSliceRuntime Background { get; set; }
        public global::test_webrtc.GumRuntimes.Elements.IconRuntime IconInstance { get; set; }
        public global::test_webrtc.GumRuntimes.TextRuntime TextInstance { get; set; }
        public global::test_webrtc.GumRuntimes.Controls.ButtonCloseRuntime RemoveDeviceButtonInstance { get; set; }
        public event FlatRedBall.Gui.WindowEvent IconInstanceClick;
        public event FlatRedBall.Gui.WindowEvent RemoveDeviceButtonInstanceClick;
        public InputDeviceSelectionItemRuntime () 
        	: this(true, true)
        {
        }
        public InputDeviceSelectionItemRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        	: base(false, tryCreateFormsObject)
        {
            this.tryCreateFormsObject = tryCreateFormsObject;
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Controls/InputDeviceSelectionItem");
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
            IconInstance = this.GetGraphicalUiElementByName("IconInstance") as global::test_webrtc.GumRuntimes.Elements.IconRuntime;
            TextInstance = this.GetGraphicalUiElementByName("TextInstance") as global::test_webrtc.GumRuntimes.TextRuntime;
            RemoveDeviceButtonInstance = this.GetGraphicalUiElementByName("RemoveDeviceButtonInstance") as global::test_webrtc.GumRuntimes.Controls.ButtonCloseRuntime;
            IconInstance.Click += (unused) => IconInstanceClick?.Invoke(this);
            RemoveDeviceButtonInstance.Click += (unused) => RemoveDeviceButtonInstanceClick?.Invoke(this);
            if (tryCreateFormsObject)
            {
                FormsControlAsObject = new FlatRedBall.Forms.Controls.Games.InputDeviceSelectionItem(this);
            }
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
        public FlatRedBall.Forms.Controls.Games.InputDeviceSelectionItem FormsControl {get => (FlatRedBall.Forms.Controls.Games.InputDeviceSelectionItem) FormsControlAsObject;}
    }
}
