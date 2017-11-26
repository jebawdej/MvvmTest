using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    public class NAWViewModel : INotifyPropertyChanged
    {
        NAW _naw;
        ICommand SaveCommand;
        public NAWViewModel()
        {
            _naw = new NAW { Name = "Unknown", Address = "Unknown", City = "Unknown", Telephone = -1 };
        }

        public NAW naw { get { return _naw; } set { _naw = value; } }

        public string Name
        {
            get
            {
                return _naw.Name;
            }
            set
            {
                if (naw.Name != value)
                {
                    naw.Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        public string Address
        {
            get
            {
                return _naw.Address;
            }
            set
            {
                if (naw.Address != value)
                {
                    naw.Address = value;
                    RaisePropertyChanged("Address");
                }
            }
        }

        public string City
        {
            get
            {
                return _naw.City;
            }
            set
            {
                if (naw.City != value)
                {
                    naw.City = value;
                    RaisePropertyChanged("City");
                }
            }
        }

        public long Telephone
        {
            get
            {
                return _naw.Telephone;
            }
            set
            {
                if (naw.Telephone != value)
                {
                    naw.Telephone = value;
                    RaisePropertyChanged("Telephone");
                }
            }
        }
        public void Save()
        {

        }
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Methods

        private void RaisePropertyChanged(string propertyName)
        {
            // take a copy to prevent thread issues
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }




}
