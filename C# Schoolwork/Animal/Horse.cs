using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public class Horse : Animal, IRidable
    {
        public void Ride()
        {
            Console.WriteLine("Clip, clop, clip, clop");
        }
    }
}
