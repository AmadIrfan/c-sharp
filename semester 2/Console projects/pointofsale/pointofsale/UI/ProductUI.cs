using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointofsale.DL;
using pointofsale.BL;

namespace pointofsale.UI
{
    class ProductUI
    {
        public static Product NewProduct()
        {
            string name, type;
            int price, quantity;
            Console.WriteLine("Enter product name ");
            name = Console.ReadLine();
            Console.WriteLine("Enter product type ");
            type= Console.ReadLine();
            Console.WriteLine("Enter product price ");
            price=int.Parse( Console.ReadLine());
            Console.WriteLine("Enter product  tex ");
            quantity = int.Parse( Console.ReadLine());
            Product temp = new Product(name,type,price, quantity);
            return temp;
        }
        public static void AllProduct()
        {
                Console.WriteLine("Name\tType\tPrice\tquantity\t");
            foreach(Product i in ProductDL.products)
            {
                Console.WriteLine(i.name+"\t" + i.type + "\t" + i.price + "\t" + i.quantity + "\t");
            }
        }
        public static void highest_price() {
            Console.WriteLine("Product with Highest Unit Price. ");
            int maxValue= ProductDL.HeigestPrice();
            Console.WriteLine(maxValue);
        }
        public static void totalTex()
        {
            int tax = ProductDL.CalculateTax();
            Console.WriteLine("Total sales tax ");
            Console.WriteLine(tax);
        }
    }
}
