
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

namespace Infirmary_project.View.AddMaterial {
    /// <summary>
    /// Interaction logic for AddReportPage.xaml
    /// </summary>
    public partial class AddReportPage : UserControl {
        List<InnerClass> itemList = new List<InnerClass>();
        List<string> comboList = new List<string> { "دوا", "Test2" };
        public AddReportPage() {
            InitializeComponent();
            MListView.ItemsSource = itemList;
            Mname.ItemsSource = comboList;
        }
        private void Add_Click(object sender, RoutedEventArgs e) {

        }
        class InnerClass {
            public string Mname { get; set; }
            public string amount { get; set; }
        }

        private void addMat_Click(object sender, RoutedEventArgs e) {
            if (Mname.SelectedItem!=null && hold.Content==null) {
                if (Mname.SelectedItem.ToString() == "دوا") {
                    Add_prescription prescription = new Add_prescription();
                    hold.Content = prescription;
                }
            }

            itemList.Add(new InnerClass {
                amount = amountText.Text,
                Mname = Mname.SelectedItem.ToString()
            });
            MListView.ItemsSource = null;
            MListView.ItemsSource = itemList;
        }

        private void Matrname_PreviewMouseDown(object sender, MouseButtonEventArgs e) {


        }

        private void typeM_PreviewMouseDown(object sender, MouseButtonEventArgs e) {

        }

        private void typeM_Click(object sender, RoutedEventArgs e) {
            matrail.Visibility = Visibility.Hidden;
            type.Visibility = Visibility.Visible;
            title.Text = "اضافة صنف";
            typeD.IsOpen = true;
        }

        private void Matrname_Click(object sender, RoutedEventArgs e) {
            type.Visibility = Visibility.Hidden;
            matrail.Visibility = Visibility.Visible;
            title.Text = "اضافة مادة";
            typeD.IsOpen = true;
        }

        private void Mname_SelectionChanged(object sender, SelectionChangedEventArgs e) {


        }
    }
    
}
