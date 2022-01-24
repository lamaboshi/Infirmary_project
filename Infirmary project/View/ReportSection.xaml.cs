using Infirmary_project.View.AddMaterial;
using MaterialDesignThemes.Wpf;
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
        public DialogHost dialog;
        List<InnerClass1> itemList = new List<InnerClass1> 
        { new InnerClass1 { 
            date="1/1/2021",
            empName="Omar",
            name=" 20/2/2020 - تقرير 1",
            innerClasses = new List<InnerClass> { 
                new InnerClass { Mname = "دوا", amount = "50" }, new InnerClass { Mname = "زيت", amount = "5" } } },new InnerClass1 {  date="1/1/2021",
            empName="Omar",
            name=" 20/2/2020 - تقرير 2",
            innerClasses = new List<InnerClass> {
                new InnerClass { Mname = "دوا", amount = "50" }, new InnerClass { Mname = "زيت", amount = "5" } } } ,new InnerClass1 {
                      date="1/1/2021",
            empName="Omar",
            name=" 20/2/2020 - تقرير 3",
            innerClasses = new List<InnerClass> {
                new InnerClass { Mname = "دوا", amount = "50" }, new InnerClass { Mname = "زيت", amount = "5" } } }  };
        List<InnerClass1> itemList1 = new List<InnerClass1>
{ new InnerClass1 {
                date="1/1/2021",
            empName="Omar",
            name=" 20/2/2020 - تقرير 10",
            innerClasses = new List<InnerClass> {
                new InnerClass { Mname = "دوا", amount = "50" }, new InnerClass { Mname = "زيت", amount = "5" } } } ,new InnerClass1 {
                      date="1/1/2021",
            empName="Omar",
            name=" 20/2/2020 - تقرير 20",
            innerClasses = new List<InnerClass> {
                new InnerClass { Mname = "دوا", amount = "50" }, new InnerClass { Mname = "زيت", amount = "5" } } } ,new InnerClass1 {
                      date="1/1/2021",
            empName="Omar",
            name=" 20/2/2020 - تقرير 30",
            innerClasses = new List<InnerClass> {
                new InnerClass { Mname = "دوا", amount = "50" }, new InnerClass { Mname = "زيت", amount = "5" } } } };
        public ReportSection() {
            InitializeComponent();
            control = HomePage.contentHold;
            dialog = Addper;
            ListViewPerson.ItemsSource = itemList;
            ListViewPerson1.ItemsSource = itemList1;
            HomePage.NamePage.Text = "تقارير";
        }
        class InnerClass1 {
            public string name { get; set; }
            public string empName { get; set; }
            public string date { get; set; }
            public List<InnerClass> innerClasses { get; set; }
        }
        class InnerClass {
            public string Mname { get; set; }
            public string amount { get; set; }
        }
        private void Addreport_Click(object sender, RoutedEventArgs e) {
           AddRport.IsOpen = true;
       // Addper.IsOpen = true;
        }
    }
}
