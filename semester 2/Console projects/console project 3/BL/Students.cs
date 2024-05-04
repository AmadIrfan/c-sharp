using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newData.BL
{
    internal class Students
    {
       public String name;
        public String Father_name;
        public String Collage;
        public int id;
        public int age;
       public Students(String name,String father_name,String collage ,int id,int age)
        {
            this.name=name;
            this.Father_name=father_name;
            this.Collage=collage;
            this.id=id;
            this.age=age;
        }
    }
}
