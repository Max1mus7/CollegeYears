using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public class Griffon : Animal, IFlyable, IRidable
    {
        public void Fly()
        {
            Console.WriteLine("The griffon is soaring through the skies!");
        }

        public void Ride()
        {
            Console.WriteLine("What a rush!");
        }
    }
}
