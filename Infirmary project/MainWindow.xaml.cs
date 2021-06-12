using Infirmary_project.View;
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
using Infirmary_project.Model;

namespace Infirmary_project {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
       
        public static ContentControl control;

       InfirmaryProjectContext context =new InfirmaryProjectContext();
        PresonPage presonPage = new PresonPage();
        MainPage page = new MainPage();
        
        public MainWindow() {
            
            InitializeComponent();
            var g = context.EntrySides.Where(s=> s.Name=="h");
            Content.Content = page;
        }

    }
}
