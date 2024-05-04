using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointsales.DL;
using pointsales.UI;
namespace pointsales.BL
{
    class Muser
    {
        public string name;
        public string password;
        public string Roll;
        public Muser(string name, string password, string Roll)
        {
            this.name = name;
            this.password = password;
            this.Roll = Roll;
        }
        public Muser(string name, string password)
        {
            this.name = name;
            this.password = password;
            this.Roll = "NA";
        }
    }
}
