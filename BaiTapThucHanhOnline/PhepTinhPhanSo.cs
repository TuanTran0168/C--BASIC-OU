using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaiTapThucHanhOnline.Class;

namespace BaiTapThucHanhOnline
{
    public partial class PhepTinhPhanSo : Form
    {
        public PhepTinhPhanSo()
        {
            InitializeComponent();
        }

        PhanSo p1, p2;

        private void PhanSo_Load(object sender, EventArgs e)
        {
            p1 = new PhanSo();
            p2 = new PhanSo();
        }

        private void PhepTinhPhanSo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }   
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            PhanSo ketQua = null;

            try
            {
                if (txtTu1.Text == "" || txtTu2.Text == "" || txtMau1.Text == "" | txtMau2.Text == "")
                {
                    throw new Exception("Phải nhập giá trị cho 2 phân số");
                }

                p1.TuSo = int.Parse(txtTu1.Text);
                p1.MauSo = int.Parse(txtMau1.Text);
                p2.TuSo = int.Parse(txtTu2.Text);
                p2.MauSo = int.Parse(txtMau2.Text);

                if (p2.MauSo == 0 || p1.MauSo == 0)
                {
                    throw new Exception("Mẫu số phải khác không");
                }

                string toanTu = btn.Text;
                lbPhepToan.Text = toanTu;

                if (toanTu == "+")
                {
                    ketQua = p1.Cong(p2);
                }
                else if (toanTu == "-")
                {
                    ketQua = p1.Tru(p2);
                }
                else if (toanTu == "*")
                {
                    ketQua = p1.Nhan(p2);
                }
                else
                {
                    ketQua = p1.Chia(p2);
                }

                txtTuDapAn.Text = ketQua.TuSo.ToString();
                txtMauDapAn.Text = ketQua.MauSo.ToString();

                txtTu1.Focus();

            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn phải nhập số");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
