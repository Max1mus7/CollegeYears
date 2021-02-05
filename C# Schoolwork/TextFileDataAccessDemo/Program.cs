using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TextFileDataAccessDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"..\test.txt";
            List<Person> people = new List<Person>();
            List<string> lines = File.ReadAllLines(filePath).ToList();
            
            foreach(string line in lines)
            {
                string[] entries = line.Split(",");
                if(entries.Length == 3)
                {
                    Person p = new Person();
                    p.FirstName = entries[0];
                    p.LastName = entries[1];
                    p.Url = entries[2];

                    people.Add(p);
                }
                else
                {
                    Console.WriteLine("Invalid Person.");
                }
                
            }
            List<string> outputLines = new List<string>();

            Console.WriteLine("Here is the list of people that I have:");
            foreach(Person person in people)
            {
                string output = string.Format("First Name: {0}  Last Name: {1}  URL: {2}", person.FirstName, person.LastName, person.Url);
                Console.WriteLine(output);
                outputLines.Add(output);
            }

            File.WriteAllLines(@"..\peopleOut.txt", outputLines);
            Console.ReadKey();
        }
    }
}
