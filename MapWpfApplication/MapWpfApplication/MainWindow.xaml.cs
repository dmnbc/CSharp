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
using static System.Math;

namespace MapWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Point> koord = new List<Point>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Markierung setzen
            Ellipse marke = new Ellipse
            {
                Width = 20,
                Height = 20,
                Fill = Brushes.Black,
                Margin = new Thickness(e.GetPosition(Application.Current.MainWindow).X,
                e.GetPosition(Application.Current.MainWindow).Y, 0, 0)
            };
            grid.Children.Add(marke);
            koord.Add(e.GetPosition(Application.Current.MainWindow));
            if(koord.Count > 2)
            {
                double entfernung=0;
                for (int i = 1; i < koord.Count; i++)
                {
                    Line l = new Line
                    {
                        X1 = Math.Abs(koord[i - 1].X),
                        X2 = Math.Abs(koord[i].X),
                        Y1 = Math.Abs(koord[i - 1].Y),
                        Y2 = Math.Abs(koord[i].Y),
                        Stroke = Brushes.Yellow,
                        StrokeThickness = 4
                    };
                    grid.Children.Add(l);
                    entfernung += Math.Sqrt(Math.Pow(Math.Abs(koord[i - 1].X - koord[i].X), 2)
                                       + Math.Pow(Math.Abs(koord[i - 1].Y - koord[i].Y), 2));
                }
                MessageBox.Show(entfernung.ToString());
                
            }

        }
    }
}
