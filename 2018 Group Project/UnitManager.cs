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

        public unitManager()
        {

            //List<unit> temp = new List<unit>();
            UserList = new List<unit>();

            UnitCount = 0;
        }
        public void addUnit(string UnitID, string unitName)
        {
            var Chars = UnitID.ToCharArray();

            //Console.WriteLine(Chars[1] + " " + Chars[2] + " " + Chars[3] + " " + Chars[7]);

            //Console.Read();

            if (Chars[1] == '1')
            {
                Console.WriteLine("Infantry!");

                if (Chars[7] == '1')
                {
                    Console.WriteLine("SingleLine!");

                    UserList.Add(new Infantry(unitName, UnitCount));

                    //UserList.Insert(UnitCount, new Infantry());
                    UnitCount++;
                }
                else if (Chars[7] == '2')
                {
                    UserList.Add(new dualLine( unitName, UnitCount, new Infantry(unitName, UnitCount)));


                    //UserList.Insert(UnitCount, new dualLine(new Infantry()));

                    UnitCount++;
                }
            }

            else if (Chars[1] == '2')
            {
                UserList.Add(new Vehicle(unitName, UnitCount));

                Console.WriteLine("Vehicle");

                //UserList.Insert(UnitCount, new Vehicle());

                UnitCount++;
            }

            else if (Chars[1] == '3')
            {
                UserList.Add(new Walker(unitName, UnitCount));

                Console.WriteLine("Walker");

                //UserList.Insert(UnitCount, new Walker());

                UnitCount++;
            }
            /*
            for(int x = 0; x < UnitCount; x++)
            {
                Console.WriteLine("PrintLoop");
                UserList[x].print();
            }
            */

            //Console.Read();

        }

        public void printArmy()
        {

            for (int x = 0; x < UnitCount; x++)
            {
                //Console.WriteLine("PrintArmy");
                UserList[x].print();
            }

        }

        public void printUnit(string listindex)
        {
            int x = Convert.ToInt32(listindex);

            Console.WriteLine("PrintUnit");
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
            //Console.WriteLine("PrintArmy");
            
            

        }




    }

    abstract class unit
    {
        protected string name;

        //protected string name2;

        //protected string name3;

        //protected int statline;

        //protected int unitID;

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
        public Infantry(string unitName, int index) : base()
        {
            name = unitName;

            unitIndex = index;
        }

        public override void print()
        {
            //Console.WriteLine("Infantry!");


            //user.TextUpdate(name);

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).TextBox.Text = (window as MainWindow).TextBox.Text + name + " " + unitIndex + "\n";
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

        public Vehicle(string unitName, int index) : base()
        {
            name = unitName;

            unitIndex = index;
        }

        public override void print()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).TextBox.Text = (window as MainWindow).TextBox.Text + name + " " + unitIndex + "\n";
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
        public Walker(string unitName, int index) : base()
        {
            name = unitName;

            unitIndex = index;
        }

        public override void print()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).TextBox.Text = (window as MainWindow).TextBox.Text + name + " " + unitIndex + "\n";
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
        
        
        public dualLine(string unitName, int index, Infantry user) :base()
        {
            name = unitName;

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
                    (window as MainWindow).TextBox.Text = (window as MainWindow).TextBox.Text + "\n";

                    (window as MainWindow).TextBox.Text = (window as MainWindow).TextBox.Text + name + " " + unitIndex + "\n";
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
