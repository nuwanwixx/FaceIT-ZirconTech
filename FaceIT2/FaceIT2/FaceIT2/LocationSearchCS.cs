using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace FaceIT2
{
    public class LocationSearchCS : ContentPage
    {
        public LocationSearchCS ()
        {
            var customMap = new CustomMap
            {
               
                WidthRequest = 400,
                HeightRequest =300
            };
        
        Content = customMap;
        }
    }
}

