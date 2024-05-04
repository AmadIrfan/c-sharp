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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace FinanceManage1
{
    public partial class Login : Form
    {
        public Login()
        {            
            InitializeComponent();
            PasswordTb.UseSystemPasswordChar = true;
        
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Users Obj = new Users();
            this.Hide();
            Obj.Show();
        }
/*        
        SqlConnection Con = new SqlConnection(@"Data Source=(local);Initial Catalog=ProjectTask;Integrated Security=True");
*/
         
SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tjbao\Desktop\VS Projects\FinanceManage1\FinanceDb.mdf"";Integrated Security=True;Connect Timeout=30");

        public static string User;
        private void LoginBtn_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            if (UNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter Both UserNane and Password");
            }
            else
            {
                try
                {

                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTbl where UName='" + UNameTb.Text + "' and UPass='" + PasswordTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    User = UNameTb.Text;
                    SideBar Obj = new SideBar();
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
                catch(Exception exp)
                {
                    MessageBox.Show(exp.Message.ToString(), "Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
            }


        }
    }
}
