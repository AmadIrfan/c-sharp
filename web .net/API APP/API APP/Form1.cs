using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_APP
{
    public partial class Form1 : Form
    {
        String data = "";
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            data = await REST_API.getAPI();
            richTextBox1.Text = data;

        }
        private async void button1_Click(object sender, EventArgs e)
        {
/*            data= await REST_API.getAPI();  
           richTextBox1.Text = data;
*/        }
    }
}
