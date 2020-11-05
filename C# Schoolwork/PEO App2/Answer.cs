using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEO_App2
{
    internal class Answer
    {
        private string answer;

        public Answer(String question)
        {
            if (question.Equals("question1", StringComparison.OrdinalIgnoreCase))
            {
                answer = "answer1";
            }
            else if (question.Equals("question2", StringComparison.OrdinalIgnoreCase))
            {
                answer = "answer2";
            }
            else
            {
                answer = "N/A";
            }
        }
    }
}