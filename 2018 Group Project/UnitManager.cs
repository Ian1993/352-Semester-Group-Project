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


namespace _2018_Group_Project
{
    class unitManager
    {



        private List<unit> UserList;



        private int UnitCount;
        private int ptval;
        private int ptkeeper;
        private FileManager dataman;
        static private int size = 8;
        public string[] arr = new string[size];
        public string[] arr1 = new string[size];
        string query;

        public unitManager(int pts)
        {

            //List<unit> temp = new List<unit>();
            UserList = new List<unit>();
            ptval = pts;
            ptkeeper = pts;
            dataman = new FileManager();
            
            

            UnitCount = 0;
        }
        public void addUnit(string UnitID)
        {
            var Chars = UnitID.ToCharArray();

			readDB(UnitID);

            if (Chars[1] == '1')
            {
                

                if (Chars[7] == '1')
                {
                   

                    UserList.Add(new Infantry(arr[3], arr[4], arr[5], arr[6], UnitCount));

                    
                    UnitCount++;
                }
                else if (Chars[7] == '2')
                {
                    UserList.Add(new dualLine(arr[3], arr[4], arr[5], arr[6], UnitCount, new Infantry(arr[3], arr[4], arr[5], arr[6], UnitCount)));


                    

                    UnitCount++;
                }
            }

            else if (Chars[1] == '2')
            {
                UserList.Add(new Vehicle(arr[3], arr[4], arr[5], arr[6], UnitCount));

                

               

                UnitCount++;
            }

            else if (Chars[1] == '3')
            {
                UserList.Add(new Walker(arr[3], arr[4], arr[5], arr[6], UnitCount));

               

                

                UnitCount++;
             }
            

        }


