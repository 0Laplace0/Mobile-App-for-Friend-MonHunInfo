namespace Project;

public partial class Rathalos : ContentPage
{
	public Rathalos()
	{
		InitializeComponent();

        //Tab
        var tp = new TabbedPage();
        tp.Children.Add(new RathalosBio());
        tp.Children.Add(new RathalosSub());

    }

}