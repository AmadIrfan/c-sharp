using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.NewFolder1
{
    class Student
    {
        public string name;
        public int age;
        public double fscMarks;
        public double ecatMarks;
        public double Merit;
        public List<DegreeProgram> prefrences;
        public List<Subject> regSubject;
        public DegreeProgram regDegree;
        public Student(string name, int age, double fscmarks, double ecat, List<DegreeProgram> preferences)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscmarks;
            this.ecatMarks = ecat;
            this.prefrences = preferences;
            regSubject = new List<Subject>();
        }
        public void calculateMerit()
        {
            this.Merit = (((fscMarks / 1100) * 0.45F) + ((ecatMarks / 400) * 0.55F)) * 100;
        }
        public bool regStudentSubject(Subject s)
        {
            int stCH = getCreditHours();
            if (regDegree != null && regDegree.isSubjectExists(s) && stCH + s.creditHours <= 9)
            {
                regSubject.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int getCreditHours()
        {
            int count = 0;
            foreach (Subject sub in regSubject)
            {
                count = count + sub.creditHours;
            }
            return count;
        }
        public float calculateFee()
        {
            float fee = 0;
            if (regDegree != null)
            {
                foreach (Subject sub in regSubject)
                {
                    fee = fee + sub.subjectFees;
                }
            }
            return fee;
        }
    }
}
