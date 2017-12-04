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

using MySql.Data.MySqlClient;

namespace DbWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string dbconnectstring =
            "SERVER=dnmbc.c4vhtk9yfmbv.eu-central-1.rds.amazonaws.com;" +
                            "DATABASE=waren;" +
                            "UID=cbmnd;" +
                            "PASSWORD=dC!?5678;";
        public MainWindow()
        {
            InitializeComponent();
            MySqlConnection connection = new MySqlConnection(dbconnectstring);
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Waren";
            MySqlDataReader Reader;
            connection.Open();
            Reader = command.ExecuteReader(); // alle Treffer in Reader -- List<string>
            
            while (Reader.Read())
            {
                string row = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                { row += Reader.GetValue(i).ToString() + "\t"; }
                row += "\n";
                textBox.AppendText(row);
            }
            connection.Close();
        }

        
    }
}
