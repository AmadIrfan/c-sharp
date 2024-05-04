using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        int checkpoint = 0,checkoperator=0;
        public Form1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            label3.BorderStyle = BorderStyle.Fixed3D;
            view View = new view();
            View.Show();
            this.Hide();
            label1.BorderStyle = BorderStyle.None;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BorderStyle = BorderStyle.Fixed3D;
            this.Show();
            view View = new view();
            View.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Calculator ";
            button1.Text = "%";
            button2.Text=0.ToString();
            button3.Text=".";
            button4.Text="1";
            button5.Text="2";
            button6.Text="3";
            button7.Text="4";
            button8.Text="5";
            button9.Text="6";
            button10.Text ="=";
            button11.Text ="+";
            button12.Text ="-";
            button13.Text ="9";
            button14.Text ="8";
            button15.Text ="7";
            button16.Text ="CE";
            button17.Text ="1/x";
            button18.Text ="X^2";
            button19.Text ="/";
            button20.Text ="*";
            label1.BorderStyle= BorderStyle.Fixed3D;
            label3.BorderStyle = BorderStyle.None;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly=true;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                checkBox1.Text = "Light Mode ";
                this.BackColor = Color.White;
                label1.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                checkBox1.ForeColor = Color.Black;
                button1.ForeColor = Color.Black;
                button1.BackColor = Color.White;
                button2.ForeColor = Color.Black;
                button2.BackColor = Color.White;
                button3.ForeColor = Color.Black;
                button3.BackColor = Color.White ;
                button4.ForeColor = Color.Black;
                button4.BackColor = Color.White;
                button5.ForeColor = Color.Black;
                button5.BackColor = Color.White;
                button6.ForeColor = Color.Black;
                button6.BackColor = Color.White;
                button7.ForeColor = Color.Black;
                button7.BackColor = Color.White;
                button8.ForeColor = Color.Black;
                button8.BackColor = Color.White;
                button9.ForeColor = Color.Black;
                button9.BackColor = Color.White;
                button10.ForeColor = Color.Black;
                button10.BackColor = Color.White;
                button11.ForeColor = Color.Black;
                button11.BackColor = Color.White;
                button12.ForeColor = Color.Black;
                button12.BackColor = Color.White;
                button13.ForeColor = Color.Black;
                button13.BackColor = Color.White;
                button14.ForeColor = Color.Black;
                button14.BackColor = Color.White;
                button15.ForeColor = Color.Black;
                button15.BackColor = Color.White;
                button16.ForeColor = Color.Black;
                button16.BackColor = Color.White;
                button17.ForeColor = Color.Black;
                button17.BackColor = Color.White;
                button18.ForeColor = Color.Black;
                button18.BackColor = Color.White;
                button19.ForeColor = Color.Black;
                button19.BackColor = Color.White;
                button20.ForeColor = Color.Black;
                button20.BackColor = Color.White;
                textBox1.ForeColor = Color.Black;
                textBox1.BackColor = Color.White;
                textBox2.ForeColor = Color.Black;
                textBox2.BackColor = Color.White;
            }
            else
            {
                checkBox1.Text = "Dark Mode ";
                this.BackColor = Color.Black;
                label1.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                checkBox1.ForeColor = Color.White;
                button1.ForeColor = Color.White;
                button1.BackColor = Color.Black;
                button2.ForeColor = Color.White;
                button2.BackColor = Color.Black;
                button3.ForeColor = Color.White;
                button3.BackColor = Color.Black;
                button4.ForeColor = Color.White;
                button4.BackColor = Color.Black;
                button5.ForeColor = Color.White;
                button5.BackColor = Color.Black;
                button6.ForeColor = Color.White;
                button6.BackColor = Color.Black;
                button7.ForeColor = Color.White;
                button7.BackColor = Color.Black;
                button8.ForeColor = Color.White;
                button8.BackColor = Color.Black;
                button9.ForeColor = Color.White;
                button9.BackColor = Color.Black;
                button10.ForeColor = Color.White;
                button10.BackColor = Color.Black;
                button11.ForeColor = Color.White;
                button11.BackColor = Color.Black;
                button12.ForeColor = Color.White;
                button12.BackColor = Color.Black;
                button13.ForeColor = Color.White;
                button13.BackColor = Color.Black;
                button14.ForeColor = Color.White;
                button14.BackColor = Color.Black;
                button15.ForeColor = Color.White;
                button15.BackColor = Color.Black;
                button16.ForeColor = Color.White;
                button16.BackColor = Color.Black;
                button17.ForeColor = Color.White;
                button17.BackColor = Color.Black;
                button18.ForeColor = Color.White;
                button18.BackColor = Color.Black;
                button19.ForeColor = Color.White;
                button19.BackColor = Color.Black;
                button20.ForeColor = Color.White;
                button20.BackColor = Color.Black;
                textBox1.ForeColor = Color.White;
                textBox1.BackColor= Color.Black;
                textBox2.ForeColor = Color.White;
                textBox2.BackColor= Color.Black;
              
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text +="1";
            checkpoint = 0;
            checkoperator = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text +="2";
            checkoperator = 0;
            checkpoint = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text+="3";
            checkpoint = 0;
            checkoperator = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            checkpoint = 0;
            checkoperator = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            checkpoint = 0;
            checkoperator = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text +="6";
            checkpoint = 0;
            checkoperator = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            checkpoint = 0;
            checkoperator = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            checkpoint = 0;
            checkoperator = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            checkpoint = 0;
            checkoperator = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
           // textBox1.Text = "6";
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (checkoperator < 1)
            {
            textBox1.Text += "*";
                checkoperator++;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (checkoperator < 1)
            {
                textBox1.Text += "-";
                checkoperator++;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (checkoperator < 1)
            {
                textBox1.Text += "+";
                checkoperator++;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            checkpoint = 0;
            checkoperator = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (checkpoint== 0 ||checkpoint==2 )
            {
            textBox1.Text += ".";
                checkpoint++;
            }
            if(checkpoint>1)
            {
                MessageBox.Show("You already Entered point(.) ... ", "Warning ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkoperator < 1)
            {
                textBox1.Text += "%";
                checkoperator++;
            }
        }
    }
}
