namespace Project;

public partial class MenuPage : ContentPage
{
	public MenuPage()
	{
		InitializeComponent();
	}

    private void monster_Clicked(object sender, EventArgs e)
    {
        var fp = Parent as FlyoutPage;
        fp.Detail = new NavigationPage(new MainPage());
        fp.IsPresented = false;
    }
    private void skills_Clicked(object sender, EventArgs e)
    {
        var fp = Parent as FlyoutPage;
        fp.Detail = new NavigationPage(new Skills());
        fp.IsPresented = false;
    }

    private void specializedtools_Clicked(object sender, EventArgs e)
    {
        var fp = Parent as FlyoutPage;
        fp.Detail = new NavigationPage(new SpecializedTools());
        fp.IsPresented = false;
    }

    private void items_Clicked(object sender, EventArgs e)
    {
        var fp = Parent as FlyoutPage;
        fp.Detail = new NavigationPage(new Items());
        fp.IsPresented = false;
    }
    private void ramdom_Clicked(object sender, EventArgs e)
    {
        var fp = Parent as FlyoutPage;
        fp.Detail = new NavigationPage(new RandomEvent());
        fp.IsPresented = false;
    }
}