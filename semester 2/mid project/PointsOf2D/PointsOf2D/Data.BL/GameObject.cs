using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsOf2D.Data.BL
{
    class GameObject
    {
        public char[,] Shape = new char[10, 10];
        public Point StraightPoint = new Point();
        public Boundary Premises = new Boundary();
        public string Direction;
        public GameObject()
        {

        }
        public GameObject(char[,] Shape, Point StraightPoint, string Direction, Boundary Premises)
        {
            this.Shape = Shape;
            this.StraightPoint = StraightPoint;
            this.Premises = Premises;
            this.Direction = Direction;
        }
        public static void Move()
        {

        }
        public static void Erase()
        {

        }
        public static void direction()
        {

        }
    }
}
