using System.Linq;
namespace test_webrtc.GumRuntimes
{
    public partial class GameScreenGumRuntime : Gum.Wireframe.GraphicalUiElement
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
                        StartServerButton.ButtonDisplayText = "Start Server";
                        StartServerButton.X = 349f;
                        StartServerButton.Y = 2f;
                        StartClientButton.ButtonDisplayText = "Start Client";
                        StartClientButton.X = 349f;
                        StartClientButton.Y = 47f;
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
            bool setStartClientButtonXFirstValue = false;
            bool setStartClientButtonXSecondValue = false;
            float StartClientButtonXFirstValue= 0;
            float StartClientButtonXSecondValue= 0;
            bool setStartClientButtonYFirstValue = false;
            bool setStartClientButtonYSecondValue = false;
            float StartClientButtonYFirstValue= 0;
            float StartClientButtonYSecondValue= 0;
            bool setStartServerButtonXFirstValue = false;
            bool setStartServerButtonXSecondValue = false;
            float StartServerButtonXFirstValue= 0;
            float StartServerButtonXSecondValue= 0;
            bool setStartServerButtonYFirstValue = false;
            bool setStartServerButtonYSecondValue = false;
            float StartServerButtonYFirstValue= 0;
            float StartServerButtonYSecondValue= 0;
            switch(firstState)
            {
                case  VariableState.Default:
                    if (interpolationValue < 1)
                    {
                        this.StartClientButton.ButtonDisplayText = "Start Client";
                    }
                    setStartClientButtonXFirstValue = true;
                    StartClientButtonXFirstValue = 349f;
                    setStartClientButtonYFirstValue = true;
                    StartClientButtonYFirstValue = 47f;
                    if (interpolationValue < 1)
                    {
                        this.StartServerButton.ButtonDisplayText = "Start Server";
                    }
                    setStartServerButtonXFirstValue = true;
                    StartServerButtonXFirstValue = 349f;
                    setStartServerButtonYFirstValue = true;
                    StartServerButtonYFirstValue = 2f;
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    if (interpolationValue >= 1)
                    {
                        this.StartClientButton.ButtonDisplayText = "Start Client";
                    }
                    setStartClientButtonXSecondValue = true;
                    StartClientButtonXSecondValue = 349f;
                    setStartClientButtonYSecondValue = true;
                    StartClientButtonYSecondValue = 47f;
                    if (interpolationValue >= 1)
                    {
                        this.StartServerButton.ButtonDisplayText = "Start Server";
                    }
                    setStartServerButtonXSecondValue = true;
                    StartServerButtonXSecondValue = 349f;
                    setStartServerButtonYSecondValue = true;
                    StartServerButtonYSecondValue = 2f;
                    break;
            }
            var wasSuppressed = mIsLayoutSuspended;
            var shouldSuspend = wasSuppressed == false;
            var suspendRecursively = true;
            if (shouldSuspend)
            {
                SuspendLayout(suspendRecursively);
            }
            if (setStartClientButtonXFirstValue && setStartClientButtonXSecondValue)
            {
                StartClientButton.X = StartClientButtonXFirstValue * (1 - interpolationValue) + StartClientButtonXSecondValue * interpolationValue;
            }
            if (setStartClientButtonYFirstValue && setStartClientButtonYSecondValue)
            {
                StartClientButton.Y = StartClientButtonYFirstValue * (1 - interpolationValue) + StartClientButtonYSecondValue * interpolationValue;
            }
            if (setStartServerButtonXFirstValue && setStartServerButtonXSecondValue)
            {
                StartServerButton.X = StartServerButtonXFirstValue * (1 - interpolationValue) + StartServerButtonXSecondValue * interpolationValue;
            }
            if (setStartServerButtonYFirstValue && setStartServerButtonYSecondValue)
            {
                StartServerButton.Y = StartServerButtonYFirstValue * (1 - interpolationValue) + StartServerButtonYSecondValue * interpolationValue;
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (global::test_webrtc.GumRuntimes.GameScreenGumRuntime.VariableState fromState,global::test_webrtc.GumRuntimes.GameScreenGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            StartServerButton.StopAnimations();
            StartClientButton.StopAnimations();
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
                        Name = "StartServerButton.ButtonDisplayText",
                        Type = "string",
                        Value = StartServerButton.ButtonDisplayText
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "StartServerButton.X",
                        Type = "float",
                        Value = StartServerButton.X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "StartServerButton.Y",
                        Type = "float",
                        Value = StartServerButton.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "StartClientButton.ButtonDisplayText",
                        Type = "string",
                        Value = StartClientButton.ButtonDisplayText
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "StartClientButton.X",
                        Type = "float",
                        Value = StartClientButton.X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "StartClientButton.Y",
                        Type = "float",
                        Value = StartClientButton.Y
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
                        Name = "StartServerButton.ButtonDisplayText",
                        Type = "string",
                        Value = StartServerButton.ButtonDisplayText
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "StartServerButton.X",
                        Type = "float",
                        Value = StartServerButton.X + 349f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "StartServerButton.Y",
                        Type = "float",
                        Value = StartServerButton.Y + 2f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "StartClientButton.ButtonDisplayText",
                        Type = "string",
                        Value = StartClientButton.ButtonDisplayText
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "StartClientButton.X",
                        Type = "float",
                        Value = StartClientButton.X + 349f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "StartClientButton.Y",
                        Type = "float",
                        Value = StartClientButton.Y + 47f
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
        public global::test_webrtc.GumRuntimes.Controls.ButtonStandardRuntime StartServerButton { get; set; }
        public global::test_webrtc.GumRuntimes.Controls.ButtonStandardRuntime StartClientButton { get; set; }
        public GameScreenGumRuntime () 
        	: this(true, true)
        {
        }
        public GameScreenGumRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        {
            this.tryCreateFormsObject = tryCreateFormsObject;
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "GameScreenGum");
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
            StartServerButton = this.GetGraphicalUiElementByName("StartServerButton") as global::test_webrtc.GumRuntimes.Controls.ButtonStandardRuntime;
            StartClientButton = this.GetGraphicalUiElementByName("StartClientButton") as global::test_webrtc.GumRuntimes.Controls.ButtonStandardRuntime;
            if (tryCreateFormsObject)
            {
                FormsControlAsObject = new global::test_webrtc.FormsControls.Screens.GameScreenGumForms(this);
            }
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
        public global::test_webrtc.FormsControls.Screens.GameScreenGumForms FormsControl {get => (global::test_webrtc.FormsControls.Screens.GameScreenGumForms) FormsControlAsObject;}
    }
}
