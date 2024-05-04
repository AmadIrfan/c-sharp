using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FrameWork.Fire
{
    internal class fire 
    {
        private int speed;
        private string direction;
        private PictureBox pictureBox;
        public fire(Image img,int top,int left, int speed)
        {
            PictureBox = new PictureBox();
            PictureBox.Image = img;
            pictureBox.Top = top;
            pictureBox.Left = left;
            this.Speed = speed;
            PictureBox.Width = img.Width;
            PictureBox.Height = img.Height;
            PictureBox.BackColor = Color.Transparent;
        }
        public int Speed
        {
            get => speed;
            set => speed = value;
        }
        public string Direction { get => direction; set => direction = value; }
        public PictureBox PictureBox { get => pictureBox; set => pictureBox = value; }
        public bool Updatefire()
        {
            pictureBox.Left += speed;
            return true;
        }
    }
}