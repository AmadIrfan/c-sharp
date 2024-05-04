using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManage1
{
    public partial class SideBar : Form
    {
        int index = 0;
        public SideBar()
        {
            InitializeComponent();
        }

        private void SideBar_Load(object sender, EventArgs e)
        {
            showChildForm(new MyDashBoard());
        }

        void showChildForm(object form)
        {
            Form frm = (Form)form;

            if (this.tabPanel.Controls.Count > 0)
            {
                this.tabPanel.Controls.RemoveAt(0);
            }
            frm.TopLevel = false;
            DoubleBuffered = true;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            this.tabPanel.Controls.Add(frm);
            frm.Show();

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel10_Click(object sender, EventArgs e)
        {

        }

        private void tabPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MyButtonSColorr(sender, e);
            this.Close();
            
        }

        private void BtnViewExpens_Click(object sender, EventArgs e)
        {
            showChildForm(new view_expanse());
        MyButtonSColorr(sender, e);
        }

        private void btnViewIncome_Click(object sender, EventArgs e)
        {
            showChildForm(new View_Income());
            MyButtonSColorr(sender, e);
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            showChildForm(new Expense());
            MyButtonSColorr(sender, e);
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            showChildForm(new Income());
            MyButtonSColorr(sender, e);
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            showChildForm(new MyDashBoard());
            MyButtonSColorr(sender, e);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    private void    MyButtonSColorr(object sender,EventArgs e)
        {
            foreach (Control item in btnPanal.Controls)
            {
                item.BackColor = Color.RoyalBlue;
                item.ForeColor = Color.White;
            }
            Control click = (Control)sender;
            click.BackColor = Color.White;
            click.ForeColor = Color.CornflowerBlue;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.WindowState);
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Color titleBarColor = Color.CornflowerBlue;
            e.Graphics.FillRectangle(new SolidBrush(titleBarColor), 0, 0, Width, SystemInformation.CaptionHeight);
            e.Graphics.DrawString(Text, Font, Brushes.White, 10, 5);
            base.OnPaint(e);
        }
    }
}
