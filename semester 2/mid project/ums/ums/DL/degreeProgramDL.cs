using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ums.BL;

namespace ums.DL
{
    class degreeProgramDL
    {
        public static List<degreeProgram> prefrences = new List<degreeProgram>();
        public static List<degreeProgram> degreeList = new List<degreeProgram>();
        public static void addDegreeinList(degreeProgram obj)
        {
            degreeList.Add(obj);
        }
        public static void loadDegreefromFile(List<degreeProgram> degreeList)
        {
            string path = "degree.detail.txt";
            StreamReader degreedetail = new StreamReader(path);
            if(File.Exists(path))
            {
                string record;
                while((record = degreedetail.ReadLine())!= null)
                {
                    degreeProgram obj = new degreeProgram();
                    obj.degreeName = parseData(record, 1);
                    obj.degreeDuration = int.Parse(parseData(record, 2));
                    obj.seats = int.Parse(parseData(record, 3));
                    degreeList.Add(obj);
                }
                degreedetail.Close();
            }
            else
            {
                Console.WriteLine("File does not exist");
                Console.ReadKey();
            }
        }
        public static string parseData(string record,int field)
        {
            int comma = 1;
            string item = "";
            for(int i=0;i<record.Length;i++)
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
        public static void viewAvailableDegreeProgram(List<degreeProgram> degreeList)
        {
            for(int i=0;i<degreeList.Count;i++)
            {
                Console.WriteLine(degreeList[i].degreeName);
            }
            Console.ReadKey();
        }
    }
}
