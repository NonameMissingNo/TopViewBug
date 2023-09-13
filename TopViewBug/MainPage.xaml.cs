namespace TopViewBug
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        NavigationTop TopView;

        protected override void OnAppearing()
        {
            TopView = new();
            TopView.BackPressed += delegate
            {
                Dispatcher.Dispatch(() =>
                {
                    Navigation.PopAsync();
                });
            };
            TopView.WidthRequest = App.Current.Windows[0].Page.Width / 2;
            NavigationPage.SetTitleView(this, TopView);
            NavigationPage.SetHasNavigationBar(this, true);
            NavigationPage.SetHasBackButton(this, false);
            base.OnAppearing();
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}