using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Program
    {
        static string man = "Amad"; 
        class amad
        {
            public string name;
            public string classes;
            public int Roll_no;
            public float cgpa;
        }
        static void Main(string[] args)
        {
            amad student = new amad();
            Console.WriteLine("Enter your name ");
            student.name = Console.ReadLine();
            Console.WriteLine("Enter your class ");
            student.classes = Console.ReadLine();
            Console.WriteLine("Enter your Roll No ");
            student.Roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Cgpa ");
            student.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine(student.name);
            Console.WriteLine(student.classes);
            Console.WriteLine(student.Roll_no);
            Console.WriteLine(student.cgpa);
            Console.WriteLine(man);
            Console.ReadKey();
        }
    }
}
