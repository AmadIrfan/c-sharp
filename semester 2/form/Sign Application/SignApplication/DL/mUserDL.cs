using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignApplication.BL;
using System.IO;

namespace SignApplication.DL
{
    internal class mUserDL
    {
        public static List<mUser> mUserList = new List<mUser>();

        public static void addInList(mUser obj)
        {
            mUserList.Add(obj);
        }

        public static void addInFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            for(int i = 0;i < mUserList.Count; i++)
            {
                file.WriteLine(mUserList[i].UserName + "," + mUserList[i].Password + "," + mUserList[i].Role);

            }
            file.Flush();
            file.Close();
        }

        public static bool loadFromFile(string path)
        {
            StreamReader file = new StreamReader(path);
            if(File.Exists(path))
            {
                string record;
                while((record = file.ReadLine())!=  null)
                {
                    string[] splittedRecord = record.Split(',');
                    string userName = splittedRecord[0];
                    string password = splittedRecord[1];
                    string role = splittedRecord[2];
                    mUser obj = new mUser(userName, password, role);
                    mUserList.Add(obj);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public static String checkUser(mUser user)
        {
            foreach(mUser obj in mUserList)
            {
                if(user.UserName== obj.UserName&& user.Password == obj.Password)
                {
                    return obj.Role;
                }
            }
            return null;
        }
    }
}
