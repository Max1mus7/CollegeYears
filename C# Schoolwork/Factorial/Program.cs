using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = 6;
            Console.WriteLine(Factorial(startingNumber));
            Console.ReadKey();
        }

        static int Factorial(int x)
        {
            Console.WriteLine("x is {0}", x);
            if(x==1)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
    }
}
