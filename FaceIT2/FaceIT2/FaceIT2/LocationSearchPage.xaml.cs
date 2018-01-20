using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace FaceIT2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocationSearchPage : ContentPage
    {
        public LocationSearchPage()
        {
            InitializeComponent();
            btnGetLocation.Clicked += btnGetLocation_Clicked;
        }

        private async void btnGetLocation_Clicked(object sender, EventArgs e)
        {
            await RetreiveLocation();
        }

        private async Task RetreiveLocation()
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 20;

            var position = await locator.GetPositionAsync();




            var pin = new Pin
            {
                Type = PinType.Place,
                Position = new Position(position.Latitude, position.Longitude),
                Label = "Current location",
                Address = "Address"

            };


            /*var positionMid = new Position(position.Latitude, position.Longitude);
            MainMap.Circle = new CustomCircle
            {
                Position = positionMid,
                Radius = 1000
            };*/

            MainMap.Pins.Add(pin);
            MainMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(position.Latitude, position.Longitude), Distance.FromMiles(1)));

        }

    }
}