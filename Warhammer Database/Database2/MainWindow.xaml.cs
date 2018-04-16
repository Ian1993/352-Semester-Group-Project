using System;
using System.Collections.Generic;
using System.Data.OleDb;
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

namespace Database2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Nicholas Reid\\source\\repos\\Database2\\Database2\\Warhammer.mdb");
        string data = "";
        private void Infantry_Click(object sender, RoutedEventArgs e)
        {
            string query = "SELECT * FROM Infantry";
            int x = 3;
            int y = 0;
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();

            //string test = "3501";

            if (x == 0)
            {
                while (reader.Read())
                {
                    data += reader[0].ToString() + "/n";
                }
            }
            
            else if (x == 7)
            {
                while (reader.Read())
                {
                    data += reader[0].ToString() + reader[1].ToString() + reader[2].ToString() + " " + reader[3].ToString() + " " + reader[4].ToString() + " " + reader[5].ToString() + " " + reader[6].ToString() + " " + reader[7].ToString() + " " + "\n";
                }
            }

            TextBox.Text = data;
            cn.Close();
        }

        private void Vehicle_Click(object sender, RoutedEventArgs e)
        {
            //string query = "SELECT UnitName FROM Vehicles";
            /*OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                data += reader[0].ToString() + "\n";
            }
            TextBox.Text = data;
            cn.Close();*/
        }

        private void Walker_Click(object sender, RoutedEventArgs e)
        {
            //string query = "SELECT UnitName FROM Walkers";
            /*OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                data += reader[0].ToString() + "\n";
            }
            TextBox.Text = data;
            cn.Close();*/
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string query = "SELECT * FROM ID";
            /*OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                data += reader[0].ToString() + "\n";
            }
            TextBox.Text = data;
            cn.Close();*/
        }
        /*private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox.Text = data;
        }*/
    }

    public class database
    {
        public string accDatabase (string query)
        {
            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Nicholas Reid\\source\\repos\\Database2\\Database2\\Warhammer.mdb");
            string data = "";

            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                data += reader[0].ToString() + "\n";
            }
            //TextBox.Text = data;
            cn.Close();

            return "01";
        }
    }
}
