using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBoilerPlate.Models
{
    public  class Carrier : INotifyPropertyChanged
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { if (name != null) { name = value; OnPropertyChanged(nameof(Name)); } }
        }

        private string url;

        public string Url
        {
            get { return url; }
            set { if (value != null) { url = value; OnPropertyChanged(nameof(Url)); } }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
