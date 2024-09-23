using NavbarAnimation.Maui.Models;

namespace NavbarAnimation.Maui.Views.Pages;

public partial class LocationsPage : ContentPage
{
    public List<LocationModel> LocationList { get; set; }

    public LocationsPage()
	{
		InitializeComponent();
        this.LocationList = new List<LocationModel>()
        {
            new LocationModel
            {
                LocationName = "Location name 1",
                LocationRating =4.5,
                LocationAddress ="Cairo",
                Locationlatitude = "55.252426",
                Locationlongitude = "13.256487",
                FavoriteIcon = "fill_star.png"
            },
            new LocationModel
            {
                LocationName = "Location name 2",
                LocationRating =3,
                LocationAddress ="Alex",
                Locationlatitude = "55.252426",
                Locationlongitude = "13.256487"
            },
            new LocationModel
            {
                LocationName = "Location name 3",
                LocationRating =2,
                LocationAddress ="London",
                Locationlatitude = "55.252426",
                Locationlongitude = "13.256487"
            },
            new LocationModel
            {
                LocationName = "Location name 4",
                LocationRating =5,
                LocationAddress ="Berlin",
                Locationlatitude = "55.252426",
                Locationlongitude = "13.256487",
                FavoriteIcon = "fill_star"
            },
            new LocationModel
            {
                LocationName = "Location name 5",
                LocationRating =1,
                LocationAddress ="Mombay",
                Locationlatitude = "55.252426",
                Locationlongitude = "13.256487"
            },
            new LocationModel
            {
                LocationName = "Location name 6",
                LocationRating =4.9,
                LocationAddress ="Manchister",
                Locationlatitude = "55.252426",
                Locationlongitude = "13.256487",
                FavoriteIcon = "fill_star"
            }
        };
        this.BindingContext = this;
	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		await Shell.Current.GoToAsync("///" + "HomePage");
    }
}