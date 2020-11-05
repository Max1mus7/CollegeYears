using System;
using System.Collections.Generic;

namespace ListDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ListDemo();
            ListDemo2();
            // PrintUserList(new Lists());
        }

        private static void ArrayReview()
        {
            int[] integers = new int[3];

            for (int i = 0; i < integers.Length; i++)
            {
                integers[i] = i;
            }
            //for this to work, arrays must inherit from IList
            //
            {
                Print(integers);
            }
        }

        private static void ListDemo()
        {
            List<int> integers = new List<int>();
            //Console.WriteLine(Ïnit Count: " + integers.Count);
            //Console.WriteLine(Ïnit Capacity: " + integers.Capacity);
            for (int i = 0; i < 300; i++)
            {
                integers.Add(i);
                //Console.WriteLine("Count: " + integers.Count);
                //Console.WriteLine("Capacity: " + integers.Capacity);
            }
            //List inherits from IList
            Print(integers);
        }

        private static void ListDemo2()
        {
            //initializer list
            List<int> Integers = new List<int>() { 5, 8, 9, 2, 44, -10 };

            //list of student objects
            List<Student> students = new List<Student>();

            //initializer list for objects can contain public properties
            students.Add(new Student() { ID = 8, Name = "Angela" });
            students.Add(new Student() { ID = 80, Name = "Fred" });
            students.Add(new Student() { ID = 8088, Name = "Joe" });

            PrintStudents(students);

            //list of student objects
            List<Student> students2 = new List<Student>() { new Student() { ID = 8, Name = "Angela" }, new Student() { ID = 80, Name = "Fred" }, new Student() { ID = 8088, Name = "Joe" } };

            students2.AddRange(students);

            PrintStudents(students2);

            students2.Insert(0, new Student() { ID = 4, Name = "Jim" });
            Console.WriteLine("---------------");
            PrintStudents(students2);
            Console.WriteLine("---------------");
            students2.RemoveAt(0);

            PrintStudents(students2);
        }

        private static void Print(IList<int> list)
        {
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

        private static void PrintStudents(IList<Student> list)
        {
            foreach (Student i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}