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

namespace RadioControlsWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<string> berufeliste = new List<string>
        {
            "Designer","Mechatroniker", "Controller", "Tester" 
        };

        public MainWindow()
        {
            InitializeComponent();
            RadioButton itsk = new RadioButton();
            itsk.Content = "ITSK";
            fachrichtungen.Children.Add(itsk);

            foreach(string item in berufeliste)
            {
                RadioButton rb = new RadioButton { Content = item };
                fachrichtungen.Children.Add(rb);

            }



        }

        private void radioButton_male_Click(object sender, RoutedEventArgs e)
        {
            auswertung.Content = "Ihre Auswahl: männlich";
        }

        private void radioButton_female_Click(object sender, RoutedEventArgs e)
        {
            auswertung.Content = "Ihre Auswahl: weiblich";
        }
    }
}
