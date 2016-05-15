using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BrewersLittleHelper
{
	public partial class AddHelperPage : ContentPage
	{
		public AddHelperPage ()
		{
			InitializeComponent ();
		}

		async void startBlinkUp(object sender, EventArgs args){
			await DisplayAlert ("Blink Up", "Hold the device close to the screen", "Cancel");
		}
	}
}

