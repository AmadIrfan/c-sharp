using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointofsale.BL
{
    class Customer
    {
        public string name;
        public int Quentity;
        public Customer(string name,int Quentity)
        {
             this.name=name;
            this.Quentity=Quentity;
        }
    }
}
