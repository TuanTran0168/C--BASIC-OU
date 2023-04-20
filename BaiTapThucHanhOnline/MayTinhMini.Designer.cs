namespace BaiTapThucHanhOnline
{
    partial class MayTinhMini
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
            this.labelBIG = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdMod = new System.Windows.Forms.RadioButton();
            this.rdDiv = new System.Windows.Forms.RadioButton();
            this.rdMul = new System.Windows.Forms.RadioButton();
            this.rdSub = new System.Windows.Forms.RadioButton();
            this.rdAdd = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBIG
            // 
            this.labelBIG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBIG.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelBIG.Font = new System.Drawing.Font("Showcard Gothic", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBIG.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelBIG.Location = new System.Drawing.Point(2, 19);
            this.labelBIG.Name = "labelBIG";
            this.labelBIG.Size = new System.Drawing.Size(959, 121);
            this.labelBIG.TabIndex = 0;
            this.labelBIG.Text = "MÁY TÍNH MINI";
            this.labelBIG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBIG.Click += new System.EventHandler(this.labelBIG_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdMod);
            this.groupBox1.Controls.Add(this.rdDiv);
            this.groupBox1.Controls.Add(this.rdMul);
            this.groupBox1.Controls.Add(this.rdSub);
            this.groupBox1.Controls.Add(this.rdAdd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(-1, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 124);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép tính";
            // 
            // rdMod
            // 
            this.rdMod.AutoSize = true;
            this.rdMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdMod.Location = new System.Drawing.Point(784, 38);
            this.rdMod.Name = "rdMod";
            this.rdMod.Size = new System.Drawing.Size(113, 80);
            this.rdMod.TabIndex = 0;
            this.rdMod.TabStop = true;
            this.rdMod.Text = "%";
            this.rdMod.UseVisualStyleBackColor = true;
            this.rdMod.CheckedChanged += new System.EventHandler(this.rdMod_CheckedChanged);
            // 
            // rdDiv
            // 
            this.rdDiv.AutoSize = true;
            this.rdDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdDiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdDiv.Location = new System.Drawing.Point(621, 38);
            this.rdDiv.Name = "rdDiv";
            this.rdDiv.Size = new System.Drawing.Size(72, 80);
            this.rdDiv.TabIndex = 0;
            this.rdDiv.TabStop = true;
            this.rdDiv.Text = "/";
            this.rdDiv.UseVisualStyleBackColor = true;
            this.rdDiv.CheckedChanged += new System.EventHandler(this.rdDiv_CheckedChanged);
            // 
            // rdMul
            // 
            this.rdMul.AutoSize = true;
            this.rdMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdMul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdMul.Location = new System.Drawing.Point(444, 38);
            this.rdMul.Name = "rdMul";
            this.rdMul.Size = new System.Drawing.Size(79, 80);
            this.rdMul.TabIndex = 0;
            this.rdMul.TabStop = true;
            this.rdMul.Text = "*";
            this.rdMul.UseVisualStyleBackColor = true;
            this.rdMul.CheckedChanged += new System.EventHandler(this.rdMul_CheckedChanged);
            // 
            // rdSub
            // 
            this.rdSub.AutoSize = true;
            this.rdSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdSub.Location = new System.Drawing.Point(263, 38);
            this.rdSub.Name = "rdSub";
            this.rdSub.Size = new System.Drawing.Size(75, 80);
            this.rdSub.TabIndex = 0;
            this.rdSub.TabStop = true;
            this.rdSub.Text = "-";
            this.rdSub.UseVisualStyleBackColor = true;
            this.rdSub.CheckedChanged += new System.EventHandler(this.rdSub_CheckedChanged);
            // 
            // rdAdd
            // 
            this.rdAdd.AutoSize = true;
            this.rdAdd.Checked = true;
            this.rdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdAdd.Location = new System.Drawing.Point(95, 38);
            this.rdAdd.Name = "rdAdd";
            this.rdAdd.Size = new System.Drawing.Size(92, 80);
            this.rdAdd.TabIndex = 0;
            this.rdAdd.TabStop = true;
            this.rdAdd.Text = "+";
            this.rdAdd.UseVisualStyleBackColor = true;
            this.rdAdd.CheckedChanged += new System.EventHandler(this.rdAdd_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(87, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số thứ 1: ";
            // 
            // txtNumber1
            // 
            this.txtNumber1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.txtNumber1.Location = new System.Drawing.Point(264, 164);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(178, 60);
            this.txtNumber1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(467, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số thứ 2: ";
            // 
            // txtNumber2
            // 
            this.txtNumber2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.txtNumber2.Location = new System.Drawing.Point(644, 164);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(178, 60);
            this.txtNumber2.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtResult.Location = new System.Drawing.Point(111, 403);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(703, 74);
            this.txtResult.TabIndex = 4;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTotal.ForeColor = System.Drawing.Color.Navy;
            this.btnTotal.Location = new System.Drawing.Point(201, 519);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(241, 75);
            this.btnTotal.TabIndex = 3;
            this.btnTotal.Text = "TÍNH";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.ForeColor = System.Drawing.Color.Navy;
            this.btnDelete.Location = new System.Drawing.Point(499, 519);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(241, 75);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "XÓA";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(352, 612);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 75);
            this.button1.TabIndex = 6;
            this.button1.Text = "ĐÓNG";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = global::BaiTapThucHanhOnline.Properties.Resources.LogoC_PNG21;
            this.pictureBox1.Image = global::BaiTapThucHanhOnline.Properties.Resources.LogoC_PNG21;
            this.pictureBox1.Location = new System.Drawing.Point(62, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.ErrorImage = global::BaiTapThucHanhOnline.Properties.Resources.LogoC_PNG21;
            this.pictureBox2.Image = global::BaiTapThucHanhOnline.Properties.Resources.LogoC_PNG21;
            this.pictureBox2.Location = new System.Drawing.Point(764, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // MayTinhMini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(960, 711);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelBIG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MayTinhMini";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máy tính Mini";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MayTinhMini_FormClosing);
            this.Load += new System.EventHandler(this.MayTinhMini_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBIG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdAdd;
        private System.Windows.Forms.RadioButton rdDiv;
        private System.Windows.Forms.RadioButton rdMul;
        private System.Windows.Forms.RadioButton rdSub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton rdMod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}