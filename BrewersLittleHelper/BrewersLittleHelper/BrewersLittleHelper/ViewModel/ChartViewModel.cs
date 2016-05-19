using System;
using System.Collections.ObjectModel;

namespace BrewersLittleHelper
{
	public class ChartViewModel
	{

		public ObservableCollection<DataPoint> ChartData { get; set; }

		public ChartViewModel ()
		{
			ChartData = new ObservableCollection<DataPoint> ();
		}
	}
}

