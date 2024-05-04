using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using FrameWork.Movement;
using FrameWork.Fire;

namespace FrameWork.Core
{
    public class GameObject
    {
        private PictureBox pb;
        private Imovement movement;
        public GameObject(Image img, int top, int left,Imovement movement)
        {
            Pb = new PictureBox();
            Pb.Image = img;
            Pb.Width = img.Width;
            Pb.Height = img.Height;
            Pb.Top = top;
            Pb.Left = left;
            Pb.BackColor = Color.Transparent;
          this.Movement=movement;
        }
        public GameObject(Image img, int top, int left)
        {
            Pb = new PictureBox();
            Pb.Image = img;
            Pb.Width = img.Width;
            Pb.Height = img.Height;
            Pb.Top = top;
            Pb.Left = left;
            Pb.BackColor = Color.Transparent;
        }
        internal PictureBox Pb { 
            get => pb;
            set => pb = value;
        }
        public Imovement Movement
        {
            get => movement;
            set => movement = value; 
        }

        public void update()
        {
            pb.Left -= 6;
            if (pb.Left <= 0)
            {
             this.pb.Left = 700;
            }
        }
        
    }
}
