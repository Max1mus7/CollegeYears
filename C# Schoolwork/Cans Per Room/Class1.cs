using System;
using System.Collections.Generic;
using System.Text;

namespace Cans_Per_Room
{
    public class Class1
    {
        int total = 0;
        public int CansPerRoom(int rooms)
        {
            while (rooms > 0)
            {
                total += rooms;
                return CansPerRoom(rooms - 1);
            }
            return total;
        }
    }
}
