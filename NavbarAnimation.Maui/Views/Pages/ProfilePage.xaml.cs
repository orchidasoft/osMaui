namespace NavbarAnimation.Maui.Views.Pages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}

    private async void SignOut_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("///" + "HomePage");
    }
}