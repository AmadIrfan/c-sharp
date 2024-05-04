using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManage1
{
    public partial class View_Income : Form
    {
        public View_Income()
        {
            InitializeComponent();
            DisplayIncome();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Income Obj = new Income();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void DisplayIncome()
        {
            Con.Open();
            //string Query = "select * from IncomeTbl";
            SqlDataAdapter sda = new SqlDataAdapter("select * from IncomeTbl where IncUser = '" + Login.User + "'", Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            IncomeDGV.DataSource = ds.Tables[0];
            Con.Close();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tjbao\Desktop\VS Projects\FinanceManage1\FinanceDb.mdf"";Integrated Security=True;Connect Timeout=30");

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void label6_Click(object sender, EventArgs e)
        {
            View_Expense Obj = new View_Expense();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Expense Obj = new Expense();
            Obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
