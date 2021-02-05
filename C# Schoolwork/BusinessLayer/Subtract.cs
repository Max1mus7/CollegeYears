using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Subtract
    {
        public int Difference { get; set; }

        public Subtract(int num1, int num2)
        {
            Difference = num1 - num2;
        }
    }
}
