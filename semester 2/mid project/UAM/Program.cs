using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAM.NewFolder1;

namespace UAM
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                option = Menu();
                clearScreen();
                if (option == 1)
                {
                    if (programList.Count > 0)
                    {
                        Student s = takeInputForStudent();
                        addIntoStudentList(s);
                    }
                }
                else if (option == 2)
                {
                    DegreeProgram d = takeInputForDegree();
                    addIntoDegreeList();
                }
                else if (option == 3)
                {
                    List<Student> sortedStudentList = new List<Student>();
                    sortedStudentList = sortedStudentByMerit();
                    giveAdmission(sortedStudentList);
                    printStudent();
                }
                else if (option == 4)
                {
                    viewRegisteredStudents();
                }
                else if (option == 5)
                {
                    string degName;
                    Console.Write("Enter Degree Name: ");
                    degName = Console.ReadLine();
                    viewStuddentInDegree(degName);
                }
                else if (option == 6)
                {
                    Console.Write("Enter THe Student Name: ");
                    string name = Console.ReadLine();
                    Student s = StudentPresent(name);
                    if (s != null)
                    {
                        viewSubjects(s);
                        registerSubjects(s)
                    }
                }
                else if (option == 7)
                {
                    calculateFeeForAll();
                }
                clearScreen();
            }
            while (option != 8);
            Console.ReadKey();
        }

        static Student StudentPresent(string name)
        {
            foreach(Student s in studentLIist)
            {
                if(name == s.name && s.regDegree != null)
                {
                    return s;
                }
            }
            return null;
        }

        static void calculateFeeForAll()
        {
            foreach(Student s in studentList)
            {
                if(s.regDegree != null)
                {
                    Console.WriteLine(s.name+" has " + s.calculateFee()+ " fees);
                }
            }
        }

        static void registerSubjects(Student s)
        {
            Console.WriteLine("Enter how many subjects you want to register: ");
            int count = int.Parse(Console.ReadLine());
            for(int x= 0; x<count;x++)
            {
                Console.WriteLine("Enter The Subject Code: ");
                string code = Console.ReadLine();
                bool flag = false;
                foreach(Subject sub in s.regDegree.subjects)
                {
                    if(code == sub.code && !(s.regSubject.Contains(sub)))
                    {
                        s.regStudentSubject(sub);
                        flag = true;
                        break;
                    }
                }
                if(flag == false)
                {
                    Console.WriteLine("Enter Valid Course");
                    x--;
                }
            }
        }

        static List<Student> sortStudentByMerit()
        {
            List<Student> sortedStudentList = new List<Student>();
            foreach(Student s in StudentList)
            {
                s.calculateMerit();
            }
            sortedStudentList = sortedStudentList.OrderByDescending(o => o.Merit).ToList();
            return sortedStudentList;
        }

        static void giveAdmission(List<Student> sortedStudentList)
        {
            foreach(Student s in sortedStudentList)
            {
                foreach(DegreeProgram d in s.prefrences)
                {
                    if(d.seats >0 && s.regDegree == null)
                    {
                        s.regDegree = d;
                        d.seats--;
                        break;
                    }
                }
            }
        }

        static void printStudents()
        {
            foreach(Student s in studentList)
            {
                if(s.regDegree != null)
                {
                    Console.WriteLine(s.name + " got Admission in " + s.regDegree);
                }
                else
                {
                    Console.WriteLine(s.name + " did not get Admission");
                }
            }
        }

        static void clearScreen()
        {
            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
            Console.Clear();
        }

        static void viewStuddentInDegree(string degName)
        {
            Console.WriteLine("Name\tFSC\tEcat\tAge");
            foreach(Student s in studentList)
            {
                if(s.regDegree != null)
                {
                    if(degName == s.regDegree.degreeName)
                    {
                        Console.WriteLine(s.name +"\t" + s.fscMarks + "\t"+ s.ecatMarks + "\t" + s.age);
                    }
                }
            }
        }

        static void viewRegisteredStudents()
        {
            Console.WriteLine("Name\tFSC\tEcat\tAge");
            foreach(Student s in studentList)
            {
                if(s.regDegree != null)
                {
                    Console.WriteLine(s.name + "\t" + s.fscMarks "\t" + s.ecatMarks + "\t" + s.age);

                }
            }
        }

        static void addIntoDegreeList(DegreeProgram d)
        {
            programList.Add(d);
        }

        static DegreeProgram takeInputForDegree()
        {
            string degreeName;
            float degreeDuration;
            int seats;
            Console.Write("Enter Degree Name: ");
            degreeName = Console.ReadLine();
            Console.Write("Enter Degree Duration: ");
            degreeDuration =float.Parse( Console.ReadLine());
            Console.Write("Enter Seats For Degree: ");
            seats = int.Parse(Console.ReadLine());

            DegreeProgram degprog = new DegreeProgram(degreeName, degreeDuration, seats);
            Console.Write("Enter How Many Subjects To Enter: ");
            int count = int.Parse(Console.ReadLine());
            for(int x=0;x<count; x++)
            {
                degprog.AddSubject(takeInputForSubject());
            }
            return degprog;
        }

        static Subject takeInputForSubject()
        {
            string code;
            string type;
            int creditHours;
        }
    }
}
