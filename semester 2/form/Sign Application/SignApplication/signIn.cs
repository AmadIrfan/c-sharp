using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SignApplication.BL;
using SignApplication.DL;

namespace SignApplication
{
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignInSignUp signInSignUp = new SignInSignUp();
            signInSignUp.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string role;
            mUser user = new mUser(username,password);
            role=mUserDL.checkUser(user);
            if (role != null)
            {
             DialogResult result=MessageBox.Show("You are loggedin as "+ role.ToString(),"Alert",MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if(result == DialogResult.OK)
                {
                    SignInSignUp signInSignUp = new SignInSignUp();
                    signInSignUp.Show();
                    this.Hide();
                }
            }
            else
            {
                DialogResult result= MessageBox.Show("Invalid user","Alert",MessageBoxButtons.OK,MessageBoxIcon.Error );
                if (result == DialogResult.OK)
                {
                    SignInSignUp signInSignUp = new SignInSignUp();
                    signInSignUp.Show();
                    this.Hide();
                }
            }
        }
        private void signIn_Load(object sender, EventArgs e)
        {
                textBox2.UseSystemPasswordChar=true;
            string path = "sign.txt";
            mUserDL.addInFile(path);
            mUserDL.loadFromFile(path);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar=false;
            }
            else
            {
                textBox2.UseSystemPasswordChar=true;

            }
        }
    }
}
