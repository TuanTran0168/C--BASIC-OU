namespace BaiTapThucHanhOnline
{
    partial class SecurityPanel
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
            this.txtPassCode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listAccessLog = new System.Windows.Forms.ListBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Security Code:";
            // 
            // txtPassCode
            // 
            this.txtPassCode.Location = new System.Drawing.Point(308, 60);
            this.txtPassCode.Name = "txtPassCode";
            this.txtPassCode.PasswordChar = '*';
            this.txtPassCode.Size = new System.Drawing.Size(271, 45);
            this.txtPassCode.TabIndex = 1;
            this.txtPassCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPassCode_KeyDown);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(146, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(246, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(347, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Yellow;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Location = new System.Drawing.Point(447, 151);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 70);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "C";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(146, 248);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 70);
            this.button5.TabIndex = 2;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(246, 248);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 70);
            this.button6.TabIndex = 2;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btn_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Location = new System.Drawing.Point(347, 248);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 70);
            this.button7.TabIndex = 2;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.Location = new System.Drawing.Point(447, 248);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(70, 70);
            this.btn.TabIndex = 2;
            this.btn.Text = "#";
            this.btn.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Location = new System.Drawing.Point(146, 350);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 70);
            this.button9.TabIndex = 2;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btn_Click);
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Location = new System.Drawing.Point(246, 350);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(70, 70);
            this.button10.TabIndex = 2;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btn_Click);
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Location = new System.Drawing.Point(347, 350);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(70, 70);
            this.button11.TabIndex = 2;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btn_Click);
            // 
            // button12
            // 
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Location = new System.Drawing.Point(447, 350);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(70, 70);
            this.button12.TabIndex = 2;
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Access Log:";
            // 
            // listAccessLog
            // 
            this.listAccessLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.listAccessLog.Font = new System.Drawing.Font("Poor Richard", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAccessLog.FormattingEnabled = true;
            this.listAccessLog.HorizontalScrollbar = true;
            this.listAccessLog.ItemHeight = 28;
            this.listAccessLog.Location = new System.Drawing.Point(79, 496);
            this.listAccessLog.Name = "listAccessLog";
            this.listAccessLog.Size = new System.Drawing.Size(499, 200);
            this.listAccessLog.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Location = new System.Drawing.Point(385, 427);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(132, 63);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Save";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // SecurityPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(659, 722);
            this.Controls.Add(this.listAccessLog);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPassCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Poor Richard", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "SecurityPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security Panel";
            this.Load += new System.EventHandler(this.SecurityPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listAccessLog;
        private System.Windows.Forms.Button btnLuu;
    }
}