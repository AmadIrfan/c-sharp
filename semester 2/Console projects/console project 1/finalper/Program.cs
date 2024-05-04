using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using finalper.BL;
namespace finalper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student stu = new student("Amad","Irfan",25,"30000");
            stu.printDetail();
            stu.updateFees(37000);
            Console.WriteLine("-------------------------------------");
            teacher thr = new teacher("Irfan","Mehmood",35000,"good");
            thr.printDetail();
            thr.updateSelary(50000);
            Console.ReadKey();
        }
    }
}
