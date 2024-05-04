using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalper.BL
{
     class student : person,istudent
     {
        public int rollNo;
        public string fees;
        public student(string fname,string lname,int rollNo, string fees) : base(fname,lname)
        {    
            this.rollNo = rollNo;
            this.fees = fees;
        }
        public override void printDetail()
        {
            string name = firstName + " " + lastName;
            Console.WriteLine("student Name {0} ", name);
            Console.WriteLine("student roll no {0} ", rollNo);
            Console.WriteLine("student fees {0} ", fees);
        }
        public  void  updateFees(int UF)
        {
            Console.WriteLine("Student updated fees {0} ", UF);
        }
     }
}
