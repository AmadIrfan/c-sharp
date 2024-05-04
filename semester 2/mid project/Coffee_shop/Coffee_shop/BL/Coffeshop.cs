using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_shop.BL
{
    class Coffeshop
    {
        public string name;
        public static List<menuitem> menu = new List<menuitem>();
        public static List<string> order = new List<string>();
        //Constructor
        /*public Coffeshop(string name)
        {
            this.name = name;
        }*/
        public static void Additem(menuitem temp)
        {
            menu.Add(temp);
        }
        public static bool AddOrdder(string name)
        {
            foreach (menuitem i in menu)
            {
                if (name == i.name)
                {
                    order.Add(i.name);
                    return true;
                }
            }
            return false;
        }
        public static bool fulfilOrder()
        {
            foreach (string i in order)
            {
                if (i != null)
                {
                    return true;
                }
            }
            return false;
        }
        public static int cheapestItem() {
            int min = 10000;
            int index = 0;

            for (int i = 0; i < menu.Count; i++)
            {
                if (min > menu[i].price)
                {
                    min = menu[i].price;
                    index = i;
                }
            }
            return index;
        }
        public static int dueAmount() 
        {
            string name;
                int sum=0;
            for(int i = 0; i < order.Count; i++)
            {
                name = order[i];
                foreach(menuitem x in menu)
                {
                    if (name == x.name) {
                        sum = sum + x.price;
                    }
                }
            }
            
            return sum;
        }
    }
}
