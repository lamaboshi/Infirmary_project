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
using System.Windows.Shapes;

namespace Infirmary_project.View {
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window {
        public static ContentControl contentHold;
        public static MainPage mainPage;
        public static PresonPage presonPage;
        public static prescription prescription;
        public static AddAllMatrial addAllMatrial;
        public static ReportSection reportSection;
        public static StorePage storePage;
        public HomePage() {
            InitializeComponent();
            contentHold = controlcontent;
            mainPage = new MainPage();
            contentHold.Content = mainPage;
        }

        private void report_Click(object sender, RoutedEventArgs e) {
            reportSection = new ReportSection();
            contentHold.Content = reportSection;
        }

        private void box_Click(object sender, RoutedEventArgs e) {
            storePage = new StorePage();
            contentHold.Content = storePage;
        }

        private void main_Click(object sender, RoutedEventArgs e) {
            if (contentHold.Content != mainPage)
                contentHold.Content = mainPage;
        }
    }
}
