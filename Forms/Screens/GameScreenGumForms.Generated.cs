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
        public FlatRedBall.Forms.Controls.Button StartServerButton { get; set; }
        public FlatRedBall.Forms.Controls.Button StartClientButton { get; set; }
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
            StartServerButton = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("StartServerButton").FormsControlAsObject;
            StartClientButton = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("StartClientButton").FormsControlAsObject;
        }
        partial void CustomInitialize();
    }
}
