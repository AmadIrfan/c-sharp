using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uams.BL;
using uams.DL;

namespace uams.UI
{
    class DegreeProgramUI
    {
        public static DegreeProgram DegreeInput()
        {
            string degree_n;
            float degree_D;
            int seat;
            Console.Write("Enter Degree Name ");
            degree_n= Console.ReadLine();
            Console.Write("Enter Duration of Degree : ");
            degree_D = float.Parse(Console.ReadLine());
            Console.Write("Enter Seats of Degree: ");
            seat = int.Parse(Console.ReadLine());

            DegreeProgram degProg = new DegreeProgram(degree_n, degree_D, seat);
            Console.Write("Enter number of Subjects : ");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                Subject s = SubjectUI.takeSubject();
                if (degProg.AddSubject(s))
                {
                    if (!(SubjectDL.subjectList.Contains(s)))
                    {
                        SubjectDL.addSubjectIntoList(s);
                        SubjectDL.storeintoFile("subject.txt", s);
                    }
                    Console.WriteLine("Subject Added");
                }
                else
                {
                    Console.WriteLine("OOP sorry ! subject Not Added");
                    Console.WriteLine("20 credit hour limit exceeded");
                    x--;
                }
            }
            return degProg;
        }
        public static void viewDegPrograms()
        {
            foreach (DegreeProgram dp in DegreeProgramDL.programList)
            {
                Console.WriteLine(dp.degreeName);
            }
        }
    }
}
