using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using pro.BL;

namespace pro.DL
{
    class workerDL
    {
        public static List<worker> workerlist = new List<worker>();
        public static List<worker> workerlistwithproduct = new List<worker>();

        public static void addworkerintolist(worker w)
        {
            workerlist.Add(w);
        }
        // function for sorting of workerdata
        public static void sorting()
        {
            for (int i = 0; i < workerlist.Count; i++)
            {
                for (int j = i + 1; j < workerlist.Count; j++)
                {
                    if (workerlist[i].workerage > workerlist[j].workerage)
                    {
                        int temp = workerlist[i].workerage;
                        workerlist[i].workerage = workerlist[j].workerage;
                        workerlist[j].workerage = temp;
                        string tem = workerlist[i].workername;
                        workerlist[i].workername = workerlist[j].workername;
                        workerlist[j].workername = tem;
                        double te = workerlist[i].workersalary;
                        workerlist[i].workersalary = workerlist[j].workersalary;
                        workerlist[j].workersalary = te;
                        string t = workerlist[i].workerexperience;
                        workerlist[i].workerexperience = workerlist[j].workerexperience;
                        workerlist[j].workerexperience = t;
                    }
                }
            }

        }
        public static void addinfile(string path)
        {
            StreamWriter f = new StreamWriter(path);
            for (int i = 0; i < workerlist.Count; i++)
            {
                f.WriteLine(workerlist[i].workername + "," + workerlist[i].workerage + "," + workerlist[i].workersalary + "," + workerlist[i].workerexperience);
            }
            f.Flush();
            f.Close();
        }
        // function for loading worker data from the file
        public static bool readFromFile(string path)
        {
            string record;
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string workername = splittedRecord[0];
                    int workerage = int.Parse(splittedRecord[1]);
                    double workersalary = double.Parse(splittedRecord[2]);
                    string experience = splittedRecord[3];
                    worker w = new worker(workername, workerage, workersalary, experience);
                    workerlist.Add(w);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void del(worker wo)
        {
            for (int i = 0; i < workerlist.Count; i++)
            {
                if (wo.workername == workerlist[i].workername)
                {
                    workerlist.Remove(workerlist[i]);
                }
            }

        }
      
    }
}
