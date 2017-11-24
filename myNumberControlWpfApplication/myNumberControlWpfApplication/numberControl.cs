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

namespace myNumberControlWpfApplication
{
    class NumberControl
    {
        public static Label numberDisplay = new Label();
        public static Grid numAndButtons = new Grid();
        public NumberControl()
        {
            numberDisplay.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            numberDisplay.Content = 0;

            numAndButtons.Height = 36;
            numAndButtons.ShowGridLines = true;

        }

        public StackPanel numberControlShow()
        {
            StackPanel numberControl = new StackPanel();
            numberControl.Margin = new Thickness(3);
            numberControl.HorizontalAlignment = HorizontalAlignment.Left;

            numAndButtons.Children.Add(numberDisplay);

            numberControl.Children.Add(numAndButtons);


            
           

            return numberControl;
        }


        /*
         <StackPanel>
            <Border Margin="2" HorizontalAlignment="Left" BorderThickness="2" BorderBrush="Red">
                <Grid Height="36">
                    <Grid.RowDefinitions>
                        <RowDefinition />
                        <RowDefinition />
                    </Grid.RowDefinitions>
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="40"/>
                        <ColumnDefinition />
                    </Grid.ColumnDefinitions>
                    <Label Name="numberDisplay" Grid.RowSpan="2" Content="0" VerticalAlignment="Center" HorizontalAlignment="Right"/>
                    <RepeatButton Grid.Column="1" Click="RepeatButtonPlus_Click">+</RepeatButton>
                    <RepeatButton Grid.Column="1" Grid.Row="1" Click="RepeatButtonMinus_Click">-</RepeatButton>
                </Grid>
            </Border>
        </StackPanel> */

        private void RepeatButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            numberDisplay.Content = Convert.ToInt32(numberDisplay.Content.ToString()) + 1;
        }
        private void RepeatButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            numberDisplay.Content = Convert.ToInt32(numberDisplay.Content.ToString()) - 1;
        }
    }
}
