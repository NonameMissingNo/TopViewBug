
namespace TopViewBug
{
    public partial class NavigationTop : ContentView
    {
        public event EventHandler BackPressed;
        public NavigationTop()
        {
            InitializeComponent();
            PageName.Text = "Test";
        }
        private void Back(object sender, EventArgs e)
        {
            BackPressed?.Invoke(sender, e);
        }
    }
}
