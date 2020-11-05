using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class SQLDataAccess : DataAccess
    {
        //public string LoadConnectionString(string name)
        //{
        //    Console.WriteLine("Load Connection String");
        //    return "testConnectionString";
        //}

        /// <summary>
        /// Load data into database
        /// </summary>
        /// <param name="sql"></param>
        public void LoadData(string sql)
        {
            Console.WriteLine("Loading Microsoft SQL data");
        }

        public void SaveData(string sql)
        {
            Console.WriteLine("Saving data to Microsoft SQL");
        }
    }
}
