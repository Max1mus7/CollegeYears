using System;

namespace Multidimensional_Array_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array2D = new string[3, 2]
            {
                {"one", "two"},
                {"three", "four"},
                {"five", "six" },
            };
            //prints out the array and creates a space after it
            Console.WriteLine(array2D[0, 0]);
            Console.WriteLine(array2D[0, 1]);
            Console.WriteLine(array2D[1, 0]);
            Console.WriteLine(array2D[1, 1]);
            Console.WriteLine(array2D[2, 0]);
            Console.WriteLine(array2D[2, 1] + "\n");

            //iterates through and prints out the array again using for loops
            for(int i = 0; i < array2D.GetLength(0); i++)
            {
                for(int j = 0; j < array2D.GetLength(1); j++)
                {
                    string s = array2D[i, j];
                    Console.WriteLine(s);
                }
            }
            
            //creates two spaces after the previous output

            Console.WriteLine("\n");
            
            //this example assigns a value to a particular element of the array
            int x = 2, y = 0;
            array2D[x, y] = "orange";

            //iterates through and prints out the array again using for loops
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    string s = array2D[i, j];
                    Console.WriteLine(s);
                }
            }
        }
    }
}
