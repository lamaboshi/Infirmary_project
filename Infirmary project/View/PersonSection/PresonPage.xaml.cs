﻿using Infirmary_project.Enum;
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
        private ContentControl control;
        OpenFileDialog of;
        bool isEmployee = false;
        private int Id;
          public PresonPage(string type,int id) {
            InitializeComponent();
            TransitioningContentControl.Content = guestSection;
            control = HomePage.contentHold;
            Id = id;
            open.Content = "اضافة جهة دخول";
            HomePage.NamePage.Text = "اضافة نزيل";
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
            if (isEmployee) { TransitioningContentControl.Content = employeeSection; HomePage.NamePage.Text = "اضافة موظف"; open.Content = "اضافة نوع الوظيفة"; } else { TransitioningContentControl.Content = guestSection; HomePage.NamePage.Text = "اضافة نزيل"; open.Content = "اضافة جهة دخول"; }
        }

        private void health_Click(object sender, RoutedEventArgs e) {
            control.Content = HomePage.prescription = new prescription();


        }

        private void open_Click(object sender, RoutedEventArgs e) {
            if (isEmployee) {
                emp.IsOpen = true;
            } else { entrySide.IsOpen = true; }
            
        }
    }
}
