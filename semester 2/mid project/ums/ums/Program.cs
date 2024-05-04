using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ums.BL;
using ums.DL;

namespace ums
{
    class Program
    {
        static student addStudent(List<degreeProgram> prefrences)
        {
            string name;
            int age,count=0;
            double fscMarks,ecatMarks;
            Console.WriteLine("Enter student name...");
            name = Console.ReadLine();
            Console.WriteLine("Enter student age...");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student fsc marks...");
            fscMarks = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter student ecat marks...");
            ecatMarks = double.Parse(Console.ReadLine());
            viewAvailablePrefrences(prefrences);
            Console.WriteLine("Enter how many prefrences to enter...");
            count = int.Parse(Console.ReadLine());
            for(int i=0;i<count;i++)
            {
                prefrences[i].degreeName = Console.ReadLine();
            }
            student obj = new student(name, age, fscMarks, ecatMarks, prefrences);
            return obj;
        } 
        static degreeProgram addDegreeProgram(List<subject> subjectList)
        {
            string degreeName,code="",type="";
            float degreeDuration;
            int seats=0,count=0,creditHours=0,subjectFees=0;
            Console.WriteLine("Enter degree name...");
            degreeName = Console.ReadLine();
            Console.WriteLine("Enter degree duration...");
            degreeDuration = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter seats for degree...");
            seats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many subjects to enter...");
            count = int.Parse(Console.ReadLine());
            for(int i=0;i < count;i++)
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
                addSubjectinList(obj1,subjectList);
            }          
            degreeProgram obj = new degreeProgram(degreeName, degreeDuration, subjectList, seats);
            return obj;
        }
        static void addDegreeintoList(degreeProgram obj, List<degreeProgram> degreeList)
        {
            degreeList.Add(obj);
        }
        static void addDegreeintoFile(List<degreeProgram> degreeList, List<subject> subjectList)
        {
            string path = "prefrencedetail.txt";
            StreamWriter prefrencedetail = new StreamWriter(path,true);
            for(int i=0;i<degreeList.Count; i++)
            {
                prefrencedetail.WriteLine(degreeList[i].degreeName + "," + degreeList[i].degreeDuration + "," + degreeList[i].seats);
            }
            prefrencedetail.Flush();
            prefrencedetail.Close();
        }
        static void viewAvailablePrefrences(List<degreeProgram> degreeList)
        {
            Console.WriteLine("Available  Degree  Programs");
            for(int i = 0;i < degreeList.Count;i++)
            {
                Console.WriteLine(degreeList[i].degreeName);
            }
            Console.ReadKey();
        }
        static void loadDegreeData(List<degreeProgram> degreeList, List<subject> subjectList)
        {
            string path = "prefrencedetail.txt";
            StreamReader prefrencedetail = new StreamReader(path);
            if(File.Exists(path))
            {
                string record;
                while((record = prefrencedetail.ReadLine()) != null)
                {
                    degreeProgram obj = new degreeProgram();
                    obj.degreeName = parseData(record, 1);
                    obj.degreeDuration = int.Parse(parseData(record, 2));
                    obj.seats = int.Parse(parseData(record, 3));
                    degreeList.Add(obj);
                }
                prefrencedetail.Close();
            }
            else
            {
                Console.WriteLine("File does not exist");
                Console.ReadKey();
            }
        }
        static string parseData(string record,int field)
        {
            int comma = 1;
            string item = "";
            for(int i=0;i< record.Length;i++)
            {
                if(record[i] == ',')
                {
                    comma = comma + 1;
                }
                else if(comma == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }
        static void Main(string[] args)
        {
            List<degreeProgram> prefrences = new List<degreeProgram>(); // to enter how many perf user choose
            List<subject> subjectList = new List<subject>();  // to add subject to this list
            List<degreeProgram> degreeList = new List<degreeProgram>(); // to add degree tile,degree name and seats into list
            int option = 0;
           
            while(option < 3)
            {
                Console.Clear();
                Console.WriteLine("Enter your option");
                option = int.Parse(Console.ReadLine());
                if(option == 1)
                {
                    addStudent(prefrences);
                }
                if(option == 2)
                {
                    degreeProgram temp;
                    temp = addDegreeProgram(subjectList);
                    addDegreeintoList(temp, degreeList);
                    addDegreeintoFile(degreeList,subjectList);
                }
            }
            Console.ReadKey();
        }
    }
}