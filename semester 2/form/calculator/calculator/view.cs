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
    public partial class view : Form
    {
        
        public view()
        {
            InitializeComponent();
        }

        private void view_Load(object sender, EventArgs e)
        { label3.BorderStyle= BorderStyle.Fixed3D;
            label1.BorderStyle= BorderStyle.None;
         textBox1.Select();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BorderStyle = BorderStyle.Fixed3D;
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                checkBox1.Text = "Light Mode ";
                this.BackColor = Color.White;
                textBox1.ForeColor = Color.Black;
                textBox1.BackColor = Color.White;
                checkBox1.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
            }
            else
            {
                checkBox1.Text = "Dark Mode ";
                this.BackColor = Color.Black;
                textBox1.ForeColor= Color.White;
                textBox1.BackColor  = Color.Black;
                label1.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                checkBox1.ForeColor = Color.White;

            }
        }
    }
}
