using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Solid.BL;

namespace Solid.DL
{
    internal class EmailSender
    {
    public void sendEmail(Email data) {

            Console.WriteLine(data.ToString());
        }
    }
}
