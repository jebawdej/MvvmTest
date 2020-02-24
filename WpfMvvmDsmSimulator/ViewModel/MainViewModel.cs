using GalaSoft.MvvmLight;
using System.Collections;

namespace WpfMvvmDsmSimulator.ViewModel
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
        BitArray _status;
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                Title = "DieselSmokeSimulator (In Design)";
            }
            else
            {
                Title = "DieselSmokeSimulator";
            }
            Status = new BitArray(new byte[] { 0x47});
        }
        public string Title { get; set; }

        BitArray Status {
            get { return _status; }
            set {
                if(_status != value)
                {
                    _status = value;
                    RaisePropertyChanged("Status");
                }
            }
        }
    }
}