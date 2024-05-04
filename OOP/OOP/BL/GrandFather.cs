using OOP.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
  abstract class GrandFather:IMethod,IPerson
    {
       private String name;
       private int age;
       public GrandFather( string name,int age)
        {
            Age = age;
            Name = name;
            Console.WriteLine("Grand Father");

        }
        abstract public void getStringName();
        public int Age { get { return  age; } set { age = value; } }
        public string Name { get => name; set => name = value; }
    }
}
