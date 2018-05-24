using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Turtle
{
    //Global System
    class G_System
    {
        public List<string> symboles = new List<string>{"R","L","S","(",")" };
        public string initiale;
        public string remplacement;

        public G_System()
        {
        }

    }

    // ChangeRequest derives from WorkItem and adds a property (originalItemID) 
    // and two constructors.
    //State at a moment T
    class T_State : G_System
    {
        private int x_position;
        private int y_position;

        public T_State()
        {
        }

        public T_State(int coord_x,int coord_y)
        {
            x_position = coord_x;
            y_position = coord_y;
        }

        public List<int> GetState()
        {
            return new List<int> { x_position, y_position };
        }

        public void SetState(int coord_x, int coord_y)
        {
            x_position = coord_x;
            y_position = coord_y;
        }
    }

    class CharacterList
    {
        /// <summary>
        /// CharacterList is a class to perform all the operation on a string.
        /// This class check the good format of a string, can detect if parentheses are not closed
        /// and finally can produce a random string following certain rules.
        /// </summary>
        private string charlist;

        /// <summary>
        /// Constructor that takes no arguments.
        /// </summary>
        // 
        public CharacterList()
        {
            charlist = "";
        }

        /// <summary>
        /// Constructor that takes one argument.
        /// </summary>
        /// <param name="nm">a string to set the variable charlist</param>
        public CharacterList(string nm)
        {
            charlist = nm;
        }

        /// <summary>
        /// Method to set charlist variable
        /// </summary>
        /// <param name="newName">a string to set the variable charlist</param>
        public void SetCharList(string newName)
        {
            charlist = newName;
        }

        /// <summary>
        /// Method to get charlist variable.
        /// </summary>
        public string GetCharList()
        {
            return charlist;
        }

        /// <summary>
        /// Method Check character in charlist
        /// Verify string character if contains a character not allowed return false, unless return true
        /// Takes no argument the string to verify is charlist contain in the class
        /// and return an true if it's succesfull and false if there is an error
        /// </summary>
        public Boolean CheckFormat()
        {
            if (Regex.Matches(charlist, @"[^a-zA-Z()]").Count == 0)
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
        /// Takes no argument the string to verify is charlist contain in the class
        /// and return an true if it's succesfull and false if there is an error
        /// </summary>
        public Boolean CheckParentheses()
        {
            int nb_parentheses = 0, lg_charlist = charlist.Length;

            for (int i = 0; i < lg_charlist; i++)
            {
                nb_parentheses = NumberParentheses(charlist[i].ToString(), nb_parentheses);
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
        /// Method to set a random charlist following a standard
        /// The string generated contains 9 character
        /// It chose randomly the character to put at each index
        /// It implies that all parentheses are closed at the end.
        /// It set charlist with the random string generated.
        /// </summary>
        public void SetRandomCharList()
        {
            G_System system = new G_System();
            int nb_parentheses = 0;
            int index;
            Random r = new Random();
            charlist = "S";
            string symbolToAdd = "";
            for (int i = 0; i < 8; i++)
            {
                if(i == 0 || i >= 5 || charlist[charlist.Length - 1].ToString() == "(")
                {
                    index = r.Next(system.symboles.Count-2);
                    symbolToAdd = system.symboles[index];
                }
                else if (nb_parentheses < 2)
                {
                    index = r.Next(system.symboles.Count);
                    symbolToAdd = system.symboles[index];
                    if (nb_parentheses == 0 && symbolToAdd==")")
                    {
                        symbolToAdd = "(";
                    }
                    nb_parentheses = NumberParentheses(symbolToAdd, nb_parentheses);
                }
                if ((nb_parentheses == 2 && i==6) || (nb_parentheses == 1 && i == 7))
                {
                    symbolToAdd += ")";
                    nb_parentheses += -1;
                }
                charlist += symbolToAdd;
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
            if (char_to_test == "(")
            {
                return nb_parentheses += 1;
            }
            else if (char_to_test == ")")
            {
                return nb_parentheses += -1;
            }
            else
            {
                return nb_parentheses;
            }
        }
    }

    class Program
    {
        static MainWindow MainWin;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWin = new MainWindow();
            Application.Run(MainWin);
        }
    }
}

