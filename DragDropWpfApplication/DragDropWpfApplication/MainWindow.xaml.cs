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

namespace DragDropWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for(int i = 0; i < 64;i++)
            {
                Label l = new Label
                {
                    Content = i
                };
                spielfeld.Children.Add(l);
            }
        }

        private void spielfeld_DragOver(object sender, DragEventArgs e)
        {

        }

        private void spielfeld_DragEnter(object sender, DragEventArgs e)
        {
            MessageBox.Show("DragEnter:" + sender.ToString());
        }
    }
}
