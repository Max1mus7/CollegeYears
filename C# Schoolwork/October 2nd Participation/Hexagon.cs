using System;
using System.Collections.Generic;
using System.Text;

namespace October_2nd_Participation
{
    class Hexagon : Shape
    {
        public Hexagon(string name) : base(name)
        { 
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);

        }
    }
}
