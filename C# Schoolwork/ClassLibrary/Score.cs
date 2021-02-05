using System;
using System.Diagnostics.CodeAnalysis;

namespace ClassLibrary
{
    public class Score : IComparable<Score>
    {
        //define attributes
        public string name { get; private set; }
        public int score { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="score"></param>
        public Score(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public int CompareTo(Score s)
        {
            return score.CompareTo(s.score);
        }
    }
}
