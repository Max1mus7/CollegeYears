using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public class Mosquito : Animal, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("What's that buzzing sound?");
        }
    }
}
