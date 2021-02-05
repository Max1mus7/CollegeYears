
using System;

namespace Participation_Wk_11
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10 ; i++)
            {
                for(int j = 1; j <= 8; j++)
                {
                    Console.Write("{0}x{1} = {2}   ",j, i, i*j);
                }
                Console.WriteLine();
            }
        }
    }
}
