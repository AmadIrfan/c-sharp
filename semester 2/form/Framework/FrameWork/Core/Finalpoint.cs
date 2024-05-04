using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FrameWork.Core
{
    public class Finalpoint
    {
       private PictureBox key;
        public Finalpoint(Image img,int top,int left){
            Key = new PictureBox();   
            Key.Image = img;
            Key.Top = top;
            Key.Left = left;
            Key.Width = img.Width;
            Key.Height = img.Height;
            Key.BackColor = Color.Transparent;
        }

        public PictureBox Key { get => key; set => key = value; }
    }
}
