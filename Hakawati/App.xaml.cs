//using Hakawati.Views;

namespace Hakawati;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainPage());
	}

	// what are these i've got no idea
	protected override void OnStart()
	{
		 
	}

    protected override void OnSleep()
    {
         
    }

    protected override void OnResume()
    {
         
    }
}
