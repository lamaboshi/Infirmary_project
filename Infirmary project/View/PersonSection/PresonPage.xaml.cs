using Infirmary_project.View.PersonSection;
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

namespace Infirmary_project.View {
    /// <summary>
    /// Interaction logic for PresonPage.xaml
    /// </summary>
    public partial class PresonPage : UserControl {
        guestSection guestSection = new guestSection();
        employeeSection employeeSection = new employeeSection();
        OpenFileDialog of;
        bool isEmployee = false;
        public PresonPage() {
            InitializeComponent();
            TransitioningContentControl.Content = guestSection;

        }

        private void ChangImage_Click(object sender, RoutedEventArgs e) {
            of = new OpenFileDialog();
            of.Filter = " images |*.PNG; *.JPG; *.BMP";
            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            Nullable<bool> result = of.ShowDialog();
            if (result == true) {
                InsertImage.ImageSource = new BitmapImage(new Uri(of.FileName));
            }
        }

        private void changePanel_Click(object sender, RoutedEventArgs e) {
            isEmployee = !isEmployee;
            if (isEmployee) { TransitioningContentControl.Content = employeeSection ; } else { TransitioningContentControl.Content = guestSection; }
        }
    }
}
