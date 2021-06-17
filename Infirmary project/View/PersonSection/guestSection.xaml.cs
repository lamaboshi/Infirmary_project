using Infirmary_project.Extenstions;
using Microsoft.Win32;
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

namespace Infirmary_project.View.PersonSection {
    /// <summary>
    /// Interaction logic for guestSection.xaml
    /// </summary>
    public partial class guestSection : UserControl {
        Images_Extenstions extenstions=new Images_Extenstions();
        public guestSection() {
            InitializeComponent();
            HomePage.NamePage.Text = "اضافة نزيل";
        }

        private void cardMid_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            mid.Source = extenstions.ImagePicker();
        }

        private void cardRN_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            rn.Source = extenstions.ImagePicker();
        }
    }
}
