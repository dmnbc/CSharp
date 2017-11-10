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
    {   public void  end_Click(object sender, RoutedEventArgs e)
        {  //
            
            Background = new SolidColorBrush(Colors.Black);
            EndPopUp.IsOpen = true;
            
            //  SystemCommands.CloseWindow(this);
        }
    
        public static bool button_switch;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Button clickedButton = (Button)sender;
            if (button_switch)
            {
                
                clickedButton.Content = "auf Verkaufsraumansicht umschalten";
                textBlock.Text = "Das Lager";
                Background = new SolidColorBrush(Colors.Red); 

            }
            else
            {
                clickedButton.Content = "auf Lageransicht umschalten";
                textBlock.Text = "Der Verkaufsraum";
                Background = new SolidColorBrush(Colors.Aqua);
            }
            button_switch ^= true;   // an, aus, an, aus , an, aus 
                                     // statt button_switch = !button_switch
         //    clickedButton.Visibility = Visibility.Hidden; 
        }

        public MainWindow()
        {
            InitializeComponent();
            button_switch = true;
            button.Click += Button_Click;
            button_to_quit.Click += end_Click;
            button_yes.Click += new RoutedEventHandler
                                (delegate (Object sender, RoutedEventArgs e)
           { SystemCommands.CloseWindow(this); });   // lambda, 
                                                     // erscheint nicht in Klassendiagrammen
            button_no.Click += new RoutedEventHandler
                               (delegate (Object sender, RoutedEventArgs e)
           { EndPopUp.IsOpen = false ; });          // lambda 
        }

       

       

    }
}
