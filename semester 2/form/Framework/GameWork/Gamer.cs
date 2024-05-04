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
using FrameWork.Movement;

namespace GameWork
{
    public partial class Gamer : Form
    {
        player ply;
        private bool endpoint;
        private int Value;
        private int Score;
        private readonly Random rendom = new Random();
        ProgressBar playerhealth;
        ProgressBar ScoreBar;
        public Game go;
        private int life=100;
        public Gamer()
        {
            playerhealth = new ProgressBar();
            ScoreBar = new ProgressBar(); 
            InitializeComponent();
        }

        private void Gamer_Load(object sender, EventArgs e)
        {
            go = new Game(4);
            Point boundry = new Point(this.Width, 250);
            addControals();
            go.OnAddingGsmeObject += new EventHandler(AddIntoControals);
         //   go.addBullets(GameWork.Properties.Resources.Bullet__1_,390,20,5);
         ply= go.NewPlayer(GameWork.Properties.Resources.player, 400, 20, new Keyboard(5, boundry));
            go.finalpoint(GameWork.Properties.Resources.door_closed, 300, 700);
            go.AddGameObject(GameWork.Properties.Resources.image__2_, 400, 700, new Horizontal(5, boundry, "left"));
        }

        private void AddIntoControals(object sender, EventArgs e)
        {
            this.Controls.Add((PictureBox)sender);
        }
        private void MainTime_Tick(object sender, EventArgs e)
        {
            int rnumber = RandomNumber(0, 10000);
            rnumber = rnumber % 2;
            int fnum = RandomNumber(0, 1000);
            fnum =fnum%9;
            endpoint = go.ReachedFinelPoint();
            go.OnAddingGsmeObject += new EventHandler(AddIntoControals);
            Point boundry = new Point(this.Width, 250);
            Score=go.checkCollisionWithBullets();
            ScoreBar.Value = Score;
            Value= go.collision();
            go.objmove();
            if (Value>=0) { 
            playerhealth.Value = Value;
            }
            if (rnumber == 0)
            {
                go.AddGameObject(GameWork.Properties.Resources.image__2_, 400, 700, new Horizontal(3, boundry, "left"));
            }
            if (fnum ==0)
            {
              go.addBullets(GameWork.Properties.Resources.Bullet__1_,ply.Pb.Top+10,ply.Pb.Left,10);

            }
           /* if (Value==0||endpoint==true)
            {
                newformOpen();
            }*/
            go.fireBullet();

        }
        private void Gamer_KeyDown(object sender, KeyEventArgs e)
        {
            go.KeyPressed(e.KeyCode);
         }
        private void addControals()
        {
            Label lblplayer = new Label();
            Label lblscore = new Label();
            Font font = new Font("Times New Roman", 15.4f);
            lblplayer.Text = "Player Health ";
            lblplayer.BackColor = Color.Transparent;
            lblplayer.Top = 28;
            lblplayer.Left = 120;
            lblplayer.Font = font;
            lblplayer.ForeColor = Color.White;
            lblscore.Text = "Score : ";
            lblscore.ForeColor = Color.White;
            lblscore.BackColor = Color.Transparent;
            lblscore.Font = font;
            lblscore.Top = 28;
            lblscore.Left = 550;
            playerhealth.Top = 50;
            playerhealth.Left = 120;
            ScoreBar.Value =0;
            ScoreBar.Top = 50;
            ScoreBar.Left = 550;
            this.Controls.Add(playerhealth);
            this.Controls.Add(ScoreBar);
            this.Controls.Add(lblscore);
            this.Controls.Add(lblplayer);
        }
        public int RandomNumber(int min, int max)
        {
            return rendom.Next(min, max);
        }
      public void newformOpen()
        {
            
            endpoint = false; 
                over ov = new over(Score,life);
                ov.Show();
                this.Hide();
        }
    }
}
