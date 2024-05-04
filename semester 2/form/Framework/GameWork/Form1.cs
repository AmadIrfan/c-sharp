using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrameWork.Core;
//using EZInput;
using FrameWork.Movement;

namespace GameWork
{
    public partial class GameForm : Form
    {
        public bool goup=false;
        public bool godown=false;
        public bool goleft=false;
        public bool goright=false;
        public Game go;
        public GameForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Point boundry=new Point(this.Width,this.Height); 
            this.BackgroundImage = GameWork.Properties.Resources.background;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            go = new Game(4);
            go.OnAddingGsmeObject += new EventHandler(AddIntoControals);
            go.AddGameObject(GameWork.Properties.Resources.image, 200, 20, new Keyboard(5, boundry));
            go.AddGameObject(GameWork.Properties.Resources.Dead1__1_, 100, 20,new Horizontal(15,boundry, "right"));
            go.AddGameObject(GameWork.Properties.Resources.Attack1__1_, 200, 20,new Horizontal(15,boundry, "right"));
            go.AddGameObject(GameWork.Properties.Resources.Attack1__1_, 200, 20,new Horizontal(15,boundry, "right"));
        }

        private void AddIntoControals(object sender, EventArgs e)
        {
            this.Controls.Add((PictureBox)sender);
        }
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            go.KeyPressed(e.KeyCode); 
        }
        private void GameTimer_Tick_1(object sender, EventArgs e)
        {
            go.objmove();
            if (goup == true)
            {
            } 
            if (goleft == true)
            {
            }
        }
    }
}
