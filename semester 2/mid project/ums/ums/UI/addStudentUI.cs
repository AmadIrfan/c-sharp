using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ums.BL;
using ums.DL;

namespace ums.UI
{
    class addStudentUI
    {
        public static student addStudent()
        {
            string name;
            int age, count = 0;
            double fscMarks, ecatMarks;
            Console.WriteLine("Enter student name...");
            name = Console.ReadLine();
            Console.WriteLine("Enter student age...");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student fsc marks...");
            fscMarks = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter student ecat marks...");
            ecatMarks = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter how many prefrences to enter...");
            count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                DL.degreeProgramDL.prefrences[i].degreeName = Console.ReadLine();
            }

        }
    }
}
