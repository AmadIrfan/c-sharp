using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWork
{
    public partial class over : Form
    {
        private int score;
        private int lives;
        public over(int score,int lives)
        {
            this.score = score;
            this.lives = lives;
            InitializeComponent();
        }

        private void over_Load(object sender, EventArgs e)
        {
            LblScore.Text=score.ToString();
            lbllifes.Text=lives.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm mainForm = new mainForm();
            this.Hide();
            mainForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Gamer gamer = new Gamer();
        }
    }
}
