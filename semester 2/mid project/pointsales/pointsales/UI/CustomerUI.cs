using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointsales.BL;
using pointsales.DL;
namespace pointsales.UI
{
    class CustomerUI
    {
        public static Customer BuyProduct()
        {
            string name;
            int number;
            Console.WriteLine("Enter name of Product : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Quantity of Product : ");
            number = int.Parse(Console.ReadLine());
            Customer temp = new Customer(name, number);
            return temp;
        }
        public static void IsOrderd(bool status)
        {
            if (status==true) 
            {
                Console.WriteLine("Product is orderd ");
            }
            else 
            {
                Console.WriteLine("OOOPS !!! Try again ");
            }
        }
    }
}
