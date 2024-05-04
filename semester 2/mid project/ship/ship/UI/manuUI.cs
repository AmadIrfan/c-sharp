using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ship.UL
{
    class manuUI
    {
        public static int menu()
        {
            int input;
            Console.WriteLine("*******************************************");
            Console.WriteLine("                Ship managment             ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("1.Add Ship ");
            Console.WriteLine("2.View Ship Position ");
            Console.WriteLine("3.View Ship Serial Number ");
            Console.WriteLine("4.Change Ship Position ");
            Console.WriteLine("5.Exit ");
            Console.WriteLine("Your choise ");
            input = int.Parse(Console.ReadLine());
            return input;
        }
        public static void clearScreen()
        {
            Console.WriteLine("Press any key to Continue..");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
