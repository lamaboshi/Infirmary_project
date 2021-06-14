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
    /// Interaction logic for AddAllMatrial.xaml
    /// </summary>
    public partial class AddAllMatrial : UserControl {
        public static ContentControl content;
        public static AddReportPage addReport;
        public static Add_prescription prescription;
        bool typeScreen;
        public AddAllMatrial(bool screen) {
            InitializeComponent();
            content = hold;
            typeScreen = screen;
            initializPage();
        }
       void initializPage() {
            if (typeScreen) {
                content.Content = prescription = new Add_prescription();
            } else {
                content.Content = addReport = new AddReportPage();
            }
        }

    }
}
