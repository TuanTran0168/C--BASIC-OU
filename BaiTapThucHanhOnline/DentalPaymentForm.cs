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
    public partial class DentalPaymentForm : Form
    {
        public DentalPaymentForm()
        {
            InitializeComponent();
        }

        private void DentalPaymentForm_Load(object sender, EventArgs e)
        {
            btnTinhTien.Enabled = false;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (checkBoxCaoVoi.Checked)
            {
                total += 100000;
            }
         
            if (checkBoxTayTrang.Checked)
            {
                total += 1200000;
            }

            if (checkBoxChupHinhRang.Checked)
            {
                total += 200000;
            }

            total += (int)numericUpDownTramRang.Value * 80000;

            txtTotal.Text = total.ToString();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
                btnTinhTien.Enabled = false;
            else
                btnTinhTien.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
