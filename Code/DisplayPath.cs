using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turtle
{
    class DisplayPath
    {
        private void MoveTurtle(IntTurtle turtle)
        {
            var functions = new Dictionary<char, Action<IntTurtle>>();
            functions['F'] = t => t.Forward(true);
            functions['S'] = t => t.Forward(false);
            functions['-'] = t => t.TurnLeft();
            functions['+'] = t => t.TurnRight();
            functions['['] = t => t.Push();
            functions[']'] = t => t.Pop();
        }
    }
}
