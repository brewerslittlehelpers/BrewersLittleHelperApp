using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BrewersLittleHelper
{
	public partial class MasterPage : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public MasterPage ()
		{
			InitializeComponent ();

			var masterPageItems = new List<MasterPageItem> ();
			masterPageItems.Add (new MasterPageItem{
				Title = "Monitor",
				IconSource = "hamburger.png",
				TargetType = typeof(GraphDetailPage)
			});
			masterPageItems.Add (new MasterPageItem{
				Title = "Thresholds",
				IconSource = "hamburger.png",
				TargetType = typeof(ThresholdPage)
			});
			masterPageItems.Add (new MasterPageItem{
				Title = "Overview",
				IconSource = "hamburger.png",
				TargetType = typeof(OverviewPage)
			});

			listView.ItemsSource = masterPageItems;
		}
	}
}

