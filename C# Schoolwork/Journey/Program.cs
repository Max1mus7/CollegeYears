using System;
using System.Diagnostics.CodeAnalysis;

namespace Journey
{
    class Program
    {
        private static String indent = "";
        public static void TakeOneStep(int step)
        {
            Console.WriteLine("{0}Taking step {1}", indent, step);
        }
        public static void Travel(int start, int finish)
        {
            string oldIndent = indent;
            Console.WriteLine("{0}Starting travel from {1} to {2}", indent, start, finish);

            if(start < finish)
            {
                TakeOneStep(start);
                indent += "    ";
                Travel(start + 1, finish);
                indent = oldIndent;
            }
            Console.WriteLine("{0}Finishing travel from {1} to {2}",indent, start, finish);
        }

        static void Main(string[] args)
        {
            
            int start = 1;
            int finish = 4;
            Travel(start, finish);
        }
    }
}
