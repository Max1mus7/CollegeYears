using System;
using System.Collections.Generic;
using System.Text;

namespace TextFileDataAccessDemo
{
    public class Person
    {
        //declare properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Url { get; set; }

        /// <summary>
        /// full-args constructor
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="url"></param>
        public Person(string firstname, string lastname, string url)
        {
            //initialize properties
            FirstName = firstname;
            LastName = lastname;
            Url = url;
        }

        /// <summary>
        /// no-args constructor
        /// </summary>
        public Person()
        {
            FirstName = "Invalid";
            LastName = "User";
            Url = "Entered";
        }

        /// <summary>
        /// overrides the ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", FirstName, LastName, Url);
        }
    }
}
