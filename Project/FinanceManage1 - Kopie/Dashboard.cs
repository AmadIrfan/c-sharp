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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            GetTotInc();
            GetTotExp();
            GetNumInc();
            GetNumExp();
            GetIncLDate();
            GetExpLDate();
            GetMaxInc();
            GetMaxExp();
            GetMinInc();
            GetMinExp();
            GetBalance();
            GetMaxExpCat();
            GetMaxIncCat();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void IncLbl_Click(object sender, EventArgs e)
        {
            Income Obj = new Income();
            Obj.Show();
            this.Hide();
        }

        private void ExpLbl_Click(object sender, EventArgs e)
        {
            Expense Obj = new Expense();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            View_Income Obj = new View_Income();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            View_Expense Obj = new View_Expense();
            Obj.Show();
            this.Hide();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tjbao\Desktop\VS Projects\FinanceManage1\FinanceDb.mdf"";Integrated Security=True;Connect Timeout=30");

        private void GetTotInc()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Sum(IncAmt) from IncomeTbl where IncUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Inc = Convert.ToInt32(dt.Rows[0][0].ToString());
                TotIncLbl.Text = dt.Rows[0][0].ToString() + "€";
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close() ;
            }
            
        }
        int Inc, Exp;
        
        private void GetTotExp()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Exp = Convert.ToInt32(dt.Rows[0][0].ToString());
                TotExpLbl.Text = dt.Rows[0][0].ToString() + "€";
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }
            
        }
        private void GetBalance()
        {
            double Bal = Inc - Exp;
          BalanceLbl.Text = Bal + "€";
        }
        private void GetMaxExpCat()
        {
            try
            {
                Con.Open();
                string InnerQuery = "select Max(ExpAmt) from ExpenseTbl";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
                sda1.Fill(dt1);
                string Query = "select ExpCat from ExpenseTbl where ExpAmt = '" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BestExpLbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }
        }

        private void GetMaxIncCat()
        {
            try
            {
                Con.Open();
                string InnerQuery = "select Max(IncAmt) from IncomeTbl";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
                sda1.Fill(dt1);
                string Query = "select IncCat from IncomeTbl where IncAmt = '" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BestIncLbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }
        }
        private void GetNumExp()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                NumExpLbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }
        }

        private void GetNumInc()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from IncomeTbl where IncUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                NumIncLbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }
        }

        private void GetIncLDate()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Max(IncDate) from IncomeTbl where IncUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DateIncLbl.Text = dt.Rows[0][0].ToString();
                DateIncLbl1.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }
        }

        private void GetExpLDate()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Max(ExpDate) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DateExpLbl.Text = dt.Rows[0][0].ToString();
                DateExpLbl1.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }
        }

        private void GetMaxInc()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Max(IncAmt) from IncomeTbl where IncUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MaxIncLbl.Text = dt.Rows[0][0].ToString() + "€";
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }
        }

        private void GetMaxExp()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Max(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MaxExpLbl.Text = dt.Rows[0][0].ToString() + "€";
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }
        }

        private void GetMinInc()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Min(IncAmt) from IncomeTbl where IncUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MinIncLbl.Text = dt.Rows[0][0].ToString() + "€";
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }
        }

        private void GetMinExp()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Min(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MinExpLbl.Text = dt.Rows[0][0].ToString() + "€";
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
