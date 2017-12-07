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

namespace BindingCodeBehindWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string myValue;

        public string MyValue
        {
            set { myValue = value; textBox.Text = value; }
            get {return myValue; }
        }

        private static int myMwSt;

        public int MyMwST
        {
            set { myMwSt = value; textBox.Text = value.ToString(); }
            get { return myMwSt; }

        }



        public MainWindow()
        {
           
           // MessageBox.Show(s.Length.ToString());
            InitializeComponent();
            MyValue = "ich bin der neue Value";
            MessageBox.Show(" ");
            MyValue = "ich bin der nächste Value";
            MyMwST = 22;
        }
    }
}
