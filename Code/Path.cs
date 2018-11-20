using System;
using System.Collections.Generic;
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
        private void Draw(BuildPath path, int angle, int repeats, int length)
        {
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
                    branch_start_x = start_x;
                    branch_start_y = start_y;
                }
                else if (action.Equals(']'))
                {
                    start_x = branch_start_x;
                    start_y = branch_start_y;
                }

                if (action.Equals('+') || action.Equals('-') || action.Equals('S'))
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
            }
            return;
        }
    }
}
