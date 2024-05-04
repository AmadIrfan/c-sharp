using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee_shop.BL;
using Coffee_shop.DL;

namespace Coffee_shop.UI
{
    class OrderUI
    {
       public static string addOrder()
        {
            string Order;
            Console.WriteLine("Enter order name : ");
            Order = Console.ReadLine();
            // Coffeshop temp = new Coffeshop(Order);
            return Order;
        }
        public static void Ordering()
        {

        string order;
        bool check;
        order =OrderUI.addOrder();
                    check = Coffeshop.AddOrdder(order);
                    if (check == true)
                    {
                        Console.WriteLine("added order ");
                    }
                    else
                    {
                        Console.WriteLine("This item is currently unavailable");
                    }
        }
        public static void FulfillOrder()
        {
            bool check;
            check = Coffeshop.fulfilOrder();
            if (check == true)
            {
                Console.WriteLine("The {item} is ready!");
            }
            else
            {
                Console.WriteLine("All orders have been fulfilled!");
            }
        }
        public static void allOrder()
        {
            Console.WriteLine("all Orders ");
            Console.WriteLine("\tname");
            foreach (string i in Coffeshop.order)
            {
                if (i != null)
                {
                    Console.WriteLine("\t" + i);
                }
            }
        }
    }
}
