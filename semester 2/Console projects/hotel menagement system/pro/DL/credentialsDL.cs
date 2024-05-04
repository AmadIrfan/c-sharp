using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pro.BL;
using pro.UI;
using System.IO;


namespace pro.DL
{
    class credentialsDL
    {
        public static List<credentials> credentialslist = new List<credentials>();
        public static void store(credentials stu1, string credentialpath)
        {
            StreamWriter f = new StreamWriter(credentialpath, true);
            f.WriteLine(stu1.username + "," + stu1.password + "," + stu1.role);
            f.Flush();
            f.Close();
        }
        public static bool readFromFile(string path)
        {
            string record;
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string username = splittedRecord[0];
                    string password = splittedRecord[1];
                    string role = splittedRecord[2];
                    credentials c = new credentials(username, password, role);
                    credentialslist.Add(c);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string searchforsignin(credentials cc)
        {
            bool found = false;
            foreach (credentials c in credentialslist)
            {

                if (cc.username == c.username && cc.password == c.password)
                {
                    found = true;
                    return c.role;
                    break;
                }
            }
            if (found == false)
            {
                UI.credentialsUI.sfun();
            }
            return null;
        }

    }
}
