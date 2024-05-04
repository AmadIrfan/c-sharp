using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.NewFolder1
{
    class DegreeProgram
    {
        public string degreeName;
        public float degreeDuration;
        public List<Subject> subjects;
        public int seats;

        public DegreeProgram(string degreename, float degreeduration, int seats)
        {
            this.degreeName = degreename;
            this.degreeDuration = degreeduration;
            this.seats = seats;
            subjects = new List<Subject>();
        }
        public int CalculateCreditHours()
        {
            int count = 0;
            for (int i = 0; i < subjects.Count; i++)
            {
                count = count + subjects[i].creditHours;
            }
            return count;
        }
        public bool AddSubject(Subject s)
        {
            int credithours = CalculateCreditHours();
            if (credithours + s.creditHours <= 20)
            {
                subjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isSubjectExists(Subject sub)
        {
            foreach (Subject s in subjects)
            {
                if (s.code == sub.code)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
