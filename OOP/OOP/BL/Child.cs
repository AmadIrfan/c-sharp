using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    internal class Child :Father
    {
        public Child(String name, int age) : base(name, age) {
            Console.WriteLine("Child");
        }

        public  void getNameString()
        {
        }
    }
}
