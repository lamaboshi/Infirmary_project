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

namespace Infirmary_project
{
    /// <summary>
    /// Interaction logic for prescription.xaml
    /// </summary>
    public partial class prescription : UserControl
    {
        List<String> itemcontrollist = new List<string> { "Asia" };
        List<String> itemcontrollist1 = new List<string> { "Asia" };
        public prescription()
        { 
            
            InitializeComponent();
            ItemControlMatrial.ItemsSource = itemcontrollist;
            ItemControlMatrial2.ItemsSource = itemcontrollist1;
        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            Host.IsOpen = true;

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Host.IsOpen = false;
        }
    }
}
