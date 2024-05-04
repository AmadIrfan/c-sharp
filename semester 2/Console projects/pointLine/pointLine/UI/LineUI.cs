using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointLine.BL;
using pointLine.DL;

namespace pointLine.UI
{
    class LineUI
    {
        public static void GetGradient(Line Line)
        {
            if (!Line.CheckGradient())
            {
                Console.WriteLine("Gradient of Line: {0}", Line.getGradient());
            }
            else
            {
                Console.WriteLine("Gradient of Line: Infinity");
            }
        }

        public static void DisplayLength(Line Line)
        {
            Console.WriteLine("Lenght of Line = {0}", Line.getLine());
        }
    }
}
