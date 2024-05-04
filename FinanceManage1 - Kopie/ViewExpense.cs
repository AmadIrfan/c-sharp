using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinanceManage1
{
    public partial class view_expanse : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tjbao\Desktop\VS Projects\FinanceManage1\FinanceDb.mdf"";Integrated Security=True;Connect Timeout=30");
       /*     SqlConnection Con = new SqlConnection(@"Data Source=(local);Initial Catalog=ProjectTask;Integrated Security=True");
       */ public view_expanse()
        {
            InitializeComponent();
            DisplayExpense();
        }

        private void DisplayExpense()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from ExpenseTbl where ExpUser = '" + Login.User + "'", Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ExpenseDGV.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void View_Expense_Load(object sender, EventArgs e)
        {
        }


        
        private void ExpenseDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int ExpId = int.Parse(ExpenseDGV.CurrentRow.Cells[2].Value.ToString());
                String ExpName = ExpenseDGV.CurrentRow.Cells[3].Value.ToString();
                int ExpAmt = int.Parse(ExpenseDGV.CurrentRow.Cells[4].Value.ToString());
                String ExpCat = ExpenseDGV.CurrentRow.Cells[5].Value.ToString();
                DateTime ExpDate = DateTime.Parse(ExpenseDGV.CurrentRow.Cells[6].Value.ToString());
                String ExpDesc = ExpenseDGV.CurrentRow.Cells[7].Value.ToString();
                String ExpUser = ExpenseDGV.CurrentRow.Cells[8].Value.ToString();

                if (ExpenseDGV.Columns["btnEdit"].Index == e.ColumnIndex)
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE  ExpenseTbl SET ExpName=@ExpName,ExpAmt=@ExpAmt,ExpCat=@ExpCat,ExpDate=@ExpDate,ExpDesc=@ExpDesc,ExpUser=@ExpUser where @ExpId=ExpId and ExpUser = '" + Login.User + "'", Con);
                    cmd.Parameters.AddWithValue("@ExpId", ExpId);
                    cmd.Parameters.AddWithValue("@ExpName", ExpName);
                    cmd.Parameters.AddWithValue("@ExpAmt", ExpAmt);
                    cmd.Parameters.AddWithValue("@ExpCat", ExpCat);
                    cmd.Parameters.AddWithValue("@ExpDate", ExpDate);
                    cmd.Parameters.AddWithValue("@ExpDesc", ExpDesc);
                    cmd.Parameters.AddWithValue("@ExpUser", ExpUser);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Successfuly updated", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                DisplayExpense();
                }
                else if (ExpenseDGV.Columns["btnDelete"].Index == e.ColumnIndex)
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ExpenseTbl WHERE ExpId= @ExpId and ExpUser = '" + Login.User + "'", Con);
                    cmd.Parameters.AddWithValue("@ExpId", ExpId);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Deleted Successfuly", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DisplayExpense();
                }
            }
            catch (Exception exp)
            {
                Con.Close();
                MessageBox.Show(exp.Message.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void ExpenseDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
