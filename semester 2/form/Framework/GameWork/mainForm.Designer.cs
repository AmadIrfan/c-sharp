namespace GameWork
{
    partial class mainForm
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
            this.btnsGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblmain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsGame
            // 
            this.btnsGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsGame.FlatAppearance.BorderSize = 5;
            this.btnsGame.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsGame.Location = new System.Drawing.Point(535, 166);
            this.btnsGame.Name = "btnsGame";
            this.btnsGame.Size = new System.Drawing.Size(195, 45);
            this.btnsGame.TabIndex = 0;
            this.btnsGame.Text = "Start Game";
            this.btnsGame.UseVisualStyleBackColor = true;
            this.btnsGame.Click += new System.EventHandler(this.btnsGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnExit.FlatAppearance.BorderSize = 5;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(535, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(195, 45);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblmain
            // 
            this.lblmain.AutoSize = true;
            this.lblmain.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmain.Location = new System.Drawing.Point(52, 204);
            this.lblmain.Name = "lblmain";
            this.lblmain.Size = new System.Drawing.Size(287, 36);
            this.lblmain.TabIndex = 3;
            this.lblmain.Text = "Enemy Killer Game";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmain);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnsGame);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblmain;
    }
}