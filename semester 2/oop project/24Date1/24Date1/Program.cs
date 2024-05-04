using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class1.BL;

namespace _24Date1
{
    class Program
    {
        static void Main(string[] args)
        {
            student stu = new student();
            reader(stu);
            printer(stu);
        }
        static void reader(student stu)
        {
            Console.WriteLine("Enter the name of student ");
            stu.name = Console.ReadLine();
            Console.WriteLine("Enter the Roll no of student ");
            stu.roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Cgpa of student ");
            stu.cgpa = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Department of student ");
            stu.department = Console.ReadLine();
            Console.WriteLine("Is Hostelide ");
            stu.ishostelide = Console.ReadLine();
        }
         static void printer(student stu)
        {
            Console.WriteLine("Name of student " + stu.name);
            Console.WriteLine("Roll no of student " + stu.roll_no);
            Console.WriteLine("CGPA of student " + stu.cgpa);
            Console.WriteLine("DEPARTMENT of student " + stu.department);
            Console.WriteLine("Hostelide " + stu.ishostelide);
            Console.ReadKey();
        }
    }
}
