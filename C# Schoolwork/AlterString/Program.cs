using System;

namespace AlterString
{
    class Program
    {
        static void Main(string[] args)
        {
            string in1 = "abcd";
            string in2 = "a";
            string in3 = "xy";
            Console.WriteLine("Value 1: {0}\nValue 2: {1}\nValue 3: {2}", SwitchString(in1), SwitchString(in2), SwitchString(in3));
        }

        static string SwitchString(string input)
        {
            char beginChar;
            beginChar = input[0];
            if (input.Length >= 2)
                return input[input.Length - 1] + input.Substring(1, input.Length - 2) + beginChar;
            else
            {
                return input;
            }
        }
    }
}
