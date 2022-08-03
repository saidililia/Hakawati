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
		Navigation.PushAsync(new StoryView());
	}
	private void Add(object sender, EventArgs e)
	{
		firebase.Child("Stories").PostAsync(new Story
		{
			Name = "hello",
			MainImage = "hello"
		});

	}
}