        public void readDB(string UnitID)
        {
            var Chars = UnitID.ToCharArray();

			
        
            if (Chars[1] == '1')
            {


                if (Chars[7] == '1')
                {
                    query = "SELECT * FROM Infantry Where UnitID = " + "'" + Chars[4] + Chars[5] + Chars[6] + Chars[7] + "'";

                    


                    
                }
                else if (Chars[7] == '2')
                {
                    query = "SELECT * FROM Infantry Where UnitID = " + "'" + Chars[4] + Chars[5] + Chars[6] + Chars[7] + "'";
                    Chars[7] = '1';
                    readDB(Convert.ToString(Chars));

                }
            }

            else if (Chars[1] == '2')
            {
                query = "SELECT * FROM Vehicle Where UnitID = " + "'" + Chars[4] + Chars[5] + Chars[6] + Chars[7] + "'";
            }

            else if (Chars[1] == '3')
            {
                query = "SELECT * FROM Walker Where UnitID = " + "'" + Chars[4] + Chars[5] + Chars[6] + Chars[7] + "'";
            }

            dataman.accDatabase(query, ref arr);

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).UnitDisplay.Text = " ";
                    (window as MainWindow).UnitDisplay.Text = (window as MainWindow).UnitDisplay.Text + arr[3] + "\n";
                    (window as MainWindow).UnitDisplay.Text = (window as MainWindow).UnitDisplay.Text + arr[4] + " " + arr[5] + "\n";
                    (window as MainWindow).UnitDisplay.Text = (window as MainWindow).UnitDisplay.Text + arr[6] + "\n";
                }
            }


        }

        public void printArmy()
        {

            for (int x = 0; x < UnitCount; x++)
            {

				UserList[x].print();
				
            }

        }

        public void printUnit(string listindex)
        {
            int x = Convert.ToInt32(listindex);

            
            UserList[x].print();

        }

        public void removeUnit(string listindex)
        {
            int x = Convert.ToInt32(listindex);
            UserList.RemoveAt(x);
            UnitCount--;

            for( int y = 0; y < UnitCount; y++)
            {
                UserList[y].IndexUpdate(y);
            }
        }

        public void saveArmy()
        {

            DateTime dateOnly = new DateTime();
            string part1 = "Your Army List for 7th Edition The Horus Heresy";
            string part2 = "Made on the date: ";
            string part3 = "Your List is made up of: " + UnitCount + " units, for a total of: " + ptval + " points" ;
            string part4 = dateOnly.ToString("d");

            string text = part1 + System.Environment.NewLine + part2 + part4 + part3 + System.Environment.NewLine;
                    
            
            System.IO.File.WriteAllText(@"Warhammer 40k Army List.txt", text);


            for (int x = 0; x < UnitCount; x++)
            {

                UserList[x].save();   
            }
            
            
            

        }




    }



    abstract class unit
    {
        protected string name;  //name,bookindex,pointvalue,statline

        protected string pointvalue;

        protected string bookindex;

        protected string statline;

        protected string unitID;

        protected int unitIndex;

        protected Infantry Store;

        public unit()
        {



        }

        public abstract void print();

        public abstract void save();

        public abstract void ReadIn(string name, string statline, int unitID, int unitIndex);

        public abstract void IndexUpdate(int x);





    }

    class Infantry : unit
    {
        public Infantry(string unitName,string bookindex1,string pointvalue1,string statline1, int index) : base()
        {
            name = unitName;

            bookindex = bookindex1;

            pointvalue = pointvalue1;

            statline = statline1;

            unitIndex = index;
        }

        public override void print()
        {
            

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).TextBox.Text = (window as MainWindow).TextBox.Text + unitIndex + " " + name + "\n";
                    (window as MainWindow).TextBox.Text = (window as MainWindow).TextBox.Text + bookindex + " " + statline + "\n";
                    (window as MainWindow).TextBox.Text = (window as MainWindow).TextBox.Text + pointvalue + "\n";
                }
            }




        }

        public override void save()
        {
            using (System.IO.StreamWriter file =
               new System.IO.StreamWriter(@"Warhammer 40k Army List.txt", true))
            {
                file.WriteLine(unitIndex + " " + name);
            }
        }

        public override void ReadIn(string name, string statline, int unitID, int unitIndex)
        {

        }

        public override void IndexUpdate(int x)
        {
            unitIndex = x;
        }
    }

    class Vehicle : unit
    {

        public Vehicle(string unitName, string bookindex1, string pointvalue1, string statline1, int index) : base()
        {
            name = unitName;

            bookindex = bookindex1;

            pointvalue = pointvalue1;

            statline = statline1;

            unitIndex = index;
        }

        public override void print()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).TextBox.Text = (window as MainWindow).TextBox.Text + unitIndex + " " + name + "\n";
                    (window as MainWindow).TextBox.Text = (window as MainWindow).TextBox.Text + bookindex + " " + statline + "\n";
                    (window as MainWindow).TextBox.Text = (window as MainWindow).TextBox.Text + pointvalue + "\n";
                }
            }
        }

        public override void save()
        {
            using (System.IO.StreamWriter file =
               new System.IO.StreamWriter(@"Warhammer 40k Army List.txt", true))
            {
                file.WriteLine(unitIndex + " " + name );
            }
        }

        public override void ReadIn(string name, string statline, int unitID, int unitIndex)
        {

        }

        public override void IndexUpdate(int x)
        {
            unitIndex = x;
        }
    }

    class Walker : unit
    {
        public Walker(string unitName, string bookindex1, string pointvalue1, string statline1, int index) : base()
        {
            name = unitName;

            unitIndex = index; name = unitName;

            bookindex = bookindex1;

            pointvalue = pointvalue1;

            statline = statline1;

            unitIndex = index;
        }

        public override void print()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).TextBox.Text = (window as MainWindow).TextBox.Text + unitIndex + " " + name + "\n";
                    (window as MainWindow).TextBox.Text = (window as MainWindow).TextBox.Text + bookindex + " " + statline + "\n";
                    (window as MainWindow).TextBox.Text = (window as MainWindow).TextBox.Text + pointvalue + "\n";
                }
            }
        }

        public override void save()
        {
            using (System.IO.StreamWriter file =
               new System.IO.StreamWriter(@"Warhammer 40k Army List.txt", true))
            {
                file.WriteLine(unitIndex + " " + name);
            }
        }

        public override void ReadIn(string name, string statline, int unitID, int unitIndex)
        {
            
        }

        public override void IndexUpdate(int x)
        {
            unitIndex = x;
        }

    }
    
    class dualLine : unit
    {
        
        
        public dualLine(string unitName, string bookindex1, string pointvalue1, string statline1, int index, Infantry user) :base()
        {
            name = unitName;

            bookindex = bookindex1;

            pointvalue = pointvalue1;

            statline = statline1;

            unitIndex = index;

            Store = user;
        }

        public override void ReadIn(string name, string statline, int unitID, int unitIndex)
        {

        }

        public override void IndexUpdate(int x)
        {
            
        }

        public override void print()
        {
            Store.print();

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).TextBox.Text = (window as MainWindow).TextBox.Text + unitIndex + " " + name + "\n";
                    (window as MainWindow).TextBox.Text = (window as MainWindow).TextBox.Text + bookindex + " " + statline + "\n";
                    (window as MainWindow).TextBox.Text = (window as MainWindow).TextBox.Text + pointvalue + "\n";
                }
            }
        }
        public override void save()
        {
            Store.save();

            using (System.IO.StreamWriter file =
               new System.IO.StreamWriter(@"Warhammer 40k Army List.txt", true))
            {
                file.WriteLine( name);
            }
        }

    }
    
}
