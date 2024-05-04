using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Line.PointLine.BL
{
    class Line
    {
        public Line(Point First, Point Last)
        {
            this.First = First;
            this.Last = Last;
        }

        public Point First;
        public Point Last;

        public Point getFirst()
        {
            return First;
        }
        public Point getLast()
        {
            return Last;
        }
        public void setFirst(Point First)
        {
            this.First = First;
        }
        public void setLast(Point Last)
        {
            this.Last = Last;
        }
        public double getLine()
        {
            double distance = Math.Sqrt(Math.Pow(First.x - Last.x, 2) + Math.Pow(First.y - Last.y, 2));
            return distance;
        }
        public double getGradient()
        {
            double gradient = (First.y - Last.y) / (First.x - Last.x);
            return gradient;
        }
        public bool CheckGradient()
        {
            if (First.x - Last.x == 0)
            {
                return true;
            }
            return false;
        }
    }
}
