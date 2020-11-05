using System;

namespace October_2nd_Participation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Polymorphism *****\n");

            ThreeDCircle o = new ThreeDCircle();
            o.Draw();

            ((Circle)o).Draw();
            Console.ReadKey();
        }
    }
}
