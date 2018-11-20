using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Turtle
{
    //State at a moment T
    class T_State
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

