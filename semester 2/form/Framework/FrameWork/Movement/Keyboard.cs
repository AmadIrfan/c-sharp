using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FrameWork.Movement
{
    public class Keyboard : Imovement
    {
        private bool gravity = false;
        private int count = 0;
        private int speed;
        private Point boundry;
        private string ArrowAction = null;
        public Keyboard(int speed, Point boundry)
        {
            this.speed = speed;
            this.boundry = boundry;
        }
        public Point move(Point Location)
        {
            if (ArrowAction != null)
            {
                if (gravity == false)
                {
                    if (ArrowAction == "up")
                    {
                        gravity = true;
                    }
                }
                if (ArrowAction == "left")
                {
                    Location.X -= speed;
                }
                if (ArrowAction == "right")
                {
                    Location.X += speed;
                }
                ArrowAction = null;
            }
            if (gravity == true)
            {
                count++;
                Location.Y -= 5;
                if (count == 10)
                {
                    
                    gravity = false;
                    count = 0;
                }
            }
                   return Location;
        }     
        public void keyPressedByuser(Keys keycodes)
        {
            if (keycodes==Keys.Up)
            {
                ArrowAction = "up";
            }
            if (keycodes==Keys.Down)
            {
                ArrowAction = "down";
            }
            if (keycodes==Keys.Left)
            {
                ArrowAction = "left";
            }
            if (keycodes==Keys.Right)
            {
                ArrowAction = "right";
            }
            if (keycodes==Keys.Space)
            {
                ArrowAction = "space";
            }
        }
    }
}
