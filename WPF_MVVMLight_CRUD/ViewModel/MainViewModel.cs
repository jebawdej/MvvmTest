using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using WPF_MVVMLight_CRUD.Models;
using WPF_MVVMLight_CRUD.Services;

namespace WPF_MVVMLight_CRUD.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public RelayCommand ReadAllCommand { get; set; }
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataAccessService servPxy)
        {
            _serviceProxy = servPxy;
            Employees = new ObservableCollection<EmployeeInfo>();
            ReadAllCommand = new RelayCommand(GetEmployees);
        }

        ObservableCollection<EmployeeInfo> _Employees;
        private IDataAccessService _serviceProxy;

        public ObservableCollection<EmployeeInfo> Employees
        {
            get { return _Employees; }
            set
            {
                _Employees = value;
                RaisePropertyChanged("Employees");
            }
        }

        /// <summary>
        /// Method to Read All Employees
        /// </summary>
        void GetEmployees()
        {
            Employees.Clear();
            foreach (var item in _serviceProxy.GetEmployees())
            {
                Employees.Add(item);
            }
        }
    }
}