using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP
{
    internal class EmailNotification:INotification
    {
        public void sendNotification(String message)
        {
            Console.WriteLine(message);
        }
    }
}
