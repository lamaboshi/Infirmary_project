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
      
        List<innerClass> itemcontrollist = new List<innerClass> { new innerClass { mylist= new List<string> { "سوبر كريب", "انتي كريب" },name="رشح" }, new innerClass { mylist =  new List<string> { "بروفين", "بنادول", "سيتامول" }, name = "عام" } };
        List<innerClassDataGrid> innerClassDatas = new List<innerClassDataGrid> {
          new  innerClassDataGrid{ nameM="رشح",nameH="بنادول",Amount=5,data="2/2/2021"},
          new  innerClassDataGrid{ nameM="رشح",nameH="بنادول",Amount=4,data="3/2/2021"},
          new  innerClassDataGrid{ nameM="عام",nameH="بنادول",Amount=1,data="3/2/2021"},
        };
        private ContentControl content;
        public prescription()
        { 
            
            InitializeComponent();
            content = HomePage.contentHold;
            ItemControlMatrial.ItemsSource = itemcontrollist;
            mdd.ItemsSource = innerClassDatas;
            HomePage.NamePage.Text = "احمد";
            //   ItemControlMatrial2.ItemsSource = itemcontrollist1;
        }

        private void Ad1_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
          
        }

        private void Save_Click(object sender, RoutedEventArgs e) {
            Host.IsOpen = false;
        }

        private void Ad1_PreviewMouseDown_1(object sender, MouseButtonEventArgs e) {
            Host.IsOpen = true;
        }
        class innerClass {
            public string name { get; set; }
            public List<string> mylist { get; set; }
        }
        class innerClassDataGrid {
            public string nameH { get; set; }
            public string nameM { get; set; }
            public int Amount { get; set; }
            public string data { get; set; }

        }

        private void addM_Click(object sender, RoutedEventArgs e) {
            Host.IsOpen = true;

            //ItemControlMatrial.ItemsSource = null;
            //itemcontrollist.Add(new innerClass { mylist = new List<string> { "سوبر كريب", "انتي كريب" }, name = "رشح" });
            //ItemControlMatrial.ItemsSource = itemcontrollist;
        }

        private void Add_Click(object sender, RoutedEventArgs e) {
            AddRport.IsOpen = true;
        }
    }
}
