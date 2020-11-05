using System.Collections.Generic;

namespace ListDemo
{
    internal class Lists : List<Student>
    {
        public Lists()
        {
            for (int i = 0; i < 10; i++)
            {
                this.Add(new Student());
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < this.Count; i++)
            {
                result += this[i].ToString() + "\n";
            }
            return result;
        }
    }
}