using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RaumdarstellungWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
         public static List<Label> gangbei = new List<Label>(); // soll das Abbiegen in die Gänge steuern

        public MainWindow()
        {
            InitializeComponent();
            Label headline = new Label
            {
                Content = "VERKAUFSRAUM",
                HorizontalAlignment = HorizontalAlignment.Center,
                Background = Brushes.BurlyWood
            };
            Verkauf.Children.Add(headline);
            for(int i = 0; i < 10; i++)
            {
                StackPanel gang = new StackPanel();
                gang.Name = "Gang" + i;
                gang.Orientation=System.Windows.Controls.Orientation.Horizontal;
                StackPanel gangVor = new StackPanel();
                gangVor.Orientation = System.Windows.Controls.Orientation.Vertical;
                Label leerVorO = new Label { Content = " " }; leerVorO.Background = Brushes.Red;
                Label leerVorM = new Label { Content = " ",Name="GA"+i }; leerVorM.Background = Brushes.Red;
                gangbei.Add(leerVorM);
                Label leerVorU = new Label { Content = " " }; leerVorU.Background = Brushes.Red;
                gangVor.Children.Add(leerVorO);
                gangVor.Children.Add(leerVorM);
                gangVor.Children.Add(leerVorU);
                gang.Children.Add(gangVor);
                for (int j = 0; j < 40; j++)
                {
                    StackPanel rgr = new StackPanel();
                    rgr.Orientation = System.Windows.Controls.Orientation.Vertical;
                    Label regal_l = new Label { Content = "R"+ ((i*40+j)*2).ToString("D3") };
                    Label leer    = new Label { Content = " " }; leer.Background = Brushes.Red;
                       
                    Label regal_r = new Label { Content = "R"+(((i * 40 + j) * 2)+1).ToString("D3") };
                    rgr.Children.Add(regal_l);
                    rgr.Children.Add(leer);
                    rgr.Children.Add(regal_r);

                    gang.Children.Add(rgr);
                }
                StackPanel gangNach = new StackPanel();
                gangNach.Orientation = System.Windows.Controls.Orientation.Vertical;
                Label leerNachO = new Label { Content = " " }; leerNachO.Background = Brushes.Red;
                Label leerNachM = new Label { Content = " " }; leerNachM.Background = Brushes.Red;
                Label leerNachU = new Label { Content = " " }; leerNachU.Background = Brushes.Red;
                gangNach.Children.Add(leerNachO);
                gangNach.Children.Add(leerNachM);
                gangNach.Children.Add(leerNachU);
                gang.Children.Add(gangNach);
                Verkauf.Children.Add(gang);
            }
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //  double pos;

            foreach (Label g in gangbei)
            {
                Point relativePoint = g.TransformToAncestor(Application.Current.MainWindow).Transform(new Point(0, 0));
               
                Ellipse kundenAlsKreis = new Ellipse
                {
                    Width = 10,
                    Height = 10,
                    Fill = Brushes.Black                                                       
                };
                canvas.Children.Add(kundenAlsKreis);
                Canvas.SetTop(kundenAlsKreis, relativePoint.Y);
                Canvas.SetLeft(kundenAlsKreis, relativePoint.X);
               
            }
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            Point relativePoint = gangbei[0].TransformToAncestor(Application.Current.MainWindow).Transform(new Point(0, 0));
            
            DoubleAnimation x = new DoubleAnimation();
            DoubleAnimation y = new DoubleAnimation();
            x.From = 40;
            x.To = relativePoint.X;
            y.To = relativePoint.Y;
            x.Duration = TimeSpan.Parse("0:0:2");
            y.Duration = TimeSpan.Parse("0:0:2");
            x.Completed += X_Completed;
            kunde.BeginAnimation(Canvas.TopProperty, y);
            kunde.BeginAnimation(Canvas.LeftProperty, x);
           



        }

        private void X_Completed(object sender, EventArgs e)
        {
           // MessageBox.Show("jetzt sollte ich in den gang gehen ");
            DoubleAnimation x = new DoubleAnimation();
            x.By =canvas.Width; //  Double.Parse(Verkauf.Children[1].GetValue(WidthProperty).ToString());
            x.Duration = TimeSpan.Parse("0:0:3");
            x.AutoReverse = true;
            Point aufenthalt = kunde.TransformToAncestor(Application.Current.MainWindow).Transform(new Point(0, 0));
            if (aufenthalt.Y < Height)
            { x.Completed += X_Completed1; }
            else
            { MessageBox.Show("Einkauf abgeschlossen, Stehe an der Kasse "); }
            kunde.BeginAnimation(Canvas.LeftProperty, x);
        }

        private void X_Completed1(object sender, EventArgs e)
        {
            DoubleAnimation y = new DoubleAnimation();
            y.By = 90; //  Double.Parse(Verkauf.Children[1].GetValue(WidthProperty).ToString());
            y.Duration = TimeSpan.Parse("0:0:3");
           
            y.Completed += X_Completed;
            kunde.BeginAnimation(Canvas.TopProperty, y);

        }
    }
}
