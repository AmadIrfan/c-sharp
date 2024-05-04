using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee_shop.DL;
using Coffee_shop.BL;

namespace Coffee_shop.UI
{
    class CoffeshopUI
    {
        public static void PrintCheapestItem()
        {
        int index;
        index = CoffeshopDL.cheapestItem();
                    Console.WriteLine(" cheapest item on the menu. ");
                    Console.WriteLine("name\tType\tprice");
                    Console.WriteLine(CoffeshopDL.menu[index].name+"\t" + CoffeshopDL.menu[index].Type + "\t" + CoffeshopDL.menu[index].price);
        }
        public static void DueAmounts()
        {

            Console.WriteLine("Total due Amount ");
            Console.WriteLine(CoffeshopDL.dueAmount());
        }
    }
}
