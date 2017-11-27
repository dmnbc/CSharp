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
using System.Windows.Media.Animation;   // nötig für Animationen 
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e) // sobald der Schirm einmal komplett gezeichnet ist
        {
            // from,to or by
         // <type>Animation  steuerndes Objekt 
            DoubleAnimation  change            = new DoubleAnimation();

            // ausgehend von Startwert, wenn dieser beim Start geändert werden soll
            change.From = 0;
            // ändern in Zielwert
            change.To = 300;
            // in welcher Zeit soll die Änderung erfolgen
            change.Duration = TimeSpan.Parse("0:0:10");

            // optional kann auch eine Verhalten nach einem Durchlauf gesetzt werden
            change.AutoReverse = true;
            // optional kann auch eine Anzahl der Wiederholungen gesetzt werden
            change.RepeatBehavior = RepeatBehavior.Forever;
            // optional mit Anfangsverzögerung
            change.BeginTime = TimeSpan.Parse("0:0:10");


            // wer soll animiert werden
            btn1.BeginAnimation(Button.WidthProperty, change);
       // wenn synchron in gleicher Weise      btn1.BeginAnimation(Button.HeightProperty, change);
           
            
        }
    }
 }
