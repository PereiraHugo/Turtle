using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turtle
{
    class BuildPath
    {
        public String Path { get; set; }

        public void Buildingpath(L_System system) {
            system.Initialize();
            system.Generate();
            Path = system.Sentence;
        } 
    }

    class DrawingPath
    {
        private void Draw(BuildPath allpath, int angle, int repeats, int length)
        {
            string path = allpath.Path;
            Stack<int> stack_x = new Stack<int>();
            Stack<int> stack_y = new Stack<int>();


            foreach (char action in path)
            {
                if (action.Equals('+'))
                {
                    angle = angle + (int)angleNumericUpDown.Value;
                }
                else if (action.Equals('-'))
                {
                    angle = angle + 360 - (int)angleNumericUpDown.Value;
                }
                else if (action.Equals('['))
                {
                    stack_x.Push(start_x);
                    stack_y.Push(start_y);
                }
                else if (action.Equals(']'))
                {
                    start_x = stack_x.Pop();
                    start_y = stack_y.Pop();
                }

                if (action.Equals('+') || action.Equals('-') || action.Equals('F'))
                {
                    // Modifiy Cos and Sin for each start
                    end_x = (int)(start_x + Math.Cos(angle * .017453292519) * length);
                    end_y = (int)(start_y + Math.Sin(angle * .017453292519) * length);

                    Point[] points = {
                        new Point(start_x, start_y),
                        new Point(end_x, end_y),
                    };
                    start_x = end_x;
                    start_y = end_y;
                    g.DrawLines(myPen, points);
                }
                else if (action.Equals('f'))
                {
                    continue;
                }
            }
            return;
        }
    }

}
