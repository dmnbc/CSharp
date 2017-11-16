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

namespace RaumGridWpfApplication
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hast mich");
        }

        private void heute(object sender, MouseEventArgs e)
        {
            btn_ok.Background = Brushes.Crimson;
            MessageBox.Show("Heute ist der " + DateTime.Now.ToShortDateString());
        }

       

        private void Calendar_MouseLeave(object sender, MouseEventArgs e)
        {
            text_blox.Background = Brushes.Chocolate;
                MessageBox.Show("wieder draussen");
            
        }
    }
}
