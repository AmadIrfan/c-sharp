using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ums.BL;

namespace ums.UI
{
    class addDegreeProgramUI
    {
        public static degreeProgram addDegree()
        {
            string degreeName, code = "", type = "";
            float degreeDuration;
            int seats = 0, count = 0, creditHours = 0, subjectFees = 0;
            Console.WriteLine("Enter degree name...");
            degreeName = Console.ReadLine();
            Console.WriteLine("Enter degree duration...");
            degreeDuration = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter seats for degree...");
            seats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many subjects to enter...");
            count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter subject code...");
                code = Console.ReadLine();
                Console.WriteLine("Enter subject type...");
                type = Console.ReadLine();
                Console.WriteLine("Enter subject credit hour...");
                creditHours = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter subject fees...");
                subjectFees = int.Parse(Console.ReadLine());
                subject obj1 = new subject(code, type, creditHours, subjectFees);
                subject newobj = new subject();
               // newobj
            }
            degreeProgram obj = new degreeProgram(degreeName, degreeDuration, seats);
            return obj;
        }
    }
}
