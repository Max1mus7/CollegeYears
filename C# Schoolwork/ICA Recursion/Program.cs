using System;

namespace ICA_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write(printNums(10));
            Console.WriteLine(printFib(10));
        }

        static string printNums(int n)
        {
            if(n==0)
            {
                return "";
            }
            return n + " " + printNums(n - 1);
        }

        static string printFib(int n)
        {
            
            if(n == 0)
            {
                return "";
            }

            return (n - 1) + (n + 1) + " " + printFib(n - 1);
        }
    }
}
