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
            CancelCommand = new RelayCommand(Cancel);
        }
        public RelayCommand SaveCommand { get; private set; }
        public RelayCommand CancelCommand { get; private set; }
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
            //Show messageBox
            MessageBox.Show("Save command");
            //TODO: create save functionallity
            _prevNaw = null;
            //Shutdown the application without warning
            Environment.Exit(0);
        }
        public void Cancel()
        {
            Environment.Exit(0);
        }
        public void Load()
        {
            //if _prevNaw object not created, then create new
            if(_prevNaw == null)
                _prevNaw = new NAW();
            //fill _prevNaw to check if something is changed
            _prevNaw.Name = Naw.Name;
            _prevNaw.Address = Naw.Address;
            _prevNaw.City = Naw.City;
            _prevNaw.Telephone = Naw.Telephone;
        }

        public bool CanSave()
        {
            //Check if something is changed, if yes and _prevNaw != null then return true
            if (_prevNaw == null)
                return false;
            else
            {
                bool retval = (Naw.Name != _prevNaw.Name) || (Naw.Address != _prevNaw.Address) ||
                              (Naw.City != _prevNaw.City) || (Naw.Telephone != _prevNaw.Telephone);
                return (retval);
            }

        }

    }




}
