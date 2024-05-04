using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointsales.DL;
using pointsales.BL;

namespace pointsales.UI
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
            type = Console.ReadLine();
            Console.WriteLine("Enter product price ");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product  Quantity ");
            quantity = int.Parse(Console.ReadLine());
            Product temp = new Product(name, type, price, quantity);
            return temp;
        }
        public static void AllProduct()
        {
            Console.WriteLine("Name\tType\tPrice\tquantity\t");
            foreach (Product i in ProductDL.products)
            {
                Console.WriteLine(i.name + "\t" + i.type + "\t" + i.price + "\t" + i.quantity + "\t");
            }
        }
        public static void highest_price()
        {
            Console.WriteLine("Product with Highest Unit Price. ");
            int index = ProductDL.HeigestPrice();
            Console.WriteLine("Name\tType\tPrice\tquantity\t");
            Console.WriteLine(ProductDL.products[index].name + "\t" + ProductDL.products[index].type + "\t" + ProductDL.products[index].price + "\t" + ProductDL.products[index].quantity + "\t");
        }
        public static void totalTex()
        {
            int tax = ProductDL.CalculateTax();
            Console.WriteLine("Total sales tax ");
            Console.WriteLine(tax);

        }

        public static void PrintAllOrdersProduct()
        {
            Console.WriteLine("Name\tType\tPrice\tquantity\t");
            foreach (Product a in ProductDL.products)
            {
                foreach (Customer i in CustomerDL.customer)
                {
                    if (a.name == i.name)
                    {
                        Console.WriteLine(i.name + a.type + "\t" + a.price + "\t" + i.Quentity);

                    }
                }
            }
        }
        public static void Printinvoice()
        {
            string name;
            int total=0, sum = 0, invoice=0;
            
            for (int i = 0; i < CustomerDL.customer.Count; i++)
            {
                name = CustomerDL.customer[i].name;
                foreach (Product a in ProductDL.products)
                {
                    if (name == a.name) 
                    {
                      invoice= ProductDL.calculateTax(a.type,a.price, CustomerDL.customer[i].Quentity);
                        total = a.price + invoice;
                        sum = sum + total;
                    }
                }
            }
            Console.WriteLine("Your total invoice..... "+ sum);
        } 
    }
}