namespace gameDevp
{
    partial class lblnum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lblnum));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.GameLoop = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-1, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 10);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(119, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1172, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(119, 431);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1172, 12);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(-1, 321);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1147, 10);
            this.panel4.TabIndex = 2;
            // 
            // GameLoop
            // 
            this.GameLoop.Enabled = true;
            this.GameLoop.Tick += new System.EventHandler(this.GameLoop_Tick);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(-1, 551);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1147, 10);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.lblscore);
            this.panel6.Location = new System.Drawing.Point(1007, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(265, 28);
            this.panel6.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(58, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblscore.Location = new System.Drawing.Point(3, 8);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(49, 19);
            this.lblscore.TabIndex = 0;
            this.lblscore.Text = "label1";
            // 
            // lblnum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 731);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "lblnum";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer GameLoop;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblscore;
    }
}