using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Enter a number ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number ");
            c = int.Parse(Console.ReadLine());
            if(a>b && b>c)
            {
                Console.WriteLine(a + " is largest");
            }
            Console.ReadKey();
        }
    }
}
