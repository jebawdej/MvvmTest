using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfNawMvvm.Models;

namespace WpfNawMvvm.ViewModel
{
    public class NAWViewModel : ViewModelBase
    {
        NAW _naw;
        ICommand SaveCommand;
        public NAWViewModel()
        {
            _naw = new NAW { Name = "Unknown", Address = "Unknown", City = "Unknown", Telephone = -1 };
            SaveCommand = new RelayCommand(Save);
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
            MessageBox.Show("Save command");
        }

    }




}
