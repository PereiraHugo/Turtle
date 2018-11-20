using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Turtle
{
    // Global Definition of the system.
    public class L_System
    {

        public List<string> Symbols { get; set; }
        public Dictionary<string, string> Rules { get; set; }
        public String Sentence { get; set; }
        public String Seed { get; set; }
        public Int16 Level { get; set; }

        public void Initialize()
        {
            Sentence = Seed;
        }

        public void Generate()
        {
            for (int whichLevel = 0; whichLevel < Level; whichLevel++)
            {
                var nextSentence = "";
                for (int i = 0; i < Sentence.Length; i++)
                {
                    var current = Sentence[i];
                    if (Rules.ContainsKey(current.ToString()))
                    {
                        nextSentence += Rules[current.ToString()];
                    }
                    else
                    {
                        nextSentence += current;
                    }
                }
                this.Sentence = nextSentence;
            }
        }
    }
}
