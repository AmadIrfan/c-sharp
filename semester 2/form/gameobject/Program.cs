using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameObject.BL;
using GameObject.DL;

namespace GameObject
{
    class Program
    {
        static void Main(string[] args)
        {
            point point1 = new point(10, 10);
            char[,] shape = new char[5, 3] {{ '@',' ',' '},
                                            { '@','@',' '},
                                            { '@','@','@'},
                                            { '@','@',' '},
                                            { '@',' ',' '}};

            point point2 = new point(20, 20);
            char[,] shape1 = new char[5, 3] {{ ' ',' ','@'},
                                             { ' ','@','@'},
                                             { '@','@','@'},
                                             { ' ','@','@'},
                                             { ' ',' ','@'}};
            
            Boundary b = new Boundary();

            gameobjects ob = new gameobjects(shape, point1, b, "LeftToRight");
            gameobjects ob1 = new gameobjects(shape1, point2, b, "RightToLeft");



            gameObjectDL.AddObject(ob);
            gameObjectDL.AddObject(ob1);

            while (true)
            {
                foreach(gameobjects o in gameObjectDL.objectList)
                {
                    System.Threading.Thread.Sleep(100);
                    o.Move();
                    o.Draw();
                    o.Erase();
                }
            }
        }
    }
}
