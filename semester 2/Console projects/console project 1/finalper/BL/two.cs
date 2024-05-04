using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalper.BL
{
   class teacher : person,Iteacher
    {
       public int selary;
        public string qual;
        public teacher(string fname, string lname, int selary, string qual) : base(fname, lname)
        {
            this.selary=selary;
            this.qual=qual;
        }
        public override void printDetail()
        {
            string name =firstName+" "+lastName;
            Console.WriteLine("Teacher Name {0} ",name);
            Console.WriteLine("Teacher qual {0} ",qual);
            Console.WriteLine("Teacher selary {0} ",selary);
        }
       public void updateSelary(int US)
       {
            Console.WriteLine("Teacher updated Selary {0} ", US);
       }
    }
}
