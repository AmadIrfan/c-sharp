namespace GameWork
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBarLife = new System.Windows.Forms.ProgressBar();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 30;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.progressBarLife);
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 54);
            this.panel1.TabIndex = 2;
            // 
            // progressBarLife
            // 
            this.progressBarLife.Location = new System.Drawing.Point(231, 20);
            this.progressBarLife.Name = "progressBarLife";
            this.progressBarLife.Size = new System.Drawing.Size(149, 23);
            this.progressBarLife.Step = 5;
            this.progressBarLife.TabIndex = 3;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(162, 22);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(63, 24);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Life : ";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(96, 22);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(21, 24);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "0";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 22);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(78, 24);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Score : ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 567);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBarLife;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
    }
}