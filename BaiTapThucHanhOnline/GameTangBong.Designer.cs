namespace BaiTapThucHanhOnline
{
    partial class GameTangBong
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
            this.picBall = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnThanhNgang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.SuspendLayout();
            // 
            // picBall
            // 
            this.picBall.Image = global::BaiTapThucHanhOnline.Properties.Resources.ball;
            this.picBall.Location = new System.Drawing.Point(297, 54);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(100, 100);
            this.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBall.TabIndex = 0;
            this.picBall.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnThanhNgang
            // 
            this.btnThanhNgang.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThanhNgang.BackColor = System.Drawing.Color.Brown;
            this.btnThanhNgang.Location = new System.Drawing.Point(297, 602);
            this.btnThanhNgang.Name = "btnThanhNgang";
            this.btnThanhNgang.Size = new System.Drawing.Size(379, 39);
            this.btnThanhNgang.TabIndex = 1;
            this.btnThanhNgang.UseVisualStyleBackColor = false;
            // 
            // GameTangBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 720);
            this.Controls.Add(this.btnThanhNgang);
            this.Controls.Add(this.picBall);
            this.Name = "GameTangBong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Tâng Bóng";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GameTangBong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnThanhNgang;
    }
}