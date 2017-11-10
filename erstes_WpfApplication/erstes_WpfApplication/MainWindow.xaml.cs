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

namespace erstes_WpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool button_switch;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Button clickedButton = (Button)sender;
            if (button_switch)
            {
                clickedButton.Content = "auf Verkaufsraum umschalten";
                textBlock.Text = "Das Lager";
                button_switch = false;
                Background = new SolidColorBrush(Colors.Red);

            }
            else
            {
                clickedButton.Content = "auf Lageransicht umschalten";
                textBlock.Text = "Der Verkaufsraum";
                button_switch = true;
                Background = new SolidColorBrush(Colors.Aqua);
            }

        }

        public MainWindow()
        {
            InitializeComponent();
            button_switch = true;
            button.Click += Button_Click;
       

        }

       

       

    }
}
