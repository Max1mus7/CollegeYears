using System;

namespace Lyrical_Genius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a bad word: ");
            string part1 = Console.ReadLine();
            Console.Write("Enter a celebrity: ");
            string part2 = Console.ReadLine();
            Console.Write("Enter a Nickname: ");
            string part3 = Console.ReadLine();
            Console.Write("Enter a noun: ");
            string part4 = Console.ReadLine();
            Console.Write("Enter another noun: ");
            string part5 = Console.ReadLine();
            Console.Write("Enter an adjective: ");
            string part6 = Console.ReadLine();
            Console.Write("Enter another celebrity: ");
            string part7 = Console.ReadLine();
            Console.WriteLine("I need a bad " + part1 + " \nuhhh " + part2 + " \nlil " + part3 + " the baddest\nyeah and she got her " + part4 +
                "\n so these " + part5 + " are obviously\nvery " + part6 + " to me\nbecause I am " + part7 + "!!");
        }
    }
}
