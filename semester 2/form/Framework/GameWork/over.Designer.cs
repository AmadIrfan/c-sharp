namespace GameWork
{
    partial class over
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblNscore = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.Label();
            this.lblNlife = new System.Windows.Forms.Label();
            this.lbllifes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Over";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(511, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Restart";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblNscore
            // 
            this.lblNscore.AutoSize = true;
            this.lblNscore.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNscore.Location = new System.Drawing.Point(174, 175);
            this.lblNscore.Name = "lblNscore";
            this.lblNscore.Size = new System.Drawing.Size(70, 25);
            this.lblNscore.TabIndex = 4;
            this.lblNscore.Text = "Score ";
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScore.Location = new System.Drawing.Point(336, 175);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(23, 25);
            this.LblScore.TabIndex = 5;
            this.LblScore.Text = "0";
            // 
            // lblNlife
            // 
            this.lblNlife.AutoSize = true;
            this.lblNlife.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNlife.Location = new System.Drawing.Point(174, 206);
            this.lblNlife.Name = "lblNlife";
            this.lblNlife.Size = new System.Drawing.Size(50, 25);
            this.lblNlife.TabIndex = 6;
            this.lblNlife.Text = "Life";
            // 
            // lbllifes
            // 
            this.lbllifes.AutoSize = true;
            this.lbllifes.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllifes.Location = new System.Drawing.Point(336, 206);
            this.lbllifes.Name = "lbllifes";
            this.lbllifes.Size = new System.Drawing.Size(23, 25);
            this.lbllifes.TabIndex = 7;
            this.lbllifes.Text = "0";
            // 
            // over
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbllifes);
            this.Controls.Add(this.lblNlife);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.lblNscore);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "over";
            this.Text = "Game over";
            this.Load += new System.EventHandler(this.over_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblNscore;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Label lblNlife;
        private System.Windows.Forms.Label lbllifes;
    }
}