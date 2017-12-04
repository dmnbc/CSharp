using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;

using System.Windows;

namespace WunschListeWpfApplication
{
    class Things : INotifyPropertyChanged
    {
        private string _bezeichnung;
        private double _preis;

        public string bezeichnung
        {
            get { return _bezeichnung;  }
            set
            {
                _bezeichnung = value;
                Changed("bezeichnung");
            }
        }

        public double preis
        {
            get { return _preis; }
            set { _preis = value; }
        }

        private void Changed(string propertyName)
        {
          //   MessageBox.Show(" es wird das Attribute " + propertyName + " gesetzt");
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
