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
    /// Interaction logic for Add_prescription.xaml
    /// </summary>
    public partial class Add_prescription : UserControl {
        List<InnerClass> itemList = new List<InnerClass>();
        List<string> comboList = new List<string> { "Test", "Test2" };
        public Add_prescription() {
            InitializeComponent();
            MListView.ItemsSource = itemList;
            Mname.ItemsSource = comboList;
        }
        class InnerClass {
            public string Mname { get; set; }
            public string amount { get; set; }
        }

        private void addMat_Click(object sender, RoutedEventArgs e) {
            itemList.Add(new InnerClass {
                amount = amountText.Text,
                Mname = Mname.SelectedItem.ToString()
            });
            MListView.ItemsSource = null;
            MListView.ItemsSource = itemList;
        }
    }
}
