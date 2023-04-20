namespace BaiTapThucHanhOnline
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbTenDangNhap = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageSmall = new System.Windows.Forms.ImageList(this.components);
            this.imageLarge = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Mistral", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1286, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Mongolian Baiti", 22F, System.Drawing.FontStyle.Bold);
            this.txtHoTen.Location = new System.Drawing.Point(198, 88);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(301, 50);
            this.txtHoTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 22F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 22F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 167);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(301, 50);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(198, 269);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(113, 44);
            this.rdNam.TabIndex = 5;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(352, 269);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(86, 44);
            this.rdNu.TabIndex = 5;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(198, 379);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 46);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(352, 379);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 46);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTenDangNhap.Location = new System.Drawing.Point(24, 501);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(475, 52);
            this.lbTenDangNhap.TabIndex = 7;
            this.lbTenDangNhap.Text = "label4";
            this.lbTenDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(522, 88);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(752, 465);
            this.listView1.SmallImageList = this.imageSmall;
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ tên";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày sinh";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giới tính";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quê quán";
            this.columnHeader4.Width = 177;
            // 
            // imageSmall
            // 
            this.imageSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageSmall.ImageStream")));
            this.imageSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageSmall.Images.SetKeyName(0, "student32.png");
            this.imageSmall.Images.SetKeyName(1, "studentgirl32.png");
            // 
            // imageLarge
            // 
            this.imageLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageLarge.ImageSize = new System.Drawing.Size(16, 16);
            this.imageLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 624);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbTenDangNhap);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 22F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lbTenDangNhap;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList imageLarge;
        private System.Windows.Forms.ImageList imageSmall;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}