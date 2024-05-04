using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Line.PointLine.BL
{
    class Point
    {
        
        public int x;
        public int y;

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public void setXY(int x, int y)
        {
            setX(x);
            setY(y);
        }
        public double distanceFromCoordinates(int x, int y)
        {
            double distance = Math.Sqrt(Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2));
            return distance;
        }
        public double distanceFromObject(Point Point)
        {
            double distance = Math.Sqrt(Math.Pow(this.x - Point.x, 2) + Math.Pow(this.y - Point.y, 2));
            return distance;
        }
        public double distanceFromZero()
        {
            double distance = Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
            return distance;
        }
    }
}
