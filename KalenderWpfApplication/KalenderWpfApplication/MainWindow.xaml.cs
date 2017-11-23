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

namespace KalenderWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 1; i < 6; i++)
            {
                RowDefinition rd_april = new RowDefinition();
                rd_april.Height = new GridLength(40);
                RowDefinition rd_mai = new RowDefinition();
                rd_mai.Height = new GridLength(40);
                RowDefinition rd_jun = new RowDefinition();
                rd_jun.Height = new GridLength(40);
                
                AprilTage.RowDefinitions.Add(rd_april);
                MaiTage.RowDefinitions.Add(rd_mai);
                JunTage.RowDefinitions.Add(rd_jun);

            }
            for (int i = 1; i < 8; i++)
            {
                ColumnDefinition cd_april = new ColumnDefinition();
                cd_april.Width =  new GridLength(30);
                ColumnDefinition cd_mai = new ColumnDefinition();
                cd_mai.Width = new GridLength(30);
                ColumnDefinition cd_jun = new ColumnDefinition();
                cd_jun.Width = new GridLength(30);
                AprilTage.ColumnDefinitions.Add(cd_april);
                MaiTage.ColumnDefinitions.Add(cd_mai);
                JunTage.ColumnDefinitions.Add(cd_jun);

            }
            for (int i = 1; i <= 30; i++)
            { Label tag = new Label();
                Grid.SetColumn(tag, i % 7);
                Grid.SetRow(tag, (int)i / 7);
                tag.Content = i;
                AprilTage.Children.Add(tag);
          // nicht sofort möglich wegen Update GUI Prozess JunTage.Children.Add(tag);
            }
            


        }
    }
}
