using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BrewersLittleHelper
{
    public class App : Application
    {

		public App()
		{
			MainPage = new BrewersLittleHelper.MainPage ();
		}

        public App(object s, EventArgs e)
        {
            // Do stuff here
        }

        public void ThreshholdButtonClicked()
        {
            // do something
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
