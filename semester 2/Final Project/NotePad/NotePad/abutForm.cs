﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class abutForm : Form
    {
        public abutForm()
        {
            InitializeComponent();
        }

        private void abutForm_Load(object sender, EventArgs e)
        {
            label1.Text=Application.ProductName;
            label3.Text = Application.ProductVersion;
            label4.Text=Application.CompanyName;
            label6.Text=Application.CurrentCulture.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
