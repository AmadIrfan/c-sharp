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

       
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

              SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tjbao\Desktop\VS Projects\FinanceManage1\FinanceDb.mdf"";Integrated Security=True;Connect Timeout=30");
        
    /* SqlConnection Con = new SqlConnection(@"Data Source=(local);Initial Catalog=ProjectTask;Integrated Security=True");
    */    private void Clear()
        {
            ExpNameTb.Text = "";
            ExpAmtTb.Text = "";
            ExpDescTb.Text = "";
            CatCb.SelectedIndex = 0;
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

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            if (ExpNameTb.Text == "" || ExpAmtTb.Text == "" || ExpDescTb.Text == "" || CatCBox.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Console.WriteLine(Login.User);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ExpenseTbl(ExpName,ExpAmt,ExpCat,ExpDate,ExpDesc,ExpUser)values(@EN,@EA,@EC,@ED,@EDe,@EU)", Con);
                    cmd.Parameters.AddWithValue("@EN", ExpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EA", ExpAmtTb.Text);
                    cmd.Parameters.AddWithValue("@EC", CatCBox.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ED", ExpDateBox.Value.Date);
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
    }
}
