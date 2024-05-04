using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointsales.BL
{
    class Product
    {
        public string name;
        public string type;
        public int price;
        public int quantity;
        //public string 
        public Product(string name, string type, int price, int quantity)
        {
            this.name = name;
            this.type = type;
            this.price = price;
            this.quantity = quantity;
        }

    }
}
