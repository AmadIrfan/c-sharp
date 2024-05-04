using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    internal class Father:GrandFather
    {
        public Father(String name,int age):base(name,age) {
            Console.WriteLine("Father");
        }

        public override void getStringName()
        {
            Console.WriteLine(this.Name);
        }
    }
}
