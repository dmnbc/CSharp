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


namespace GridWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btn2ingrid.Content = "Hallo";
            /*     for (int i = 0; i < theGrid.Children.Count; i++)
                 { MessageBox.Show("i:" + i + "ist ein " + theGrid.Children[i]); }
          //       MessageBox.Show(theGrid.Children[3].GetValue().ToString()); */
        }
    }
}
