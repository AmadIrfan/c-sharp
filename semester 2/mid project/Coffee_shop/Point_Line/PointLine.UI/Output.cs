using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Line.PointLine.UI
{
    class Output
    {
        public static void Header()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("\t\t\t                      Point and Line Application                   "); 
            Console.WriteLine("\t\t\t+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        }
        public static int  Menu()
        {
            Console.WriteLine("1)   Make a Line");
            Console.WriteLine("2)   Update the Begin Point");
            Console.WriteLine("3)   Update the End Point");
            Console.WriteLine("4)   Show the Beginning Point");
            Console.WriteLine("5)   Show the End Point");
            Console.WriteLine("6)   Get the Length of Line");
            Console.WriteLine("7)   Get the Gradient of Line");
            Console.WriteLine("8)   Distance of Begin Point from Zero");
            Console.WriteLine("9)   Distance of End Point from Zero");
            Console.WriteLine("10)  Exit");
            int op =int.Parse( Console.ReadLine());
            return op;
        }
    }
}
