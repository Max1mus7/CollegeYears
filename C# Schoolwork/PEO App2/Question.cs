using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEO_App2
{
    internal class Questions : List<String>
    {
        public Questions()
        {
            Randomize(40);
        }

        public void Randomize(int qNum)
        {
            for (int i = 0; i < qNum; i++)
            {
                Random random = new Random();
                int r = random.Next(0, 40);
                this.Add(questions[r]);
            }
        }

        private String[] questions = new String[] { };
    }
}