using System;
using System.Collections.Generic;
using System.Text;

namespace October_2nd_Participation
{
    class ThreeDCircle : Circle
    {
        public new string PetName { get; set; }

        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }

    }
}
