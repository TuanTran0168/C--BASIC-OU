namespace BaiTapThucHanhOnline
{
    partial class DanhSachSinhVien
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxA = new System.Windows.Forms.ListBox();
            this.listBoxB = new System.Windows.Forms.ListBox();
            this.btnTrai1 = new System.Windows.Forms.Button();
            this.btnTrai2 = new System.Windows.Forms.Button();
            this.btnPhai1 = new System.Windows.Forms.Button();
            this.btnPhai2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(906, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(45, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và Tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(198, 100);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(495, 45);
            this.txtHoTen.TabIndex = 2;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhat.Location = new System.Drawing.Point(699, 100);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(134, 45);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(51, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 336);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(551, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 336);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B:";
            // 
            // listBoxA
            // 
            this.listBoxA.FormattingEnabled = true;
            this.listBoxA.ItemHeight = 31;
            this.listBoxA.Location = new System.Drawing.Point(7, 47);
            this.listBoxA.Name = "listBoxA";
            this.listBoxA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxA.Size = new System.Drawing.Size(269, 283);
            this.listBoxA.TabIndex = 0;
            // 
            // listBoxB
            // 
            this.listBoxB.FormattingEnabled = true;
            this.listBoxB.ItemHeight = 31;
            this.listBoxB.Location = new System.Drawing.Point(13, 47);
            this.listBoxB.Name = "listBoxB";
            this.listBoxB.Size = new System.Drawing.Size(269, 283);
            this.listBoxB.TabIndex = 0;
            // 
            // btnTrai1
            // 
            this.btnTrai1.Location = new System.Drawing.Point(340, 262);
            this.btnTrai1.Name = "btnTrai1";
            this.btnTrai1.Size = new System.Drawing.Size(75, 75);
            this.btnTrai1.TabIndex = 5;
            this.btnTrai1.Text = ">";
            this.btnTrai1.UseVisualStyleBackColor = true;
            this.btnTrai1.Click += new System.EventHandler(this.btnTrai1_Click);
            // 
            // btnTrai2
            // 
            this.btnTrai2.Location = new System.Drawing.Point(340, 383);
            this.btnTrai2.Name = "btnTrai2";
            this.btnTrai2.Size = new System.Drawing.Size(75, 75);
            this.btnTrai2.TabIndex = 5;
            this.btnTrai2.Text = ">>";
            this.btnTrai2.UseVisualStyleBackColor = true;
            this.btnTrai2.Click += new System.EventHandler(this.btnTrai2_Click);
            // 
            // btnPhai1
            // 
            this.btnPhai1.Location = new System.Drawing.Point(470, 262);
            this.btnPhai1.Name = "btnPhai1";
            this.btnPhai1.Size = new System.Drawing.Size(75, 75);
            this.btnPhai1.TabIndex = 5;
            this.btnPhai1.Text = "<";
            this.btnPhai1.UseVisualStyleBackColor = true;
            this.btnPhai1.Click += new System.EventHandler(this.btnPhai1_Click);
            // 
            // btnPhai2
            // 
            this.btnPhai2.Location = new System.Drawing.Point(470, 383);
            this.btnPhai2.Name = "btnPhai2";
            this.btnPhai2.Size = new System.Drawing.Size(75, 75);
            this.btnPhai2.TabIndex = 5;
            this.btnPhai2.Text = "<<";
            this.btnPhai2.UseVisualStyleBackColor = true;
            this.btnPhai2.Click += new System.EventHandler(this.btnPhai2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(131, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(638, 532);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 56);
            this.button2.TabIndex = 6;
            this.button2.Text = "Kết thúc";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DanhSachSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 611);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPhai2);
            this.Controls.Add(this.btnTrai2);
            this.Controls.Add(this.btnPhai1);
            this.Controls.Add(this.btnTrai1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "DanhSachSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachSinhVien";
            this.Load += new System.EventHandler(this.DanhSachSinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxA;
        private System.Windows.Forms.ListBox listBoxB;
        private System.Windows.Forms.Button btnTrai1;
        private System.Windows.Forms.Button btnTrai2;
        private System.Windows.Forms.Button btnPhai1;
        private System.Windows.Forms.Button btnPhai2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}