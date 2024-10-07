namespace test_webrtc.FormsControls.Screens
{
    public partial class GameScreenGumForms
    {
        private Gum.Wireframe.GraphicalUiElement Visual;
        public object BindingContext
        {
            get
            {
                return Visual.BindingContext;
            }
            set
            {
                Visual.BindingContext = value;
            }
        }
        public FlatRedBall.Forms.Controls.Button ButtonStandardInstance { get; set; }
        public GameScreenGumForms () 
        {
            CustomInitialize();
        }
        public GameScreenGumForms (Gum.Wireframe.GraphicalUiElement visual) 
        {
            Visual = visual;
            ReactToVisualChanged();
            CustomInitialize();
        }
        private void ReactToVisualChanged () 
        {
            ButtonStandardInstance = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("ButtonStandardInstance").FormsControlAsObject;
        }
        partial void CustomInitialize();
    }
}
