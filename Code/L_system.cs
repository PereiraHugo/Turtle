using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace Turtle
{
    // Global Definition of the system.
    public class L_System
    {

        public Dictionary<string, string> Symbols { get; set; }
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
                Console.WriteLine(nextSentence);
                this.Sentence = nextSentence;
            }
        }

        public Dictionary<string, string> Store_Rules(TextBox ruleKey1, TextBox ruleKey2, TextBox ruleValue1, TextBox ruleValue2)
        {
            var dict = new Dictionary<string, string> { };
            if (ruleKey1.Text != "" && ruleValue1.Text != "")
            {
                dict.Add(ruleKey1.Text, ruleValue1.Text);
            }
            if (ruleKey2.Text != "" && ruleValue2.Text != "")
            {
                dict.Add(ruleKey2.Text, ruleValue2.Text);
            }
            return dict;
        }

        public Dictionary<string, string> Store_Symbols(Stack<TextBox> symbols, Stack<ComboBox> relatedSymbols)
        {
            var dict = new Dictionary<string, string> { };
            while (symbols.Count > 0)
            {
                var symbolToAdd = symbols.Pop().Text;
                var relationToAdd = relatedSymbols.Pop().Text;
                if (symbolToAdd != "" && relationToAdd != "")
                {
                    dict.Add(symbolToAdd, relationToAdd);
                }
            }
            dict.Add("[", "[");
            dict.Add("]", "]");
            return dict;
        }
    }
}
