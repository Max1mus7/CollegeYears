using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LINQDemo
{
    public class Student : IComparable<Student>
    {
        //declare properties
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="grade"></param>
        public Student(string name, int age, int grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
        
        /// <summary>
        /// Allows for the comparison of Student objects
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Student other)
        {
            return this.Grade.CompareTo(other.Grade);
        }
    }
}
