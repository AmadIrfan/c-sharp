using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointofsale.BL;
using pointofsale.DL;
namespace pointofsale.UI
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
            number =int.Parse( Console.ReadLine());
            Customer temp = new Customer(name,number);
            return temp;
        }
    }
}
