﻿using Infirmary_project.Model;
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

namespace Infirmary_project.View
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : UserControl
    {
        private ContentControl content;
        List<Person> people;
        InfirmaryProjectContext context = new InfirmaryProjectContext();
        List<string> testList = new List<string> { "Test", "Test", "Test", "Test", "Test", "Test", "Test" };
        public MainPage()
        {
            InitializeComponent();
            content = HomePage.contentHold;
            FillCompo();
        //  HomePage.NamePage.Text = "رئيسية";
            initializData();
        }
        void initializData() {
            people = new List<Person>();
            people = context.people.ToList();
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
            content.Content = HomePage.presonPage=new PresonPage();
        }

        private void ShowPerson_Click(object sender, RoutedEventArgs e) {
            content.Content = HomePage.presonPage = new PresonPage();
        }
        public void FillCompo()
        {
            Kind.Items.Add("موظف");
            Kind.Items.Add("نزيل");
            Emp.Items.Add("سكرتاريا");
            Emp.Items.Add("ممرض");
            Emp.Items.Add("عامل نظافة");
            Cus.Items.Add("الحاليين");
            Cus.Items.Add("المغادرين");
            Cus.Items.Add("المتوفيين");
        }

        private void Kind_DropDownClosed(object sender, EventArgs e)
        {
          if(Kind.SelectedItem.ToString()== "موظف")
            {
                txt.Content = "نوع الوظيفة:";
                Emp.Visibility = Visibility.Visible;
                Cus.Visibility = Visibility.Hidden;
            }
            else if(Kind.SelectedItem.ToString() == "نزيل")
            {
                txt.Content = "نوع النزيل:";
                Emp.Visibility = Visibility.Hidden;
                Cus.Visibility = Visibility.Visible;
            }
        }
    }
}
