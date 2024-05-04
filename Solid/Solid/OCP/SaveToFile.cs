using Solid.BL;
using Solid.OCP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP
{
    internal class SaveToFile:ISave
    {
        public void Save(Email email)
        {
            Console.WriteLine(email.ToString());
            Console.WriteLine("save to file");
        }
    }
}
