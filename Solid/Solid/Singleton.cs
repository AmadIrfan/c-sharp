using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    internal class Singleton
    {
        private static Singleton instance;
        private Singleton() {
            Console.WriteLine("this is private Constructor");
        }
        public static Singleton getInstnce()
        {
            if (instance == null)
            {
                instance = new Singleton();
                Console.WriteLine("this is called");
            }
        return instance;
        }

        public void Print()
        {
            Console.WriteLine("this is Singlton class");
        }
    }
}
