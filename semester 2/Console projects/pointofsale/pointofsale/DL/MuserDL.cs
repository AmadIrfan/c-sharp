using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointofsale.BL;
using pointofsale.UI;

namespace pointofsale.DL
{
    class MuserDL
    {
        public static List<Muser> user = new List<Muser>();
        public static void AddUser(Muser temp)
        {
            user.Add(temp);
        } 
    public static string checkUser(Muser temp)
    {
        foreach (Muser i in user) 
        {
                if (i.name==temp.name) {
                    return i.Roll;
                }
        }
            return "";
    }
    }
   
}
