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
            Console.WriteLine(system.Sentence);
            Path = system.Sentence;
        } 
    }
}
