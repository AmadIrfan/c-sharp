namespace FinanceManage1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Firmaname";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "User Name";
            // 
            // UNameTb
            // 
            this.UNameTb.Location = new System.Drawing.Point(70, 261);
            this.UNameTb.Name = "UNameTb";
            this.UNameTb.Size = new System.Drawing.Size(323, 20);
            this.UNameTb.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Password";
            // 
            // PasswordTb
            // 
            this.PasswordTb.Location = new System.Drawing.Point(70, 390);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(323, 20);
            this.PasswordTb.TabIndex = 49;
           
            // 
            // LoginBtn
            // 
            this.LoginBtn.AutoSize = true;
            this.LoginBtn.Location = new System.Drawing.Point(320, 522);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(33, 13);
            this.LoginBtn.TabIndex = 51;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(378, 12);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(79, 47);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 57;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Register";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.UNameTb);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UNameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.Label LoginBtn;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label3;
    }
}