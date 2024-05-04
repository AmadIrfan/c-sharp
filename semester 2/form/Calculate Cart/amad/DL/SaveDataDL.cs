using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using amad.BL;

namespace amad.DL
{
    internal class SaveDataDL
    {
        public static List<SaveData> DataList= new List<SaveData>();
        public static void AddTolist(SaveData temp)
        {
            DataList.Add(temp);
        }
    }
}
