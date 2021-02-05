using System;
using BusinessLayer;

namespace PresentationLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input two numbers you would like to add.");
            Add add = new Add(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("The sum is {0}", add.Sum);
            
            Console.WriteLine("Please input two number you would like to subtract.");
            Subtract subtract = new Subtract(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("The difference is {0}", subtract.Difference);
        }
    }
}
