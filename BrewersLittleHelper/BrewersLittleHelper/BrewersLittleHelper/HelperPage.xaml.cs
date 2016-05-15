using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BrewersLittleHelper
{
	public partial class HelperPage : ContentPage
	{
		public HelperPage ()
		{
			InitializeComponent ();
		}

		async void deleteHelper(object sender, EventArgs args){
			//var answer = 
			await DisplayAlert ("Delete", "Are you sure you want to delete helper x?", "Yes", "Ofc not!");
			//Use answer to alter the database
		}
	}
}

