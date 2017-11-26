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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NAWViewModel nawdata;
        public MainWindow()
        {
            InitializeComponent();
            nawdata = new NAWViewModel();
            nawdata.Name = "Wim de Jong";
            nawdata.Address = "Seringenstraat 4";
            nawdata.City = "Oosterhout NB";
            nawdata.Telephone = 0162428899;
            base.DataContext = nawdata;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //System.Windows.Data.CollectionViewSource nAWViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("nAWViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // nAWViewSource.Source = [generic data source]
        }
    }
}
