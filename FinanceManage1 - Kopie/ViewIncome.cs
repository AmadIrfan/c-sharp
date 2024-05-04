using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
    public partial class View_Income : Form
    {
           SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tjbao\Desktop\VS Projects\FinanceManage1\FinanceDb.mdf"";Integrated Security=True;Connect Timeout=30");
        /*SqlConnection Con = new SqlConnection(@"Data Source=(local);Initial Catalog=ProjectTask;Integrated Security=True");
*/
       public View_Income()
        {
            InitializeComponent();
            DisplayIncome();
        }

      
        private void DisplayIncome()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from IncomeTbl where IncUser = '" + Login.User + "'", Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            IncomeDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void View_Income_Load(object sender, EventArgs e)
        {

        }

        private void IncomeDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {


            int IncId = int.Parse(IncomeDGV.CurrentRow.Cells[2].Value.ToString());
                String IncName =IncomeDGV.CurrentRow.Cells[3].Value.ToString();
            int IncAmt= int.Parse(IncomeDGV.CurrentRow.Cells[4].Value.ToString());
            String IncCat= IncomeDGV.CurrentRow.Cells[5].Value.ToString();
            DateTime   IncDate =DateTime.Parse(IncomeDGV.CurrentRow.Cells[6].Value.ToString());
            String IncDesc= IncomeDGV.CurrentRow.Cells[7].Value.ToString();
            String IncUser= IncomeDGV.CurrentRow.Cells[8].Value.ToString();

            if (IncomeDGV.Columns["btnEdit"].Index == e.ColumnIndex)
            {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE  IncomeTbl SET IncName=@IncName,IncAmt=@IncAmt,IncCat=@IncCat,IncDate=@IncDate,IncDesc=@IncDesc,IncUser=@IncUser where @IncId=IncId and IncUser = '" + Login.User + "'", Con);
                    cmd.Parameters.AddWithValue("@IncId",IncId);
                    cmd.Parameters.AddWithValue("@IncName", IncName);
                    cmd.Parameters.AddWithValue("@IncAmt", IncAmt);
                    cmd.Parameters.AddWithValue("@IncCat", IncCat);
                    cmd.Parameters.AddWithValue("@IncDate", IncDate);
                    cmd.Parameters.AddWithValue("@IncDesc", IncDesc);
                    cmd.Parameters.AddWithValue("@IncUser", IncUser);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Successfuly updated", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    DisplayIncome();

                }
                else  if (IncomeDGV.Columns["btnDelete"].Index == e.ColumnIndex)
            {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from IncomeTbl WHERE IncId=@IncId and IncUser = '" + Login.User + "'", Con);
                    cmd.Parameters.AddWithValue("@IncId", IncId);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Deleted Successfuly", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DisplayIncome();

                }
            }
            catch (Exception exp){
                Con.Close();
                MessageBox.Show(exp.Message.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }
    }
}
