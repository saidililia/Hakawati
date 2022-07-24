using Firebase.Database;
using Firebase.Database.Query;
using Hakawati.Models;

namespace Hakawati;

public partial class MainPage : ContentPage
{

    FirebaseClient firebase = new FirebaseClient("https://hakawatidb-default-rtdb.europe-west1.firebasedatabase.app/");

    public MainPage()
	{
		InitializeComponent();
	}

	private void ImageButton_Clicked(object sender, EventArgs e)
	{
		 
	}

	private void GetAll(object sender, EventArgs e)
	{

	}

	private void Add(object sender, EventArgs e)
	{

	}
}

