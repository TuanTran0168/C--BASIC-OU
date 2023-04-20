namespace BaiTapThucHanhOnline
{
    partial class RandomNumbers
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
            this.lbNum1 = new System.Windows.Forms.Label();
            this.lbNum2 = new System.Windows.Forms.Label();
            this.lbNum3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd11 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rdPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPoint = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNum1
            // 
            this.lbNum1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbNum1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNum1.Font = new System.Drawing.Font("Showcard Gothic", 100F);
            this.lbNum1.Location = new System.Drawing.Point(120, 51);
            this.lbNum1.Name = "lbNum1";
            this.lbNum1.Size = new System.Drawing.Size(189, 209);
            this.lbNum1.TabIndex = 0;
            this.lbNum1.Text = "0";
            this.lbNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNum2
            // 
            this.lbNum2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbNum2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNum2.Font = new System.Drawing.Font("Showcard Gothic", 100F);
            this.lbNum2.Location = new System.Drawing.Point(353, 51);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(188, 209);
            this.lbNum2.TabIndex = 0;
            this.lbNum2.Text = "0";
            this.lbNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNum3
            // 
            this.lbNum3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbNum3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNum3.Font = new System.Drawing.Font("Showcard Gothic", 100F);
            this.lbNum3.Location = new System.Drawing.Point(583, 51);
            this.lbNum3.Name = "lbNum3";
            this.lbNum3.Size = new System.Drawing.Size(175, 209);
            this.lbNum3.TabIndex = 0;
            this.lbNum3.Text = "0";
            this.lbNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.rd11);
            this.groupBox1.Controls.Add(this.rd3);
            this.groupBox1.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(120, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPTIONS";
            // 
            // rd11
            // 
            this.rd11.Appearance = System.Windows.Forms.Appearance.Button;
            this.rd11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rd11.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.rd11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd11.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd11.ForeColor = System.Drawing.Color.Red;
            this.rd11.Location = new System.Drawing.Point(375, 54);
            this.rd11.Name = "rd11";
            this.rd11.Size = new System.Drawing.Size(185, 83);
            this.rd11.TabIndex = 0;
            this.rd11.Text = "11 - 18";
            this.rd11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rd11.UseVisualStyleBackColor = false;
            this.rd11.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // rd3
            // 
            this.rd3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rd3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rd3.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.rd3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd3.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd3.ForeColor = System.Drawing.Color.Red;
            this.rd3.Location = new System.Drawing.Point(85, 54);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(185, 83);
            this.rd3.TabIndex = 0;
            this.rd3.Text = "3 - 10";
            this.rd3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rd3.UseVisualStyleBackColor = false;
            this.rd3.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // rdPlay
            // 
            this.rdPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdPlay.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdPlay.Location = new System.Drawing.Point(120, 522);
            this.rdPlay.Name = "rdPlay";
            this.rdPlay.Size = new System.Drawing.Size(222, 92);
            this.rdPlay.TabIndex = 2;
            this.rdPlay.Text = "PLAY";
            this.rdPlay.UseVisualStyleBackColor = true;
            this.rdPlay.Click += new System.EventHandler(this.rdPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(347, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "POINT: ";
            // 
            // lbPoint
            // 
            this.lbPoint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPoint.Font = new System.Drawing.Font("Showcard Gothic", 55F);
            this.lbPoint.ForeColor = System.Drawing.Color.Red;
            this.lbPoint.Location = new System.Drawing.Point(524, 494);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(234, 120);
            this.lbPoint.TabIndex = 4;
            this.lbPoint.Text = "0";
            this.lbPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(458, 650);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(222, 92);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayAgain.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPlayAgain.Location = new System.Drawing.Point(205, 650);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(222, 92);
            this.btnPlayAgain.TabIndex = 2;
            this.btnPlayAgain.Text = "PLAY AGAIN";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // RandomNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 766);
            this.Controls.Add(this.lbPoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.rdPlay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbNum3);
            this.Controls.Add(this.lbNum2);
            this.Controls.Add(this.lbNum1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RandomNumbers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Number";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RandomNumbers_FormClosing);
            this.Load += new System.EventHandler(this.RandomNumbers_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNum1;
        private System.Windows.Forms.Label lbNum2;
        private System.Windows.Forms.Label lbNum3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.RadioButton rd11;
        private System.Windows.Forms.Button rdPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPoint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}