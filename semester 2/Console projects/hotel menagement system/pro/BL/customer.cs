using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.BL
{
    class customer
    {
        public string name;
        public string idcardnumber;
        public List<room> bookedroomlist;
        public List<product> orderedlist;
        public customer(string name,string idcardnumber)
        {
            this.name = name;
            this.idcardnumber = idcardnumber;
        }
        public customer(string name)
        {
            this.name = name;
        }
        public customer(string name,string idcardnumber,List<room> bookedlist)
        {
            this.name = name;
            this.idcardnumber = idcardnumber;
        }
        public customer(string name, string idcardnumber, List<product> orderedlist)
        {
            this.name = name;
            this.idcardnumber = idcardnumber;
            this.orderedlist = orderedlist;
        }
        public customer()
        {

        }
    }
}
