using System;
using System.Linq;
using System.Collections;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //make some test scores
            int[] scores = new[] { 50, 66, 90, 91, 77, 45, 0, 100, 99, 72, 87, 85, 81, 80, 77, 74, 95, 97 };
            foreach(int num in scores)
            {
                Console.WriteLine("One of the scores was {0}", num);
            }
            
            //select A students
            var theBestStudents =
                from individualScore in scores
                where individualScore > 90
                select individualScore;
            //display A students
            foreach(var score in theBestStudents)
            {
                Console.WriteLine("One of the best scores was {0}", score);
            }

            //select sorted scores
            var sortedScores =
                from individualScore in scores
                orderby individualScore descending
                select individualScore;
            //display sorted scores
            foreach (var score in sortedScores)
            {
                Console.WriteLine("One of the scores was {0}", score);
            }

            //select B students
            var bStudents =
                from individualScore in scores
                where individualScore > 79 && individualScore < 90
                orderby individualScore ascending
                select individualScore;
            //display B students
            foreach(var score in bStudents)
            {
                Console.WriteLine("One of the B scores was {0}",score);
            }

            //create an ArrayList and fill with Student objects
            ArrayList students = new ArrayList();
            students.Add(new Student("Max", 19, 86));
            students.Add(new Student("Kayla", 19, 90));
            students.Add(new Student("Ivy", 19, 92));
            students.Add(new Student("Randi", 19, 94));
            students.Add(new Student("Patrick", 19, 90));

            //select students of type Student
            var studentList =
                from Student individualStudent in students
                orderby individualStudent.Grade descending
                select new { name = individualStudent.Name, age = individualStudent.Age, grade = individualStudent.Grade };
            //display students of type Student
            foreach (var student in studentList)
            {
                Console.WriteLine("One of the students is named {0}, is {1} years old, and has a grade of {2}", student.name, student.age, student.grade);
            }
            Console.ReadKey();
        }
    }
}
