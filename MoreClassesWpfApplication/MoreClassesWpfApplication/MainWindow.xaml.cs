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

namespace MoreClassesWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for(int i= 0; i < 64; i++)
            {
                Label label = new Label();
                Raster.Children.Add(label);  // kann nur call by reference sein 
                label.Name = "label" + i;
             //   label.Content = label.Name;
                Binding binding = new Binding("Name");
                binding.Source = label; //binden an das objekt, wo ich abhole
                label.SetBinding(Label.ContentProperty, binding);
               
                label.MouseDown += label_clicked;

            }
        }

        private void label_clicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("geklickt registriert");
        }
    }
}
