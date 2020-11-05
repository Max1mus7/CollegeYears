using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ListDemo
{
    internal class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public int CompareTo([AllowNull] Student other)
        {
            if (other.ID < ID)
            {
                return -1;
            }
            else if (other.ID == ID)
            {
                return 0;
            }
            else
                return 1;
        }

        public override string ToString()
        {
            return "Name:\t" + Name + "\nID:\t" + ID;
        }
    }
}