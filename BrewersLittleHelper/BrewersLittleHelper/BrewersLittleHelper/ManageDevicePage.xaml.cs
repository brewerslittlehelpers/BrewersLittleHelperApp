using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BrewersLittleHelper
{
	public partial class ManageDevicePage : ContentPage
	{
		public ManageDevicePage ()
		{
			InitializeComponent ();
		}

		private void helperClicked(object sender, EventArgs args) 
		{
			//Button button = (Button)sender;
			//Add funtionality to go to edit my Helpers
			//await DisplayAlert("Clicked", "Button have been clicked, congratulations!", "OK");
			/*if(button == Helper2) 
			{
				Navigation.PushAsync(new HelperPage());
			}*/
			Navigation.PushAsync (new HelperPage ());
		}

		private void addHelperClicked(object sender, EventArgs args)
		{
			//Button button = (Button) sender;
			Navigation.PushAsync(new AddHelperPage());
		}
	}
}

