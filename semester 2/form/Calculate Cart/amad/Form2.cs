using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using amad.BL;
using amad.DL;

namespace amad
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("are you sure ?","warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
if (result == DialogResult.OK)
            {
            string nameOfCart,nameEntity1, nameEntity2, nameEntity3, nameEntity4;
            string priceEntity1, priceEntity2, priceEntity3, priceEntity4;
            nameOfCart = textBox1.Text;
            nameEntity1= textBox2.Text;
            priceEntity1 = textBox3.Text;
            nameEntity2= textBox4.Text;
            priceEntity2 = textBox5.Text;
            nameEntity3= textBox6.Text;
            priceEntity3 = textBox7.Text;
            nameEntity4= textBox8.Text;
            priceEntity4 = textBox9.Text;
            SaveData Data = new SaveData(nameOfCart,nameEntity1,priceEntity1,nameEntity2,priceEntity2,nameEntity3,priceEntity3,nameEntity4,priceEntity4);
            SaveDataDL.AddTolist(Data);     
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure? to continue... ","warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
      if(result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
