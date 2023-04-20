using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThucHanhOnline
{
    public partial class GameTangBong : Form
    {
        public GameTangBong()
        {
            InitializeComponent();
        }

        int dx, dy;
        bool isGameOver;
        bool kiemTraVaCham;

        private void GameTangBong_Load(object sender, EventArgs e)
        {
            dx = 5;
            dy = 8;
            trangThaiBall = false;
            isGameOver = false;
            kiemTraVaCham = true;
        }

        private void KiemTraVaCham()
        {
            if (kiemTraVaCham == true)
            {
                if (btnThanhNgang.Bounds.IntersectsWith(picBall.Bounds))
                {
                    dy = -dy;
                    kiemTraVaCham = false;
                }
            }
        }

        private void DiChuyenTraiBanh()
        {
            if (isGameOver == false)
            {
                if (picBall.Left < 0 || picBall.Right > ClientRectangle.Width)
                {
                    dx = -dx;
                    kiemTraVaCham = true;
                }

                if (picBall.Top < 0)
                {
                    dy = -dy;
                    kiemTraVaCham = true;
                }

                picBall.Left += dx;
                picBall.Top += dy;

                // Thua
                if (/*picBall.Bottom > btnThanhNgang.Bottom*/ picBall.Bottom > ClientRectangle.Bottom + 100)
                {
                    isGameOver = true;
                }
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
                timer1.Dispose();
                MessageBox.Show("Bạn đã thua");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            KiemTraVaCham();
            DiChuyenTraiBanh();
        }

        bool trangThaiBall;
        int tocDoThanhNgang = 35;
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Space)
            {
                if (isGameOver == false)
                {
                    trangThaiBall = !trangThaiBall;
                    timer1.Enabled = trangThaiBall;
                    return true;
                }
            }

            if (keyData == Keys.Left)
            {
                if (btnThanhNgang.Left > 0)
                {
                    btnThanhNgang.Left -= tocDoThanhNgang;
                }
                return true;
            }

            if (keyData == Keys.Right)
            {
                if (btnThanhNgang.Right < ClientRectangle.Width)
                {
                    btnThanhNgang.Left += tocDoThanhNgang;
                }
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
