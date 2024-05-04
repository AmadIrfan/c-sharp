using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GameWork.Core
{
    public class GameObject
    {
        private PictureBox pb;   

        public GameObject(Image img ,int top,int left)
        {
            Pb = new PictureBox();
            Pb.Image = img;
            Pb.Width =img.Width ;
            Pb.Height=img.Height;
            pb.Top = top ;
            pb.Left = left ;
            Pb.BackColor = Color.Transparent;
        }

        public PictureBox Pb {
            get => pb;
            set => pb = value;
        }

        public void update(int gravity)
        {
            Pb.Top+= gravity;
        }

    }
}
