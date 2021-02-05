using System;

namespace BusinessLayer
{
    public class Add
    {
        public int Sum { get; private set; }

        public Add(int num1, int num2)
        {
            Sum = num1 + num2;
        }
    }
}
