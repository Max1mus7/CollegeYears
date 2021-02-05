using System;

namespace InClassExercise_Nov_11
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string userIn;
            int charRemove;
            Console.WriteLine("Please input a string to have a character removed from it!");
            userIn = Console.ReadLine();
            Console.WriteLine("Please input which character you would like to remove.");
            charRemove = int.Parse(Console.ReadLine());

            Console.WriteLine(userIn.Substring(0, charRemove) + userIn.Substring(charRemove+1));
        }
    }
}
