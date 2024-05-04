using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using student.test.BL;

namespace student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] stud = new Student[3];
            char option = ' ';
            int index = 1;
            while (option==' '){

                if (option == 1) 
                {
                    stud[index]=addStudent();
                    index++;
                }
                if (option == 2)
                {
                    for(int i=0;i<index;i++)
                    {
                      display(stud,i);
                    }
                }
                if (option == 3) 
                {
                }
                if (option == 4)
                {
                    Environment.Exit(1);
                }
            }
        }
        static Student addStudent()
        {
            Student stu = new Student();
            Console.WriteLine("Enter the name of Student ");
            stu.name = Console.ReadLine();
            Console.WriteLine("Enter the Roll no of Student ");
            stu.rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Cgpa of Student ");
            stu.cgpa = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Department of Student ");
            stu.department = Console.ReadLine();
            Console.WriteLine("Is Hostelide ");
            stu.ishostelide = Console.ReadLine();
            return stu;
        }
        static char manu()
        {
            char option;
            Console.Clear();
            Console.WriteLine("Press 1 for Adding Student ");
            Console.WriteLine("Press 2 for view Student ");
            Console.WriteLine("Press 3 for view top 3 Student ");
            Console.WriteLine("Press 4 for Exit ");
            option=char.Parse(Console.ReadLine());
            return option;
        }
        static void display(Student[] stud,int idx)
        {
            Console.WriteLine("Name of Student " + stud[idx].name);
            Console.WriteLine("Roll no of Student "+ stud[idx].rollno);
            Console.WriteLine("Cgpa of Student " + stud[idx].cgpa);          
            Console.WriteLine("Department of Student " + stud[idx].department);
            Console.WriteLine("Is Hostelide " + stud[idx].ishostelide);
        }
    }
}
