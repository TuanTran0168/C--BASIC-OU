namespace BaiTapThucHanhOnline
{
    partial class DiChuyenAnh
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
            this.flpPicture = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpPicture
            // 
            this.flpPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpPicture.Location = new System.Drawing.Point(665, 0);
            this.flpPicture.Name = "flpPicture";
            this.flpPicture.Size = new System.Drawing.Size(135, 562);
            this.flpPicture.TabIndex = 0;
            // 
            // DiChuyenAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.flpPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DiChuyenAnh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiChuyenAnh";
            this.Load += new System.EventHandler(this.DiChuyenAnh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPicture;
    }
}