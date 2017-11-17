using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MehrFensterWpfApplication
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            for(int i = 0; i < 40; i++)
            {
                MainWindow w = new MainWindow();
             //   w.Background = new System.Windows.Media.SolidColorBrush(SystemColors.Yellow);
                w.Title = "Fenster " + i;
                w.Show();
            }
        }
    }
}
