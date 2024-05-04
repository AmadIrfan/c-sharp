using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace ums.BL
{
    class student
    {
        public string name;
        public int age;
        public double fscMarks;
        public double ecatMarks;
        public double merit;
        public degreeProgram registerDegree;
        public student(string name, int age, double fscMarks, double ecatMarks,List<degreeProgram> preferences)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
        }
        public void calculateMerit()
        {
        }
        public int getCreditHours()
        {
            return 7;
        }
        public float calculateFee()
        {
            return 5;
        }

        /*bool regStudentSubject(subject s)
        {
            int stCH = getCreditHours();
            if (registerDegree != null && registerDegree.isSubjectExists(s) && stCH + s.creditHours <= 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }
}
