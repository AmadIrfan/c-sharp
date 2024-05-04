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
    public partial class Income : Form
    {
/*      
        SqlConnection Con = new SqlConnection(@"Data Source=(local);Initial Catalog=ProjectTask;Integrated Security=True");
*/
       SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tjbao\Desktop\VS Projects\FinanceManage1\FinanceDb.mdf"";Integrated Security=True;Connect Timeout=30");

        public Income()
        {
            InitializeComponent();
            GetTotInc();
        }

        private void Income_Load(object sender, EventArgs e)
        {
            this.Controls.Remove(catCBox);
          this.Controls.Remove(IncDate);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Clear()
        {
            IncNameTb.Text = "";
            IncAmtTb.Text = "";
            IncDescTb.Text = "";
            catCBox.SelectedIndex = 0;
        }


        private void CatCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            View_Income Obj = new View_Income();
            Obj.Show();
            this.Hide();
        }

     
        private void GetTotInc()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Sum(IncAmt) from IncomeTbl where IncUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //Inc = Convert.ToInt32(dt.Rows[0][0].ToString());
                TotIncLbl.Text = dt.Rows[0][0].ToString() + "€";
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }

        }


        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine(Login.User);
            if (IncNameTb.Text == "" || IncAmtTb.Text == "" || IncDescTb.Text == "" || catCBox.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into IncomeTbl(IncName,IncAmt,IncCat,IncDate,IncDesc,IncUser)values(@IN,@IA,@IC,@ID,@IDe,@IU)", Con);
                    cmd.Parameters.AddWithValue("@IN", IncNameTb.Text);
                    cmd.Parameters.AddWithValue("@IA", IncAmtTb.Text);
                    cmd.Parameters.AddWithValue("@IC", catCBox.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ID", IncDateBox.Value.Date);
                    cmd.Parameters.AddWithValue("@IDe", IncDescTb.Text);
                    cmd.Parameters.AddWithValue("@IU", Login.User);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Income Added!");
                    Con.Close();
                    GetTotInc();
                    Clear();
                }
                catch (Exception Ex)
                {
                    Con.Close();
                    MessageBox.Show(Ex.Message);

                }
            }

        }

        private void IncNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void IncAmtTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void IncDescTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
