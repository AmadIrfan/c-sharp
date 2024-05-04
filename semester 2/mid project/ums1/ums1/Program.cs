using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ums1.classes.BL;

namespace ums1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name,Home;
            int roll_no, M_marks, F_marks, E_marks;
            bool IsHostelite, IstakingScholarship;
            float Cgpa, merit;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your Roll no: ");
            roll_no =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Cgpa: ");
            Cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Matric marks: ");
            M_marks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Fsc marks: ");
            F_marks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Ecat marks: ");
            E_marks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Home town: ");
            Home = Console.ReadLine();
            Console.WriteLine("IS Hostlite: ");
            IsHostelite = bool.Parse(Console.ReadLine());
            student s = new student(name,roll_no, Cgpa, M_marks, F_marks, E_marks, Home, IsHostelite);
            merit = s.calculateMerit();
                Console.WriteLine("Your merit "+ merit);
            IstakingScholarship = s.iseligibleforscolership(merit);
            if (IstakingScholarship == true)
            { 
                Console.WriteLine("You are eligible");
            }
            else
            {
                Console.WriteLine("You are not eligible");   
            }
            Console.ReadKey();
        }
    }
}
