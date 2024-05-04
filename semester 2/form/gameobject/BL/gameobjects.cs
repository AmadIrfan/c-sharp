using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameObject.BL;

namespace GameObject.BL
{
    class gameobjects
    {
        private char[,] shape;
        private point starting;
        private Boundary permises;
        private string direction;

        public gameobjects()
        {
            shape = new char[5, 3] {{ '@',' ',' '},
                                    { '@','@',' '},
                                    { '@','@','@'},
                                    { '@','@',' '},
                                    { '@','@',' '}};

            starting = new point();
            permises = new Boundary();

            direction = "LeftToRight";
        }

        public gameobjects(char[,] shape, point starting, Boundary permises, string direction)
        {
            this.shape = shape;
            this.starting = starting;
            this.permises = permises;
            this.direction = direction;
        }

        public char[,] getShape()
        {
            return shape;
        }
        public point getStartingPoint()
        {
            return starting;
        }
        public Boundary getPermises()
        {
            return permises;
        }
        public string getDirection()
        {
            return direction;
        }

        public void MoveLeftToRight()
        {
            point botttomRight = permises.getPointBottomRight();

            if (starting.getX() < botttomRight.getX())
            {
                int x = starting.getX();
                x++;
                starting.setX(x);
            }
        }
        public void MoveRightToLeft()
        {
            point bottomLeft = permises.getPointBottomLeft();

            if (starting.getX() > bottomLeft.getY())
            {
                int x = starting.getX();
                x--;
                starting.setX(x);
            }
        }
        int flag = 0;

        public void patrol()
        {
            point botttomRight = permises.getPointBottomRight();

            if (starting.getX() < botttomRight.getX() && flag == 0)
            {
                int x = starting.getX();
                x++;
                starting.setX(x);
            }
            else
            {
                flag = 1;
            }

            point topLeft = permises.getPointTopLeft(); 

            if (starting.getX() > topLeft.getX() && flag == 1)
            {
                int x = starting.getX();
                x--;
                starting.setX(x);
            }
            else
            {
                flag = 0;
            }
        }

        public void projectile()
        {
            point topLeft = permises.getPointTopLeft();

            if (starting.getX() > topLeft.getX() )
            {
                flag++;
                if (flag <= 5)
                {
                    int x = starting.getX();
                    x++;
                    starting.setX(x);

                    int y = starting.getY();
                    y--;
                    starting.setX(y);

                }
                else if (flag <= 7)
                {
                    int x = starting.getX();
                    x++;
                    starting.setX(x);
                }
                else if (flag <= 11)
                {
                    int x = starting.getX();
                    x++;
                    starting.setX(x);

                    int y = starting.getY();
                    y++;
                    starting.setX(y);
                }
            }
        }

        public void Diagonal()
        {
            point botttomRight = permises.getPointBottomRight();

            if (starting.getX() < botttomRight.getX() && starting.getY() < botttomRight.getY() )
            {
                int x = starting.getX();
                x++;
                starting.setX(x);

                int y = starting.getY();
                y++;
                starting.setX(y);
            }
        }

        public void Move()
        {
            if (direction == "LeftToRight")
            {
                MoveLeftToRight();
            }
            if (direction == "RightToLeft")
            {
                MoveRightToLeft();
            }
            if (direction == "Patrol")
            {
                patrol();
            }
            if (direction == "Diagonal")
            {
                Diagonal();
            }
            if (direction == "Projectile")
            {
                projectile();
            }

        }

        public void Draw()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(starting.getX(), starting.getY() + i);
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(shape[i, j]);
                }
            }
        }

        public void Erase()
        {
            if (direction == "LeftToRight")
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(starting.getX() - 1, starting.getY() + i);
                    Console.Write(" ");
                }
            }
            if (direction == "RightToLeft")
            {
                for (int i = 0; i < 5; i++)
                {

                    Console.SetCursorPosition(starting.getX() + 3, starting.getY() + i);
                    Console.Write(" ");
                }

            }
            if (direction == "Diagonal")
            {
                

                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(starting.getX() - 1, starting.getY() + i - 1);
                    Console.Write(" ");
                }
            }
            if (direction == "Projectile")
            {
                if (flag <= 5)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.SetCursorPosition(starting.getX() - 1, starting.getY() + i + 1);
                        
                        Console.Write(" ");
                    }
                }
                else if( flag <= 7)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.SetCursorPosition(starting.getX() - 1, starting.getY() + i);
                        Console.Write(" ");
                    }

                }
                else if(flag <= 11)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.SetCursorPosition(starting.getX() - 1, starting.getY() + i - 1);
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}

