using System;

namespace InterviewQuestionPart4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number to get its factorial");
            //read a number from the user
            int number = Convert.ToInt32(Console.ReadLine());

            double factorial = Factorial(number);

            Console.WriteLine("The factorial of " + number + " is " + factorial);
        }

        public static double Factorial(int number)
        {
            //if(number == 0)
            //{
            //    return 1;
            //}

            //double factorial = 1;
            //for(int i = number; i >= 1; i--)
            //{
            //    factorial = factorial * i;
            //}
            //return factorial;

            if(number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
    }
}
