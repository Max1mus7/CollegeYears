using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public class Robin : Animal
    {
        public virtual void Sing()
        {
            Console.WriteLine("Chirp Chirp");
        }
    }
}
