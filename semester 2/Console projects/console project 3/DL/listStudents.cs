using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using newData.BL;
using newData.DL;

namespace newData.DL
{
    internal class listStudents
    {
        public static  List<Students> Data=new List<Students>();

        public static bool AddStudentstoList(Students temp) {
        Data.Add(temp);
            return true; 
        }
    }
}
