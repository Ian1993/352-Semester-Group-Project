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
		public void accDatabase(string query, ref string[] data)
		{
			OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:..\\Warhammer.mdb");

			OleDbCommand cmd = new OleDbCommand(query, cn);
			cn.Open();
			OleDbDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				data[0] = reader[0].ToString(); // print TableID  arr[0],arr[1],arr[2],arr[3],arr[4],arr[5],arr[5],arr[6]
				data[1] = reader[1].ToString(); // print ClassID
				data[2] = reader[2].ToString(); // print UnitID
				data[3] = reader[3].ToString(); // print UnitName
				data[4] = reader[4].ToString(); // print IndexID
				data[5] = reader[5].ToString(); // print PointValue
				data[6] = reader[6].ToString(); // print Statline
			}
			//TextBox.Text = data;
			cn.Close();

			//return data;
		}
	}
}
