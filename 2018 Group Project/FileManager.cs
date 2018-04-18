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


namespace _2018_Group_Project
{
    class FileManager
    {
		public void accDatabase(string query)
		{
			OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Nicholas Reid\\source\\repos\\2018 Group Project\\Warhammer.mdb");
			string data = "";

			OleDbCommand cmd = new OleDbCommand(query, cn);
			cn.Open();
			OleDbDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				data += reader[0].ToString() + reader[1].ToString() + reader[2].ToString() + " " + reader[3].ToString() + " " + reader[4].ToString() + " " + reader[5].ToString() + " " + reader[6].ToString() + " " + reader[7].ToString() + " " + "\n";
			}
			//TextBox.Text = data;
			cn.Close();

			//return data;
		}
	}
}
