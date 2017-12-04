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

namespace WunschListeWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static double summe = 0;
        
        public MainWindow()
        {
            InitializeComponent();
            listbox.AddHandler(ListBox.MouseDownEvent, new MouseButtonEventHandler(ListBox_MouseDown), true);
        }

        private void ListBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
         //   MessageBox.Show("ausgewählt wurde : "+(listbox.SelectedItem as Things).preis );
            Things wunsch = listbox.SelectedItem as Things;
            DataObject data = new DataObject(wunsch);
            DragDrop.DoDragDrop(listbox, data, DragDropEffects.Copy);
                
        }

        private void Canvas_DragEnter(object sender, DragEventArgs e)
        {
            wunschzettel.Background = Brushes.DarkGoldenrod;
           ;
        }
        private void Canvas_DragLeave(object sender, DragEventArgs e)
        {
            wunschzettel.Background = Brushes.DarkKhaki;
        }

        private void wunschzettel_DragOver(object sender, DragEventArgs e)
        {
             int ele = wunschzettel.Children.Count;
        Things kopie = (Things)e.Data.GetData(typeof(Things));
          
            Point p = e.GetPosition(wunschzettel);
            label.Content = p.X.ToString() +" : "+ p.Y.ToString();
      
            ContentControl cc = new ContentControl();
            cc.Content = kopie;
            Canvas.SetLeft(cc, p.X);
            Canvas.SetTop(cc, p.Y);
            wunschzettel.Children.Add(cc);
            if(wunschzettel.Children.Count > 1)
            wunschzettel.Children.RemoveAt(ele-1);

        }

        private void wunschzettel_Drop(object sender, DragEventArgs e)
        {
         
            Things kopie = (Things)e.Data.GetData(typeof(Things));
         //   Canvas canvas = e.Source as Canvas;
            Point p = e.GetPosition(wunschzettel);     // wo ist die Maus beim Drop

            ContentControl cc = new ContentControl();
            cc.Content = kopie;

            Canvas.SetLeft(cc, p.X);
            Canvas.SetTop(cc,  p.Y);
            wunschzettel.Children.Add(cc);
            summe += kopie.preis;
            label.Content = summe;



        } 
    }
}
