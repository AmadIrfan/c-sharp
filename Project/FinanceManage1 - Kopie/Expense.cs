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
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
            GetTotExp();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tjbao\Desktop\VS Projects\FinanceManage1\FinanceDb.mdf"";Integrated Security=True;Connect Timeout=30");

        private void Clear()
        {
            ExpNameTb.Text = "";
            ExpAmtTb.Text = "";
            ExpDescTb.Text = "";
            CatCb.SelectedIndex = 0;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ExpNameTb.Text == "" || ExpAmtTb.Text == "" || ExpDescTb.Text == "" || CatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ExpenseTbl(ExpName,ExpAmt,ExpCat,ExpDate,ExpDesc,ExpUser)values(@EN,@EA,@EC,@ED,@EDe,@EU)", Con);
                    cmd.Parameters.AddWithValue("@EN", ExpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EA", ExpAmtTb.Text);
                    cmd.Parameters.AddWithValue("@EC", CatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ED", ExpDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EDe", ExpDescTb.Text);
                    cmd.Parameters.AddWithValue("@EU", Login.User);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Expense Added!");
                    Con.Close();
                    GetTotExp();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            View_Expense Obj = new View_Expense();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            View_Income Obj = new View_Income();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Income Obj = new Income();
            Obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void GetTotExp()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                // Exp = Convert.ToInt32(dt.Rows[0][0].ToString());
                TotExpLbl.Text = dt.Rows[0][0].ToString() + "€";
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }

        }

        private void Expense_Load(object sender, EventArgs e)
        {

        }
    }
}
