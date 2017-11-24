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
            /*
             foreach(var item in  myGrid.Children)
            {
                
                if(item is System.Windows.Controls.GroupBox)
                {
                    GroupBox   gb = item as GroupBox;
                    StackPanel sp = gb.Content as StackPanel;
                    foreach(var rb in sp.Children)
                    {
                        MessageBox.Show(rb.ToString());
                    }

                }
                
            } */
            
            CheckBox itsk = new CheckBox();
            itsk.Content = "ITSK";
            fachrichtungen.Children.Add(itsk);
            itsk.Click += any_CheckBox_Click;
            foreach(string item in berufeliste)
            {
                CheckBox rb = new CheckBox { Content = item };
                rb.Click += any_CheckBox_Click;
                fachrichtungen.Children.Add(rb);

            }



        }

        

        private void any_CheckBox_Click(object sender, RoutedEventArgs e)
        {
            auswertung.Content = " ";
            foreach (RadioButton item in geschlecht.Children)
            {
                if (item.IsChecked == true)
                {
                    // MessageBox.Show(item.ToString());
                    auswertung.Content += item.Content.ToString();
                }
            }

            auswertung.Content += ":";

            foreach (CheckBox item in fachrichtungen.Children)
            {
                if (item.IsChecked == true)
                {
                   // MessageBox.Show(item.ToString());
                    auswertung.Content += item.Content.ToString(); }
            }
        }

    }
}
