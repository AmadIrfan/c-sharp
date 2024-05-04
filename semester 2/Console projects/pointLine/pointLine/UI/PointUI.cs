using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointLine.DL;
using pointLine.BL;
namespace pointLine.UI
{
    class PointUI
    {
        public static Point getFromConsole(string point)
        {
            Console.Write("Enter X Coordinate of " + point + " Point: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter Y Coordinate of " + point + " Point: ");
            int y = int.Parse(Console.ReadLine());
            Point MyPoint = new Point(x, y);
            return MyPoint;
        }

        public static void displayPoint(Point point)
        {
            string x = point.getX().ToString();
            string y = point.getY().ToString();
            Console.WriteLine("(x,y) = " + x + "," + y);
        }

        public static void DistanceFromZero(string type, Point Point)
        {
            Console.WriteLine("Distance of " + type + " Point from Zero: {0}", Point.distanceFromZero());
        }

    }
}
