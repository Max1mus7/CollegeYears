using System;

namespace DemoLibrary
{
    public class SQLiteDataAccess : DataAccess
    {
        //public string LoadConnectionString(string name)
        //{
        //    Console.WriteLine("Load Connection String");
        //    return "testConnectionString";
        //}

        public void LoadData(string sql)
        {
            Console.WriteLine("Loading SQLite data");
        }

        public void SaveData(string sql)
        {
            Console.WriteLine("Saving data to SQLite");
        }
    }
}
