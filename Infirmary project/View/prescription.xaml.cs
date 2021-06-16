using Infirmary_project.View;
using Infirmary_project.View.AddMaterial;
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
        List<String> itemcontrollist = new List<string> { "lama", "ASia", "DAna", "add", "Sur", "Daaa", "asad", "hamza" };
        private ContentControl content;
        public prescription()
        { 
            
            InitializeComponent();
            content = HomePage.contentHold;
            ItemControlMatrial.ItemsSource = itemcontrollist;
            //   ItemControlMatrial2.ItemsSource = itemcontrollist1;
        }

        private void Ad1_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            Host.IsOpen = true;
        }

        private void Save_Click(object sender, RoutedEventArgs e) {
            Host.IsOpen = false;
        }

        private void Ad1_PreviewMouseDown_1(object sender, MouseButtonEventArgs e) {
            Host.IsOpen = true;
        }
    }
}
