using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ums.UI
{
    class menuOptionUI
    {
        public static int menuOption()
        {
            int option = 0;
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter your option...");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
