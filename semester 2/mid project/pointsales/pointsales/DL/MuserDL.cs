using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointsales.BL;
using pointsales.UI;
using System.IO;
namespace pointsales.DL
{
    class MuserDL
    {
        public static List<Muser> user = new List<Muser>();
        public static void AddUser(Muser temp)
        {
            user.Add(temp);
        }
        public static string CheckUser(Muser temp)
        {
            string roll=" ";
            foreach (Muser i in user)
            {
                if (i.name == temp.name)
                {
                    roll= i.Roll;
                    break;
                }
            }
            return roll;
        }
    public static void UserDataToFile() 
    {
        string path = "user.txt";
        StreamWriter file=new StreamWriter(path,false);
        foreach (Muser i in MuserDL.user)
        {
        file.WriteLine(i.name+","+i.password+","+i.Roll);
        }
        file.Flush();
        file.Close();
    }
    public static void UserDatafromFile()
        {

            string path = "user.txt";
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string password = splittedRecord[1];
                    string role = splittedRecord[2];
                    //int subjectFees = int.Parse(splittedRecord[3]);
                    Muser s = new Muser(name, password, role);
                    AddUser(s);
                }
                file.Close();
            }
        } 

    }
}
