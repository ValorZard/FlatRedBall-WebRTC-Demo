namespace test_webrtc.FormsControls.Screens
{
    public partial class Level1GumForms
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
        public Level1GumForms () 
        {
            CustomInitialize();
        }
        public Level1GumForms (Gum.Wireframe.GraphicalUiElement visual) 
        {
            Visual = visual;
            ReactToVisualChanged();
            CustomInitialize();
        }
        private void ReactToVisualChanged () 
        {
        }
        partial void CustomInitialize();
    }
}
