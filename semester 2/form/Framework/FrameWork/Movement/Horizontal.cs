using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FrameWork.Movement
{
    public class Horizontal:Imovement
    {
        private int speed;
        private Point boundry;
        private string direction;
        public Horizontal(int speed, Point boundry, string direction)
        {
            this.speed = speed;
            this.boundry = boundry;
            this.direction = direction;
        }
        public Point move(Point Location)
        {
            if (Location.X<=0)
            {
                direction = "right";
            }
            if (Location.X>=boundry.X)
            {
                direction = "left";
            }
            if ( direction=="left")
            {
                Location.X -=speed;
            }
            if ( direction=="right")
            {
               Location.X +=speed;
            }
            return Location;
        }

    }
}
