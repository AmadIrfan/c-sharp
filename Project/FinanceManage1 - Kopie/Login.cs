using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManage1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Users Obj = new Users();
            Obj.Show();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tjbao\Desktop\VS Projects\FinanceManage1\FinanceDb.mdf"";Integrated Security=True;Connect Timeout=30");
        public static string User;
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter Both UserNane and Password");

            }else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTbl where UName='" + UNameTb.Text + "' and UPass='" + PasswordTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    User = UNameTb.Text;
                    Dashboard Obj = new Dashboard();
                    Obj.Show();
                    this.Hide();
                    Con.Close();

                }
                else
                {
                    MessageBox.Show("Wrong Username or Password!");
                    UNameTb.Text = "";
                    PasswordTb.Text = "";
                }
                Con.Close();
            }
            
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
