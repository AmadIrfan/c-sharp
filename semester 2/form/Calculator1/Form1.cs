using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double result_Value = 0;
        string operation_Performed = "";
        bool isOperationIsPerformed = false;

        private void btn0_Click(object sender, EventArgs e){}
        private void btn1_Click(object sender, EventArgs e){}
        private void btn0_Click_1(object sender, EventArgs e){}
        private void btn1_Click_1(object sender, EventArgs e){}
        private void btn2_Click(object sender, EventArgs e){}
        private void btn3_Click(object sender, EventArgs e){}
        private void btn4_Click(object sender, EventArgs e){}
        private void btn5_Click(object sender, EventArgs e){}
        private void btn6_Click(object sender, EventArgs e){}
        private void btn7_Click(object sender, EventArgs e){}
        private void btn8_Click(object sender, EventArgs e){}
        private void btn9_Click(object sender, EventArgs e){}
        private void btnPlus_Click(object sender, EventArgs e){}
        private void btn0_Click_2(object sender, EventArgs e){}

        int check = 0;
        private void btnDot_Click(object sender, EventArgs e)
        {
           
            if (check <1)
            {
                txtbxOutput.Text = txtbxOutput.Text + ".";
                check++;
            }
            else
            {
                txtbxOutput.Text = txtbxOutput.Text + "";
            }
            
        }
        private void btn_Click(object sender, EventArgs e)
        {        
            if ((txtbxOutput.Text == "0")||(isOperationIsPerformed))
            {
                txtbxOutput.Clear();
            }
            isOperationIsPerformed = false;
            Button button = (Button)sender;
            txtbxOutput.Text = txtbxOutput.Text + button.Text;
            

        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result_Value != 0)
            {
                btnEqual.PerformClick();
                operation_Performed = button.Text;
                isOperationIsPerformed = true;
            }
            else
            {
                operation_Performed = button.Text;
                result_Value = double.Parse(txtbxOutput.Text);
                isOperationIsPerformed = true;
            }
        }

        private void btnRemoveInputData_Click(object sender, EventArgs e)
        {
            txtbxOutput.Text = "0";

        }

        private void btnRemoveAllData_Click(object sender, EventArgs e)
        {
            txtbxOutput.Text = "0";
            result_Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelSlide_Paint(object sender, PaintEventArgs e)
        {

        }


        private void txtbxHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAboutHistory_Click(object sender, EventArgs e)
        {

        }

        private void lblHistory_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
           String secondNum = txtbxOutput.Text;
            switch (operation_Performed)
            {
                case "+":
                    txtbxOutput.Text = (result_Value + double.Parse(txtbxOutput.Text)).ToString();
                    break;
                case "-":
                    txtbxOutput.Text = (result_Value - double.Parse(txtbxOutput.Text)).ToString();
                    break;
                case "*":
                    txtbxOutput.Text = (result_Value * double.Parse(txtbxOutput.Text)).ToString();
                    break;
                case "/":
                    txtbxOutput.Text = (result_Value / double.Parse(txtbxOutput.Text)).ToString();
                    break;
                default:
                    break;                    
            }
            result_Value = double.Parse(txtbxOutput.Text);
      

            //*******************************************


        }
    }
}
