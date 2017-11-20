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

namespace textanalyseWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBox.KeyUp += changed;
        }

        public void changed(object sender, RoutedEventArgs e)
        {
          //  label.Content = "Anzahl der Zeichen"+"\n"+   textBox.Text.Length;
            label2.Content= "Anzahl der Worte" + "\n" + (textBox.Text.Split(' ','.').Length).ToString();
        }
    }
}
