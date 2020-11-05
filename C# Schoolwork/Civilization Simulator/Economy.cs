using System;
using System.Data;

namespace Civilization_Simulator
{
    public class Economy
    {
        int EconomyType { get; set; }
        string EconomyName { get; set; }
        //capitalism, socialism, communism

        public Economy(int et)
        {
            EconomyType = et;
            if (EconomyType == 0)
            {
                EconomyName = "Capitalism";
            }
            else if (EconomyType == 1)
            {
                EconomyName = "Socialism";
            }
            else if (EconomyType == 2)
            {
                EconomyName = "Communism";
            }
            else
            {
                Console.WriteLine(new InvalidConstraintException("Invalid Economic Type expected"));
            }
        }
    }
}
