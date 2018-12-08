using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Turtle
{
    class UserString
    {
        /// <summary>
        /// CharacterList is a class to perform all the operation on a string.
        /// This class check the good format of a string, can detect if parentheses are not closed
        /// and finally can produce a random string following certain rules.
        /// </summary>

        /// <summary>
        /// Constructor that takes no arguments.
        /// </summary>
        // 
        public String Userstr { get; set; }

        /// <summary>
        /// Method Check character in Userstring
        /// Verify string character if contains a character not allowed return false, unless return true
        /// Takes no argument the string to verify is Userstring contain in the class
        /// and return an true if it's succesfull and false if there is an error
        /// </summary>
        public Boolean CheckFormat()
        {
            if (Regex.Matches(Userstr, @"[^a-zA-Z\\[\\]]").Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Method Check if all parentheses open are closed
        /// Verify string character gave if all the parentheses are closed.
        /// Takes no argument the string to verify is Userstring contain in the class
        /// and return an true if it's succesfull and false if there is an error
        /// </summary>
        public Boolean CheckParentheses()
        {
            int nb_parentheses = 0, lg_Userstr = Userstr.Length;

            for (int i = 0; i < lg_Userstr; i++)
            {
                nb_parentheses = NumberParentheses(Userstr[i].ToString(), nb_parentheses);
            }
            if (nb_parentheses == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Method to set a random Userstring following a standard
        /// The string generated contains 9 character
        /// It chose randomly the character to put at each index
        /// It implies that all parentheses are closed at the end.
        /// It set Userstring with the random string generated.
        /// </summary>
        public void SetRandomCharList()
        {
            var symbols = new List<string> { "f", "F", "-", "+", "[", "]" };
            int nb_parentheses = 0;
            int index;
            Random r = new Random();
            Userstr = "F";
            string symbolToAdd = "";
            for (int i = 0; i < 8; i++)
            {
                if (i == 0 || i >= 5 || Userstr[Userstr.Length - 1].ToString() == "[")
                {
                    index = r.Next(symbols.Count - 2);
                    symbolToAdd = symbols[index];
                }
                else if (nb_parentheses < 2)
                {
                    index = r.Next(symbols.Count);
                    symbolToAdd = symbols[index];
                    if (nb_parentheses == 0 && symbolToAdd == "]")
                    {
                        symbolToAdd = "[";
                    }
                    nb_parentheses = NumberParentheses(symbolToAdd, nb_parentheses);
                }
                if ((nb_parentheses == 2 && i == 6) || (nb_parentheses == 1 && i == 7))
                {
                    symbolToAdd += "]";
                    nb_parentheses += -1;
                }
                Userstr += symbolToAdd;
            }
        }

        /// <summary>
        /// Method to count the number of parentheses.
        /// It retunr the number of parentheses after testing the character.
        /// </summary>
        /// <param name="char_to_test">a string of one character to test</param>
        /// <param name="nb_parentheses">an int corresponding to the number of parentheses</param>
        private int NumberParentheses(string char_to_test, int nb_parentheses)
        {
            if (char_to_test == "[")
            {
                return nb_parentheses += 1;
            }
            else if (char_to_test == "]")
            {
                return nb_parentheses += -1;
            }
            else
            {
                return nb_parentheses;
            }
        }
    }
}
