using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.BL
{
    class product
    {
        public string productname;
        public string productprice;
        public product(string productname)
        {
            this.productname = productname;
        }
        public product(string productname,string productprice)
        {
            this.productname = productname;
            this.productprice = productprice;
        }
        public product()
        {

        }
    }
    
}
