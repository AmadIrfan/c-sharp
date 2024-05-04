namespace FinanceManage1
{
    partial class Income
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Income));
            this.label7 = new System.Windows.Forms.Label();
            this.IncNameTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.IncAmtTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.IncDescTb = new System.Windows.Forms.TextBox();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.IncDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotIncLbl = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.MinIncLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.catCBox = new System.Windows.Forms.ComboBox();
            this.IncDateBox = new System.Windows.Forms.DateTimePicker();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel13.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1186, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Your Income";
            // 
            // IncNameTb
            // 
            this.IncNameTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IncNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncNameTb.Location = new System.Drawing.Point(3, 32);
            this.IncNameTb.Name = "IncNameTb";
            this.IncNameTb.Size = new System.Drawing.Size(506, 24);
            this.IncNameTb.TabIndex = 1;
            this.IncNameTb.TextChanged += new System.EventHandler(this.IncNameTb_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Income Name";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Amount";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // IncAmtTb
            // 
            this.IncAmtTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IncAmtTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncAmtTb.Location = new System.Drawing.Point(3, 90);
            this.IncAmtTb.Name = "IncAmtTb";
            this.IncAmtTb.Size = new System.Drawing.Size(506, 24);
            this.IncAmtTb.TabIndex = 2;
            this.IncAmtTb.TextChanged += new System.EventHandler(this.IncAmtTb_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "Description";
            // 
            // IncDescTb
            // 
            this.IncDescTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IncDescTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncDescTb.Location = new System.Drawing.Point(3, 264);
            this.IncDescTb.Multiline = true;
            this.IncDescTb.Name = "IncDescTb";
            this.tableLayoutPanel1.SetRowSpan(this.IncDescTb, 2);
            this.IncDescTb.Size = new System.Drawing.Size(506, 53);
            this.IncDescTb.TabIndex = 5;
            this.IncDescTb.TextChanged += new System.EventHandler(this.IncDescTb_TextChanged);
            // 
            // CatCb
            // 
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Items.AddRange(new object[] {
            "Gehalt",
            "Trinkgeld",
            "Anderes"});
            this.CatCb.Location = new System.Drawing.Point(1388, 237);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(367, 21);
            this.CatCb.TabIndex = 37;
            this.CatCb.SelectedIndexChanged += new System.EventHandler(this.CatCb_SelectedIndexChanged);
            // 
            // IncDate
            // 
            this.IncDate.Location = new System.Drawing.Point(1388, 389);
            this.IncDate.Name = "IncDate";
            this.IncDate.Size = new System.Drawing.Size(367, 20);
            this.IncDate.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1385, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Categories";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1385, 349);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 37);
            this.label1.TabIndex = 42;
            this.label1.Text = "Income";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel13, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(652, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(220, 110);
            this.tableLayoutPanel2.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.TotIncLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 77);
            this.panel1.TabIndex = 32;
            // 
            // TotIncLbl
            // 
            this.TotIncLbl.AutoSize = true;
            this.TotIncLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotIncLbl.ForeColor = System.Drawing.Color.White;
            this.TotIncLbl.Location = new System.Drawing.Point(105, 35);
            this.TotIncLbl.Name = "TotIncLbl";
            this.TotIncLbl.Size = new System.Drawing.Size(15, 16);
            this.TotIncLbl.TabIndex = 0;
            this.TotIncLbl.Text = "0";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.RosyBrown;
            this.panel13.Controls.Add(this.MinIncLbl);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(220, 33);
            this.panel13.TabIndex = 31;
            // 
            // MinIncLbl
            // 
            this.MinIncLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MinIncLbl.AutoSize = true;
            this.MinIncLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinIncLbl.ForeColor = System.Drawing.Color.White;
            this.MinIncLbl.Location = new System.Drawing.Point(63, 9);
            this.MinIncLbl.Name = "MinIncLbl";
            this.MinIncLbl.Size = new System.Drawing.Size(97, 16);
            this.MinIncLbl.TabIndex = 1;
            this.MinIncLbl.Text = "Total Income";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.IncNameTb, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.IncAmtTb, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.catCBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.IncDescTb, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.IncDateBox, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 144);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091483F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091478F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091478F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091478F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091478F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.087842F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091478F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091478F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091478F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090166F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090166F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(512, 320);
            this.tableLayoutPanel1.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Category";
            // 
            // catCBox
            // 
            this.catCBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catCBox.FormattingEnabled = true;
            this.catCBox.Items.AddRange(new object[] {
            "Gehalt",
            "Trinkgeld",
            "Anderes"});
            this.catCBox.Location = new System.Drawing.Point(3, 148);
            this.catCBox.Name = "catCBox";
            this.catCBox.Size = new System.Drawing.Size(506, 26);
            this.catCBox.TabIndex = 3;
            // 
            // IncDateBox
            // 
            this.IncDateBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncDateBox.Location = new System.Drawing.Point(3, 206);
            this.IncDateBox.Name = "IncDateBox";
            this.IncDateBox.Size = new System.Drawing.Size(506, 24);
            this.IncDateBox.TabIndex = 4;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(1998, 15);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(134, 82);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 17;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(656, 507);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(202, 39);
            this.SaveBtn.TabIndex = 44;
            this.SaveBtn.Text = "Save Income";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click_1);
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 575);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.IncDate);
            this.Controls.Add(this.CatCb);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Income";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income";
            this.Load += new System.EventHandler(this.Income_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.TextBox IncNameTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IncAmtTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox IncDescTb;
        private System.Windows.Forms.ComboBox CatCb;
        private System.Windows.Forms.DateTimePicker IncDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label MinIncLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TotIncLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox catCBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker IncDateBox;
    }
}