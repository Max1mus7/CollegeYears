using System;

namespace Recursive_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            //make an array
            int[] arr = new int[100];
            
            //populate the array
            Random rnd = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(60);
            }

            //initialize and instantiate a target number
            int target = rnd.Next(60);

            //print target
            Console.WriteLine("Recursively looking for {0}", target);

            int index = RecursiveSearch(arr, target, 0);

            if(index == -1)
            {
                Console.WriteLine("{0} is not in the array", target);
            }
            else
            {
                Console.WriteLine("{0} is located at index {1}", target, index);
            }

        }

        static int RecursiveSearch(int[] srchArr, int target, int firstIndex)
        {
            Console.WriteLine("Searching from [{0}] to [{1}]...", firstIndex, srchArr.Length - 1);
            if (firstIndex == srchArr.Length)
            {
                return -1;
            }
            else if(srchArr[firstIndex] == target)
            {
                return firstIndex;
            }
            else
            {
                return RecursiveSearch(srchArr, target, ++firstIndex);
            }
        }
    }
}
