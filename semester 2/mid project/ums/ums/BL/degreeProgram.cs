using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ums.BL
{
    class degreeProgram
    {
        
          public string degreeName;
          public float degreeDuration;
          public int seats;
        public degreeProgram()
        {
            
        }
        public degreeProgram(string degreeName,float degreeDuration,int seats)
        {
            this.degreeName = degreeName;
            this.degreeDuration = degreeDuration;
            this.seats = seats;

        }
    }
}
