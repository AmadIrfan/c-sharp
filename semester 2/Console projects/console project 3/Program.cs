using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using newData.BL;
using newData.DL;

namespace newData
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            Program program = new Program();
            addStudents();
            printData();
            Console.ReadLine();
        }
        public static void addStudents()
        {
            bool added;
            String name;
            String fname;
            String col;
            int age;
            int id;
            for (int i = 0; i < 1; i++)
            {
                Console
                    .WriteLine("Enter name ");
                name = Console.ReadLine();
                Console
                    .WriteLine(" Enter father name ");
                fname = Console.ReadLine();
                 Console
                    .WriteLine(" Enter Collage name ");
                col = Console.ReadLine();
                Console
                   .WriteLine(" Enter Collage id ");
                id = int.Parse(Console.ReadLine());
                Console
                   .WriteLine(" Enter age ");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine(age);
                Students stu = new Students(name, fname, col, age, id);
                added = listStudents.AddStudentstoList(stu);
            }
        }
        public static void printData() {
            for (int i=0 ; i <listStudents.Data.Count; i++)
            {
                Console.WriteLine(listStudents.Data[i].id.ToString()+","+listStudents.Data[i].name + "," + listStudents.Data[i].Father_name + "," + listStudents.Data[i].age.ToString());
            }
        }


    }
}
