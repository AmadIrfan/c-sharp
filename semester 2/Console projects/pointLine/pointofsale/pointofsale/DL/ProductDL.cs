using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointofsale.BL;

namespace pointofsale.DL
{
    class ProductDL
    {
        public static List<Product> products = new List<Product>();
    public static void addProduct(Product temp)
    {
            products.Add(temp);
    }
        public static int HeigestPrice() 
        {
            int max = 0;
            foreach (Product i in products) 
            {
                if (i.price > max)
                {
                    max = i.price;
                }
            }
            return max;
        }
        public static int CalculateTax()
        {
            int tax, sum=0;
            foreach (Product i in products ) { 

             tax= (i.price * 15 / 100);
                sum = sum + tax;
            }
        return sum;
        }

    }
}
