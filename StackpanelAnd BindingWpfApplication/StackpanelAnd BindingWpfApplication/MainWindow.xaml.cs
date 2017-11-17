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

namespace StackpanelAnd_BindingWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Binding in C#
            // Text="{Binding ElementName=obere, Path=Text, }"
            Binding kopieren = new Binding("Text");
            kopieren.Source = obere;
            untere.SetBinding(TextBox.TextProperty, kopieren );
            // nochoffen: wie kann man den gebundenen Inhalt verändern

        }
    }
}
