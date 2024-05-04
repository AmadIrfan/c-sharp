using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ums1.classes.BL
{
    class student
    {
        public string name;
        public int roll_no=0;
        public float Cgpa=0;
        public int M_marks=0;
        public int F_marks=0;
        public int E_marks=0;
        public string HomeTown;
        public bool IsHostelite;
        public bool IsTakingScholarship;
       public student(string name,int roll_no,float Cgpa,int M_marks,int F_marks,int E_marks,string HomeTown,bool IsHostelite)
        {
            this.name = name;
            this.roll_no = roll_no=0;
            this.Cgpa = Cgpa;
            this.M_marks = M_marks;
            this.F_marks = F_marks;
            this.E_marks = E_marks;
            this.HomeTown = HomeTown;
            this.IsHostelite = IsHostelite;
        }
        public float calculateMerit()
        {
            float merit;
       merit= ((F_marks/1100*0.70F)+(E_marks/ 1100 * 0.30F))*100;
            return merit;
        }
        public bool iseligibleforscolership(float merit)
        {
            if (merit > 80 && IsHostelite == true) { 
          
                return true;
            }
           
            return false;
        }
    }
}
