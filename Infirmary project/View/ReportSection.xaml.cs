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

namespace Infirmary_project.View {
    /// <summary>
    /// Interaction logic for ReportSection.xaml
    /// </summary>
    public partial class ReportSection : UserControl {
        private ContentControl control;
        public ReportSection() {
            InitializeComponent();
            control = HomePage.contentHold;
        }

        private void Addreport_Click(object sender, RoutedEventArgs e) {
            //AddRport.IsOpen = true;
            Addper.IsOpen = true;
        }
    }
}
