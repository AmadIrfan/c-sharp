using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.BL
{
    class room
    {
        public string roomname;
        public string roomprice;
        public int numberofdays;
        public room(string roomname,int numberofdays)
        {
            this.roomname = roomname;
            this.numberofdays = numberofdays;
        }
        public room(string roomname)
        {
            this.roomname = roomname;
        }
        public room(string roomname,string roomprice)
        {
            this.roomname = roomname;
            this.roomprice = roomprice;
        }
        public room(int numberofdays)
        {
            this.numberofdays = numberofdays;
        }
        public room()
        {

        }
    }
}
