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
    public partial class DiChuyenAnh : Form
    {
        public DiChuyenAnh()
        {
            InitializeComponent();
        }

        string path;
        Point viTriCuCuaAnh;
        int tocDoDiChuyen;
        int picAnhCount;

        PictureBox picAnh;
        private void taoAnh()
        {
            picAnh = new PictureBox();
            picAnh.Name = "pic" + picAnhCount.ToString();

            Random random = new Random();
            picAnh.Width = 70;
            picAnh.Height = 70;
            picAnh.SizeMode = PictureBoxSizeMode.StretchImage;


            picAnh.Image = Image.FromFile(path + random.Next(1, 11) + ".jpg");
            

            picAnh.MouseDown += picAnh_MouseDown;
            picAnh.MouseMove += picAnh_MouseMove;
            picAnh.MouseUp += picAnh_MouseUp;

            this.Controls.Add(picAnh);

            picAnh.Cursor = Cursors.Hand;
            picAnh.BringToFront();
            flpPicture.SendToBack();
        }

        private void DiChuyenAnh_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath + @"\Image\";
            taoAnh();

            tocDoDiChuyen = 10;
            picAnhCount = 0;
        }

        private void picAnh_MouseDown(object sender, MouseEventArgs e)
        {
            viTriCuCuaAnh = e.Location;
        }

        private void picAnh_MouseMove(object sender, MouseEventArgs e)
        {
            int dx, dy;

            if (e.Button == MouseButtons.Left)
            {
                dx = e.X - viTriCuCuaAnh.X;
                dy = e.Y - viTriCuCuaAnh.Y;

                picAnh.Left += dx;
                picAnh.Top += dy;
            }
        }

        private void kiemTraVaThemAnh()
        {
            if (flpPicture.Bounds.Contains(picAnh.Bounds))
            {
                flpPicture.Controls.Add(picAnh);
                taoAnh();
            }
        }

        private void picAnh_MouseUp(object sender, MouseEventArgs e)
        {
            kiemTraVaThemAnh();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                picAnh.Top -= tocDoDiChuyen;
                if (flpPicture.Bounds.Contains(picAnh.Bounds))
                {
                    flpPicture.Controls.Add(picAnh);
                    taoAnh();
                }
                return true;
            }
            if (keyData == Keys.Down)
            {
                picAnh.Top += tocDoDiChuyen;
                if (flpPicture.Bounds.Contains(picAnh.Bounds))
                {
                    flpPicture.Controls.Add(picAnh);
                    taoAnh();
                }
                return true;
            }
            if (keyData == Keys.Left)
            {
                picAnh.Left -= tocDoDiChuyen;
                if (flpPicture.Bounds.Contains(picAnh.Bounds))
                {
                    flpPicture.Controls.Add(picAnh);
                    taoAnh();
                }
                return true;
            }
            if (keyData == Keys.Right)
            {
                picAnh.Left += tocDoDiChuyen;
                if (flpPicture.Bounds.Contains(picAnh.Bounds))
                {
                    flpPicture.Controls.Add(picAnh);
                    taoAnh();
                }
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
