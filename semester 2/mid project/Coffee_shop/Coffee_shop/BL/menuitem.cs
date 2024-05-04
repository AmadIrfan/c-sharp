using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_shop.BL
{
    class menuitem
    {
        public string name;
        public string Type;
        public int price;
        //Constructor
        public menuitem(string name,string Type, int price)
        {
            this.name = name;
            this.Type = Type;
            this.price = price;
        }
    }
}
