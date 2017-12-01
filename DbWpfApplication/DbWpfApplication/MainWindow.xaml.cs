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
            "SERVER=localhost;" +
                            "DATABASE=bank;" +
                            "UID=root;" +
                            "PASSWORD=;";
        public MainWindow()
        {
            InitializeComponent();
            MySqlConnection connection = new MySqlConnection(dbconnectstring);
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM kontoinhaber";
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
