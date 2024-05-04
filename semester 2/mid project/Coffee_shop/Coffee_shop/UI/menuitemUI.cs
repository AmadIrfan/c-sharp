using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee_shop.BL;
using Coffee_shop.DL;

namespace Coffee_shop.UI
{
    class menuitemUI
    {
       public static menuitem addMenuItem()
        {
            string name, Type;
            int price;
            Console.WriteLine("Enter the name of Item");
            name = Console.ReadLine();
            Console.WriteLine("Enter the type of Item (food/drink)");
            Type = Console.ReadLine();
            Console.WriteLine("Enter the price of Item");
            price = int.Parse(Console.ReadLine());
            menuitem item = new menuitem(name, Type, price);
            return item;
        }
        public static void AvalibleFood()
        {

        Console.WriteLine("All Availible Food Items: ");
                            Console.WriteLine("name\tType\tprice");
                    foreach (menuitem i in CoffeshopDL.menu)
                    {
                        if (i.Type == "FOOD" || i.Type == "food")
                        {
                            Console.WriteLine(i.name + "\t" + i.Type + "\t" + i.price);
                        }
                    }
        }
        public static void AvalibleDrink()
        {

            Console.WriteLine("All Availible Drink Items: ");

            Console.WriteLine("name\tType\tprice");
            foreach (menuitem i in CoffeshopDL.menu)
            {
                if (i.Type == "Dirnk" || i.Type == "drink")
                {
                    Console.WriteLine(i.name + "\t" + i.Type + "\t" + i.price);
                }
            }
        }
    }
}
