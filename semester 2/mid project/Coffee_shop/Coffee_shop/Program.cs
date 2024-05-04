using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee_shop.BL;

namespace Coffee_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            while (option < 9)
            {
                option = mainmenu();
                if (option == 1) {
                   menuitem temp;
                    temp = addMenuItem();
                    Coffeshop.Additem(temp);
                }
                if (option == 2)
                {
                    int index;
                    index = Coffeshop.cheapestItem();
                    Console.WriteLine(" cheapest item on the menu. ");
                    Console.WriteLine("name\tType\tprice");
                    Console.WriteLine(Coffeshop.menu[index].name+"\t" + Coffeshop.menu[index].Type + "\t" + Coffeshop.menu[index].price);
                }
                if (option == 3)
                {
                 
                    Console.WriteLine("All Availible Food Items: ");
                            Console.WriteLine("name\tType\tprice");
                    foreach (menuitem i in Coffeshop.menu)
                    {
                        if (i.Type == "FOOD" || i.Type == "food")
                        {
                            Console.WriteLine(i.name + "\t" + i.Type + "\t" + i.price);
                        }
                    }
                }
                if (option == 4)
                {
                    Console.WriteLine("All Availible Drink Items: ");

                    Console.WriteLine("name\tType\tprice");
                    foreach (menuitem i in Coffeshop.menu)
                    {
                        if (i.Type == "Dirnk" || i.Type == "drink")
                        {
                            Console.WriteLine(i.name + "\t" + i.Type + "\t" + i.price);
                        }
                    }
                }
                if (option == 5) {
                   
                    string order;
                    bool check;
                    order = addOrder();
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
                if (option == 6) {
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
                if (option == 7) {
                    Console.WriteLine("all Orders ");

                    Console.WriteLine("\tname");
                    foreach (string i in Coffeshop.order)
                    {
                        if (i != null)
                        {
                            Console.WriteLine("\t"+i);
                        }
                    }
                }
                if (option == 8) { 
              Console.WriteLine("Total due Amount        ");
                    Console.WriteLine(Coffeshop.dueAmount());      
                }
                if (option == 9) {
                    break;
                }
            }
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
                option =int.Parse( Console.ReadLine());
            }
            while (option>9);
            return option;
        }
        static menuitem addMenuItem()
        {
            string name,Type;
            int price;
            Console.WriteLine("Enter the name of Item                                                                                                                                  ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the type of Item (food/drink)");
            Type = Console.ReadLine();
Console.WriteLine("Enter the price of Item");
            price =int.Parse( Console.ReadLine());
             menuitem item = new menuitem(name, Type,price);
            return item;
        }
        static string addOrder()
        {
            string Order;
            Console.WriteLine("Enter order name : ");
           Order= Console.ReadLine();
           // Coffeshop temp = new Coffeshop(Order);
            return Order;
        }
    }
}
