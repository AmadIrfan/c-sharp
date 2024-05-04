using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointofsale.BL;
namespace pointofsale.DL
{
    class CustomerDL
    {
        public static List<Customer> customer = new List<Customer>();
           public static void AddOrder(Customer temp)
           {
                 foreach(Product i in ProductDL.products)
                {
                        if (temp.name == i.name)
                        {
                          customer.Add(temp);
                        }
                  }
           }
    }
}
