using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public abstract class DataAccess 
    {
        /// <summary>
        /// Loads a connection string for Database
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Returns a string</returns>
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "testConnectionString";
        }

    }
}
