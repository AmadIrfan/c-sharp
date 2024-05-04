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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Shopping cart";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show(" Are you sure ?"," Warning ",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                 this.Close();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            float num = 0,num1=0,total=0;
            num = float.Parse(textBox1.Text);
            num1= float.Parse(label7.Text);
            total = num * num1;
            label11.Text = total.ToString();
            totalCount.Text = (int.Parse(label11.Text) + int.Parse(label12.Text) + int.Parse(label13.Text) + int.Parse(label14.Text)).ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            float num = 0, num1 = 0, total = 0;
            num = float.Parse(textBox2.Text);
            num1 = float.Parse(label8.Text);
            total = num * num1;
            label12.Text = total.ToString();
            totalCount.Text = (int.Parse(label11.Text)+ int.Parse(label12.Text)+ int.Parse(label13.Text)+ int.Parse(label14.Text)).ToString();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            float num = 0, num1 = 0, total = 0;
            num = float.Parse(textBox3.Text);
            num1 = float.Parse(label9.Text);
            total = num * num1;
            label13.Text = total.ToString();
            totalCount.Text = (int.Parse(label11.Text) + int.Parse(label12.Text) + int.Parse(label13.Text) + int.Parse(label14.Text)).ToString();

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            float num = 0, num1 = 0, total = 0;
            num = float.Parse(textBox4.Text);
            num1 = float.Parse(label10.Text);
            total = num * num1;
            label14.Text = total.ToString();
            totalCount.Text = (int.Parse(label11.Text) + int.Parse(label12.Text) + int.Parse(label13.Text) + int.Parse(label14.Text)).ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = 0.ToString();
            textBox2.Text = 0.ToString();
            textBox3.Text = 0.ToString();
            textBox4.Text = 0.ToString();
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
           textBox1.SelectAll();
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
           textBox2.SelectAll();
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
           textBox3.SelectAll();

        }
        private void textBox4_Click(object sender, EventArgs e)
        {
           textBox4.SelectAll();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
            label7.Text = SaveDataDL.DataList[0].priceEntity1;
            label8.Text = SaveDataDL.DataList[0].priceEntity2;
            label9.Text = SaveDataDL.DataList[0].priceEntity3;
            label10.Text = SaveDataDL.DataList[0].priceEntity4;
            label1.Text = SaveDataDL.DataList[0].nameOfCart;
            label3.Text = SaveDataDL.DataList[0].nameEntity1;
            label4.Text = SaveDataDL.DataList[0].nameEntity2;
            label5.Text = SaveDataDL.DataList[0].nameEntity3;
            label6.Text = SaveDataDL.DataList[0].nameEntity4;
            textBox1.Text = 0.ToString();
            textBox2.Text = 0.ToString();
            textBox3.Text = 0.ToString();
            textBox4.Text = 0.ToString();
            label11.Text = 0.ToString();
            label12.Text = 0.ToString();
            label13.Text = 0.ToString();
            label14.Text = 0.ToString();
        }

        private void linkLabel1remove_Click(object sender, EventArgs e)
        {
            textBox1.Text = 0.ToString();
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            textBox2.Text = 0.ToString();           
        }

        private void linkLabel3_Click(object sender, EventArgs e)
        {
            textBox3.Text = 0.ToString();
        }

        private void linkLabel4_Click(object sender, EventArgs e)
        {
            textBox4.Text = 0.ToString();
        }
    }
}
