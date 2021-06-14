﻿using System;
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
    /// Interaction logic for AddReportPage.xaml
    /// </summary>
    public partial class AddReportPage : UserControl {
        List<string> itemControlList = new List<string> { "Test", "Test" };
        public AddReportPage() {
            InitializeComponent();
            ItemControlMatrial.ItemsSource = itemControlList;
        }
        private void Add_Click(object sender, RoutedEventArgs e) {
            itemControlList.Add(" ");
            ItemControlMatrial.ItemsSource = null;
            ItemControlMatrial.ItemsSource = itemControlList;
        }
    }
}
