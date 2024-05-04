using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    internal class Computer
    {
        Keyboard keyboard;
        Mouse mouse;
        public Computer(Keyboard keyboard,Mouse mouse) {
            this.keyboard = keyboard;
            this.mouse = mouse;
        }
    }
}
