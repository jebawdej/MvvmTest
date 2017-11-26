using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfNawMvvm.ViewModel;

namespace WpfNawMvvm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NAWViewModel _naw = new NAWViewModel();

        public MainWindow() 
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _naw.Name = "Wim de Jong";
            _naw.Address = "Seringenstraat 4";
            _naw.Telephone = 0162428899;
            _naw.City = "Oosterhout NB";
            DataContext = _naw;
            _naw.Load();
        }
    }
}
