using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Coffee_shop.BL;
using Coffee_shop.UI;

namespace Coffee_shop.DL
{
    class CoffeshopDL
    {
        public static List<menuitem> menu = new List<menuitem>();
        public static void Additem(menuitem temp)
        {
            menu.Add(temp);
        }
        public static int cheapestItem()
        {
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
            int sum = 0;
            for (int i = 0; i < Coffeshop.order.Count; i++)
            {
                name = Coffeshop.order[i];
                foreach (menuitem x in menu)
                {
                    if (name == x.name)
                    {
                        sum = sum + x.price;
                    }
                }
            }

            return sum;
        }
        public static void CofeeshopDataToFile()
        {
            string path = "CofeeshopData.txt";
            StreamWriter file = new StreamWriter(path,true);
            foreach (menuitem i in menu) { 
            file.WriteLine(i.name+","+i.Type+","+i.price);
            }
            file.Flush();
            file.Close();
        }
        public static void CofeeshopDataFromFile()
        {
            string path = "CofeeshopData.txt";
            StreamReader file = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string type = splittedRecord[1];
                    int price =int.Parse( splittedRecord[2]);
                    menuitem c = new menuitem(name,type,price);
                    Additem(c);
                }
            }
            file.Close();

            }

        }
}
