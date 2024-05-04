using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plane.Ships.BL
{
    class ships
    {
        public string Number;
        public string Longitude_Degree;
        public string Longitude_Minute;
        public char Longitude_Direction;
        public string Latitude_Degree;
        public string Latitude_Minute;
        public char Latitude_Direction;
        public ships(string Number, string Latitude_Degree, string Latitude_Minute,char Latitude_Direction, string Longitude_Degree, string Longitude_Minute, char Longitude_Direction) {
        this.Number= Number;
        this.Longitude_Degree= Longitude_Degree;
        this.Longitude_Minute= Longitude_Minute;
        this.Longitude_Direction= Longitude_Direction;
        this.Latitude_Degree= Latitude_Degree;
        this.Latitude_Minute= Latitude_Minute;
        this.Latitude_Direction= Latitude_Direction;
    }

    }
    
}
