using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.ISP.interfaces;

namespace Solid.ISP
{
    internal class Waiter:IWaiter
    {
        public void ServeFood() { }
        public void TakeOrder() { }
    }
}
