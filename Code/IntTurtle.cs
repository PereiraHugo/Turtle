using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Turtle
{
    public interface IntTurtle
    {
        void Push();
        void Pop();
        void Forward(bool doMove);
        void TurnLeft();
        void TurnRight();
    }
}
