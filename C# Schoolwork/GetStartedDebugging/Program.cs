using System;

namespace GetStartedDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define Variables
            char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
            string name = "";
            int[] a = new int[10];

            //Define a for loop that iterates through the letters array
            for (int i = 0; i < letters.Length; i++)
            {
                //name gets the new letter from the array and builds the name
                name += letters[i];
                //track the number of times iterated through the loop
                a[i] = i + 1;
                //Display Results
                SendMessage(name, a[i]);
            }
            Console.ReadKey();
        }
        static void SendMessage(string name, int msg)
        {
            Console.WriteLine("Hello, " + name + "! Count to " + msg);
        }
    }
}
