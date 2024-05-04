namespace FinanceManage1
{
    partial class view_expanse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_expanse));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.ExpenseDGV = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Miete",
            "Essen",
            "Kleidung",
            "Gesundheit",
            "Reise",
            "Haustier",
            "Auto",
            "Sonstiges"});
            this.comboBox1.Location = new System.Drawing.Point(1388, 237);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(380, 21);
            this.comboBox1.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 18);
            this.label9.TabIndex = 60;
            this.label9.Text = "Expense Name";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 24);
            this.textBox1.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 37);
            this.label1.TabIndex = 66;
            this.label1.Text = "View Expense";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 164);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(341, 100);
            this.tableLayoutPanel1.TabIndex = 67;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(1998, 15);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(134, 82);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 56;
            this.pictureBox10.TabStop = false;
            // 
            // ExpenseDGV
            // 
            this.ExpenseDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpenseDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExpenseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpenseDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEdit,
            this.btnDelete});
            this.ExpenseDGV.Location = new System.Drawing.Point(19, 306);
            this.ExpenseDGV.Name = "ExpenseDGV";
            this.ExpenseDGV.Size = new System.Drawing.Size(811, 241);
            this.ExpenseDGV.TabIndex = 68;
            this.ExpenseDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpenseDGV_CellClick);
            this.ExpenseDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpenseDGV_CellContentClick);
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Edit";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEdit.Text = "Edit";
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Delete";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnDelete.Text = "Delete";
            // 
            // view_expanse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 559);
            this.Controls.Add(this.ExpenseDGV);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "view_expanse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Expense";
            this.Load += new System.EventHandler(this.View_Expense_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView ExpenseDGV;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}