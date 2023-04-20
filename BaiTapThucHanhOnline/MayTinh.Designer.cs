namespace BaiTapThucHanhOnline
{
    partial class MayTinh
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
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(266, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÁC PHÉP TÍNH ĐƠN GIẢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ 1:";
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(220, 129);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(129, 38);
            this.txtSo1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số thứ 2:";
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(574, 132);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(129, 38);
            this.txtSo2.TabIndex = 2;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(135, 226);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(79, 48);
            this.btnCong.TabIndex = 3;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(279, 226);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(79, 48);
            this.btnTru.TabIndex = 3;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(424, 226);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(79, 48);
            this.btnNhan.TabIndex = 3;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(554, 226);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(79, 48);
            this.btnChia.TabIndex = 3;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kết quả:";
            // 
            // txtKetqua
            // 
            this.txtKetqua.Enabled = false;
            this.txtKetqua.Location = new System.Drawing.Point(320, 322);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(220, 38);
            this.txtKetqua.TabIndex = 2;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(358, 408);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(128, 48);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // MayTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 516);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MayTinh";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Button btnDong;
    }
}