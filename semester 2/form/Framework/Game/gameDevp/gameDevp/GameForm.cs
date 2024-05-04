using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;
namespace gameDevp
{
    public partial class lblnum : Form
    {
        int score=0;
        PictureBox player;
            string EnemyDirection1 = "Left";
        PictureBox enemy1;
        PictureBox enemy2;
        PictureBox enemy3;
        PictureBox enemy;
        public lblnum()
        {
            InitializeComponent();
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            CreatePlayer();
            Createenemy1();
            label1.Text =score.ToString() ;
            lblscore.Text = "Score : ";
          //  Createenemy2();
          //  Createenemy3();
          //  Createenemy4();
        }
        private void CreatePlayer()
        {
            player =new PictureBox();
            Image img = gameDevp.Properties.Resources.Idle__000;
            player.Image = img;
            player.Width = img.Width;
            player.Height = img.Height;
            player.Top = this.Top + 20;
            this.Controls.Add(player);
            player.BackColor = Color.Transparent;
        }
        private void Createenemy1()
        {
        enemy1= new PictureBox();
            Image img = gameDevp.Properties.Resources.Attack6__1_;
            enemy1.Image = img;
            enemy1.Width = img.Width;
            enemy1.Height = img.Height;
            enemy1.Top = this.Top + 230;
            this.Controls.Add(enemy1);
            enemy1.BackColor = Color.Transparent;
        } private void Createenemy2()
        {
        enemy1= new PictureBox();
            Image img = gameDevp.Properties.Resources.Attack6__1_;
            enemy1.Image = img;
            enemy1.Width = img.Width;
            enemy1.Height = img.Height;
            enemy1.Top = this.Top + 230;
            this.Controls.Add(enemy1);
            enemy1.BackColor = Color.Transparent;
        } private void Createenemy3()
        {
        enemy1= new PictureBox();
            Image img = gameDevp.Properties.Resources.Attack6__1_;
            enemy1.Image = img;
            enemy1.Width = img.Width;
            enemy1.Height = img.Height;
            enemy1.Top = this.Top + 230;
            this.Controls.Add(enemy1);
            enemy1.BackColor = Color.Transparent;
        } private void Createenemy4()
        {
        enemy1= new PictureBox();
            Image img = gameDevp.Properties.Resources.Attack6__1_;
            enemy1.Image = img;
            enemy1.Width = img.Width;
            enemy1.Height = img.Height;
            enemy1.Top = this.Top + 230;
            this.Controls.Add(enemy1);
            enemy1.BackColor = Color.Transparent;
        }
        private void GameLoop_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                player.Image = gameDevp.Properties.Resources.Idle__000;
                player.Left = player.Left + 10;
            }
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                player.Image = gameDevp.Properties.Resources.image__1_;
                player.Left = player.Left - 10;
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                if (player.Bottom!=panel2.Top)
                {
                player.Top = player.Top+10;
                }

            } 
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
           player.Top=player.Top-10;    
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                player.Top = player.Top - 5;
                player.Left = player.Left + 15;
            }
            if (EnemyDirection1=="Left")
            {
                enemy1.Left = enemy1.Left + 10;
            }
            if (EnemyDirection1=="Right")
            {

            }
        }
    }
}
