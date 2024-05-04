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
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignInSignUp signInSignUp=new SignInSignUp();
            this.Hide();
            signInSignUp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;
            string role = textBox3.Text;
            string path = "sign.txt";
            mUser obj = new mUser(userName, password, role);
            DL.mUserDL.addInList(obj);
            DL.mUserDL.addInFile(path);
            MessageBox.Show("Successfully Added");
        }

        private void signUp_Load(object sender, EventArgs e)
        {

        }
    }
}
