using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointsOf2D.Data.BL;

namespace PointsOf2D
{
    class Program
    {
        
        static void Main(string[] args)
        {
            char[,] triangle = new char[5, 3] { { '@', ' ', ' ' }, { '@', '@', ' ' }, { '@', '@', '@' }, { '@', '@', ' ' }, { '@', ' ', ' ' } };
            char[,] opTriangle = new char[5, 3] { { ' ', ' ', '@' }, { ' ', '@', '@' }, { '@', '@', '@' }, { ' ', '@', '@' }, { ' ', ' ', '@' } };
            Boundary b = new Boundary(new Point(0, 0), new Point(0, 90), new Point(90, 0), new Point(90, 90));
            GameObject g1 = new GameObject(triangle, new Point(5, 5), "LeftToRight", b);
            GameObject g2 = new GameObject(opTriangle, new Point(30, 60), "RightToLeft", b);
            List<GameObject> lst = new List<GameObject>();
            lst.Add(g1);
            lst.Add(g2);
            while (true)
            {
                Thread.Sleep(2000);
                foreach(GameObject g in lst)
                {
                    g.Erase();
                    g.Move();
                    g.Draw();
                }
            }
        }
    }
}
