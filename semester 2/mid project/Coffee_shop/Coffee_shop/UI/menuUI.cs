using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_shop.UI
{
    class menuUI
    {

        public static void menuTop()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("*                ship              *");
            Console.WriteLine("***********************************");
        }
        public static int mainmenu()
        {
            int option;
            Console.WriteLine("Menu  >>  ");
            Console.WriteLine("(1):Add Menu Item");
            Console.WriteLine("(2):View cheapest Item in menu");
            Console.WriteLine("(3):View Drink menu ");
            Console.WriteLine("(4):View Food menu ");
            Console.WriteLine("(5):add Order");
            Console.WriteLine("(6):Fulfill Order ");
            Console.WriteLine("(7):View the Order's list");
            Console.WriteLine("(8):total payable Amount ");
            Console.WriteLine("(9):Exit ");
            do
            {
                Console.WriteLine("Enter your option....");
                option = int.Parse(Console.ReadLine());
            }
            while (option > 9);
            return option;
        }
        public static void clearScreen()
        {
            Console.WriteLine("Press any key to Continue..");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
