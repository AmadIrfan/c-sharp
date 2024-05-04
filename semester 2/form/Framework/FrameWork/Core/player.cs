using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrameWork.Movement;

namespace FrameWork.Core
{
    public class player
    {
        private PictureBox pb;
        private Imovement movement;
        private int speed = 2;
        public player(Image img,int top,int left,Imovement movement){
            Pb = new PictureBox();
            Pb.Image = img;
            Pb.Width = img.Width;
            Pb.Height = img.Height;
            Pb.Top = top;
            Pb.Left = left;
            pb.BackColor = Color.Transparent;
            this.Movement=movement;
        }
        public PictureBox Pb {
            get => pb;
            set => pb = value; 
        }
        public Imovement Movement 
        { get => movement; 
            set => movement = value;
        }
        public void moveplayer()
        {
            pb.Location = Movement.move(pb.Location);
        }
        public void gravity()
        {
            if (pb.Top+pb.Height<=460)
            {
            pb.Top += speed;
            }
        }
    }
}
