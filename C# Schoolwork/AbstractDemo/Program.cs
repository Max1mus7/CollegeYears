using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///This is the main program
            ///</summary>
            ///<example>
            ///This is sample code how to call this method
            ///<code>
            ///SQLiteDataAccess sqDataAccess = new SQLiteDataAccess();
            ///</code>
            ///</example>

            SQLiteDataAccess sqDataAccess = new SQLiteDataAccess();
            
            
            //List<IDataAccess> databases = new List<IDataAccess>()
            //{
            //    //Create a new instance of each class
            //    new SQLDataAccess(), 
            //    new SQLiteDataAccess()
            //};

            //foreach(var db in databases)
            //{
            //    db.LoadConnectionString("demo");
            //    db.LoadData("select * from table");
            //    db.SaveData("insert into table");
            //    Console.WriteLine();
            //}


            Console.ReadKey();
        }
    }
}
