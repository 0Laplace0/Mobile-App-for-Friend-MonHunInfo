namespace Project
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new test();
            
            var np = new NavigationPage(new MainPage());

            var fp = new FlyoutPage();
            fp.Flyout = new MenuPage();
            fp.Detail = new NavigationPage(new MainPage());

            MainPage = fp;
            
        }
    }
}
