using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace SmartHotel2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Maps : ContentPage
	{
		public Maps ()
		{
			InitializeComponent ();
                   
            var position = new Position(37, -122); // Latitude, Longitude
            var pin = new Pin
            {    
                Type = PinType.Place,
                Position = position,
                Label = "custom pin",
                Address = "custom detail info"
            };                   
            MyMap.Pins.Add(pin);
        }
	}
}