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
    public partial class XucSac : Form
    {
        public XucSac()
        {
            InitializeComponent();
        }

        string path;
        int soNguoiChoiChon;
        int soLanChoi;
        int soLanThang;
        int soLanThua;

        public void khoiTao()
        {
            soNguoiChoiChon = 1;
            soLanChoi = 0;
            soLanThang = 0;
            soLanThua = 0;
            picNguoiChoiChon.Image = Image.FromFile(path + soNguoiChoiChon + ".png");
            picDapAn.Image = null;
            
            listKetQua.Items.Clear();
        }

        private void XucSac_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath + @"\Dice\";
            khoiTao();
        }

        private void Play()
        {
            soLanChoi++;

            Random random = new Random();
            int soRandom = random.Next(1, 7);
            picDapAn.Image = Image.FromFile(path + soRandom + ".png");

            string ketQua = "";

            if (soNguoiChoiChon == soRandom)
            {
                ketQua = "Thắng";
                soLanThang++;
            }
            else
            {
                ketQua = "Thua";
                soLanThua++;
            }

            listKetQua.Items.Add(String.Format("{0}. {1} (Đoán {2} ra {3})", soLanChoi, ketQua, soNguoiChoiChon, soRandom));
            listKetQua.SelectedIndex = listKetQua.Items.Count - 1;

            lbDoan.Text = String.Format("Lần đoán: {0}", soLanChoi);
            lbThang.Text = String.Format("Lần thắng: {0} ({1:0.00}%)", soLanThang, (double)soLanThang * 100 / soLanChoi);
            lbThua.Text = String.Format("Lần thua: {0} ({1:0.00}%)", soLanThua, (double)soLanThua * 100 / soLanChoi);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Play();
            
        }

        private void nhanButton(Button btn)
        {
            soNguoiChoiChon = int.Parse(btn.Text);
            picNguoiChoiChon.Image = Image.FromFile(path + btn.Text + ".png");
        }

        private void btnChonSo_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            nhanButton(btn);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            khoiTao();
            btnReset.Focus();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                Play();
                btnPlay.Focus();
                return true;
            }
            else if (keyData == Keys.Escape)
            {
                khoiTao();
                btnReset.Focus();
                return true;
            }
            else if (keyData == Keys.D1)
            {
                nhanButton(btn1);
                return true;
            }
            else if (keyData == Keys.D2)
            {
                nhanButton(btn2);
                return true;
            }
            else if (keyData == Keys.D3)
            {
                nhanButton(btn3);
                return true;
            }
            else if (keyData == Keys.D4)
            {
                nhanButton(btn4);
                return true;
            }
            else if (keyData == Keys.D5)
            {
                nhanButton(btn5);
                return true;
            }
            else if (keyData == Keys.D6)
            {
                nhanButton(btn6);
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
