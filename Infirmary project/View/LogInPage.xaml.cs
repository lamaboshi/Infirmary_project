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
    /// Interaction logic for LogInPage.xaml
    /// </summary>
    public partial class LogInPage : Window {
        HomePage homePage = new HomePage();
        public LogInPage() {
            InitializeComponent();
        }

        private void login_Click(object sender, RoutedEventArgs e) {
            homePage.Show();
            this.Close();
        }
    }
}
