using System;

namespace Wk_10_Participation
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] arr = { { 3, 7, 3.5, 4 }, 
                              { 4, 3.7, 1.3, 9.3 }, 
                              { 1.2, 5, 6, 7.8 } };
            double sum = 0;
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    sum += arr[j, i];
                }
                Console.WriteLine("The sum of column {0} is {1}",i,sum);
                sum = 0;
            }
        }
    }
}
