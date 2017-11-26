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
        NAW _naw, _prevNaw;
        
        public NAWViewModel()
        {
            _naw = new NAW { Name = "Unknown", Address = "Unknown", City = "Unknown", Telephone = -1 };
            SaveCommand = new RelayCommand(Save, CanSave);
        }
        public RelayCommand SaveCommand { get; private set; }
        public RelayCommand LoadCommand { get; private set; }
        public NAW Naw { get { return _naw; } set { _naw = value; RaisePropertyChanged("Naw");} }
        #region Properties
        public string Name
        {
            get
            {
                return _naw.Name;
            }
            set
            {
                if (Naw.Name != value)
                {
                    Naw.Name = value;
                    RaisePropertyChanged("Name");
                    SaveCommand.RaiseCanExecuteChanged();
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
                if (Naw.Address != value)
                {
                    Naw.Address = value;
                    RaisePropertyChanged("Address");
                    SaveCommand.RaiseCanExecuteChanged();
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
                if (Naw.City != value)
                {
                    Naw.City = value;
                    RaisePropertyChanged("City");
                    SaveCommand.RaiseCanExecuteChanged();
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
                if (Naw.Telephone != value)
                {
                    Naw.Telephone = value;
                    RaisePropertyChanged("Telephone");
                    SaveCommand.RaiseCanExecuteChanged();
                }
            }
        }
#endregion
        public void Save()
        {
            MessageBox.Show("Save command");
            _prevNaw = null;
        }
        public void Load()
        {
            if(_prevNaw == null)
                _prevNaw = new NAW();
            _prevNaw.Name = Naw.Name;
            _prevNaw.Address = Naw.Address;
            _prevNaw.City = Naw.City;
            _prevNaw.Telephone = Naw.Telephone;

        }

        public bool CanSave()
        {
            bool retval = (Naw.Name != _prevNaw.Name) || (Naw.Address != _prevNaw.Address) ||
                          (Naw.City != _prevNaw.City) || (Naw.Telephone != _prevNaw.Telephone);
            return (retval);
        }

    }




}
