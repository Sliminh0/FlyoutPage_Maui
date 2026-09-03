namespace app_hamburguer;

public partial class appFlyoutPage : ContentPage
{
	public appFlyoutPage()
	{
		InitializeComponent();

		Detail = new NavigationPage(new MainPage());
	}

    private void OnautonomiaClicked(object sender, EventArgs e)
    {
		Detail = new NavigationPage(new CalculoAutonomia());
		IsPresented = false;
    }

    private void gasetaClicked(object sender, EventArgs e)
    {
		Detail = new NavigationPage(new NewPage1());
		IsPresented = false;
    }
}