namespace N_Puzzle_Game
{
    partial class Fifteen_Puzzle
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fifteen_Puzzle));
			this.lbl_time = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.lbl_move = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_time
			// 
			this.lbl_time.AutoSize = true;
			this.lbl_time.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold);
			this.lbl_time.Location = new System.Drawing.Point(13, 397);
			this.lbl_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_time.Name = "lbl_time";
			this.lbl_time.Size = new System.Drawing.Size(90, 27);
			this.lbl_time.TabIndex = 22;
			this.lbl_time.Text = "time :";
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold);
			this.button3.Location = new System.Drawing.Point(176, 457);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(193, 54);
			this.button3.TabIndex = 21;
			this.button3.Text = "Solution";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold);
			this.button1.Location = new System.Drawing.Point(9, 457);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(156, 54);
			this.button1.TabIndex = 16;
			this.button1.Text = "Shuffle";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(11, 15);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(373, 345);
			this.panel1.TabIndex = 15;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold);
			this.button2.Location = new System.Drawing.Point(393, 457);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(137, 54);
			this.button2.TabIndex = 23;
			this.button2.Text = "Exit";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// lbl_move
			// 
			this.lbl_move.AutoSize = true;
			this.lbl_move.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold);
			this.lbl_move.Location = new System.Drawing.Point(242, 397);
			this.lbl_move.Name = "lbl_move";
			this.lbl_move.Size = new System.Drawing.Size(77, 27);
			this.lbl_move.TabIndex = 24;
			this.lbl_move.Text = "Move:";
			// 
			// Fifteen_Puzzle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(542, 527);
			this.Controls.Add(this.lbl_move);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.lbl_time);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "Fifteen_Puzzle";
			this.Opacity = 0.99D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Game Xep Hinh";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fifteen_Puzzle_FormClosed);
			this.Load += new System.EventHandler(this.Fifteen_Puzzle_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label lbl_move;
	}
}