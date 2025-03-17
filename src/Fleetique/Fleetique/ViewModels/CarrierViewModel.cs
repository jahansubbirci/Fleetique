using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfBoilerPlate.Models;

namespace Fleetique.ViewModels
{
    public class CarrierViewModel:Conductor<Screen>
    {
		private ObservableCollection<Carrier> carriers;

		public ObservableCollection<Carrier> Carriers
        {
            get { return carriers; }
            set { carriers = value;NotifyOfPropertyChange(() => Carriers); }
        }
	

	}
}
