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
    public partial class TimSoLonNhat : Form
    {
        public TimSoLonNhat()
        {
            InitializeComponent();
        }

        private void TimSoLonNhat_Load(object sender, EventArgs e)
        {

        }

        private void btnSoSanh_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoA.Text == "" || txtSoB.Text == "")
                    throw new Exception("Quên nhập số kìa :)))");

                int a = int.Parse(txtSoA.Text);
                int b = int.Parse(txtSoB.Text);

                if (a > b)
                    txtKetQua.Text = "Số lớn nhất là: " + a.ToString();
                else
                    txtKetQua.Text = String.Format("Số lớn nhất là: {0}", b);
                
                txtSoA.Focus();
            }

            catch (FormatException)
            {
                MessageBox.Show("Đừng có nhập chữ, làm ơn :))");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtSoA.Text = txtSoB.Text = txtKetQua.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TimSoLonNhat_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát thật chứ?", "Giờ sao?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
                e.Cancel = true;
        }
    }
}