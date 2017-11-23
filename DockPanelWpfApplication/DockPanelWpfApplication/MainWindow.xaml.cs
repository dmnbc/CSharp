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

namespace DockPanelWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button newbtn = new Button
            {
                Content = "der siebte",
                Width = 600
            };
            Dock.Children[0].SetCurrentValue(ContentProperty, "neuer Content");
            Dock.Children[0].SetCurrentValue(DockPanel.DockProperty, System.Windows.Controls.Dock.Top);
            Dock.Children.Add(newbtn);

        }
    }
}
