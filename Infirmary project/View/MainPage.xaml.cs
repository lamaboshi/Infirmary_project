
using Infirmary_project.Enum;
using Infirmary_project.Model;
using Infirmary_project.Seedes;
using Infirmary_project.Util.ExtensionMethod;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Infirmary_project.View
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : UserControl
    {
        private ContentControl content;
        private HomePageSeedes seedes;
        ObservableCollection<Person> people;
        InfirmaryProjectContext context = new InfirmaryProjectContext();
        public MainPage()
        {
            InitializeComponent();
            seedes = new HomePageSeedes();
            content = HomePage.contentHold;
            FillCompo();
            initializData();
        }
        void initializData() {
            people = new ObservableCollection<Person>();
            people = context.people.ToObservableCollection();
            ListViewPerson.ItemsSource = people;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            dialog.IsOpen = false;
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            dialog.IsOpen = true;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //lama.IsOpen = false;
        }

        private void addPerson_Click(object sender, RoutedEventArgs e) {
            content.Content = HomePage.presonPage=new PresonPage(TypeScrees.Add.ToString());
        }

        private void ShowPerson_Click(object sender, RoutedEventArgs e) {
            var id = ((Button)sender).TabIndex;
            content.Content = HomePage.presonPage = new PresonPage(TypeScrees.Show.ToString());
        }
        public void FillCompo()
        {
            Kind.ItemsSource = seedes.PersonType;
            Emp.ItemsSource = seedes.EmployeeType;
            Cus.ItemsSource = seedes.GuestType;
        }

        private void Kind_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Kind.SelectedValue.ToString() == "موظف")
            {
                txt.Content = "نوع الوظيفة:";
                Emp.Visibility = Visibility.Visible;
                Cus.Visibility = Visibility.Hidden;
            }
            else if (Kind.SelectedValue.ToString() == "نزيل")
            {
                txt.Content = "نوع النزيل:";
                Emp.Visibility = Visibility.Hidden;
                Cus.Visibility = Visibility.Visible;
            }
        }
    }
}
