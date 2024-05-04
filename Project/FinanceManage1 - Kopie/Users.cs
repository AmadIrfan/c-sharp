using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinanceManage1
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tjbao\Desktop\VS Projects\FinanceManage1\FinanceDb.mdf"";Integrated Security=True;Connect Timeout=30");

        private void Clear()
        {
            UNameTb.Text = "";
            PhoneTb.Text = "";
            PasswordTb.Text = "";
            AddressTb.Text = "";

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (UNameTb.Text == "" || PhoneTb.Text == "" || PasswordTb.Text == "" || AddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into UserTbl(UName,UDob,UPhone,UPass,UAddress)values(@UN,@UD,@UP,@UPA,@UA)", Con);
                    cmd.Parameters.AddWithValue("@UN", UNameTb.Text);
                    cmd.Parameters.AddWithValue("@UD", DOB.Value.Date);
                    cmd.Parameters.AddWithValue("@UP", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@UPA", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@UA", AddressTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Added!");
                    Con.Close();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

