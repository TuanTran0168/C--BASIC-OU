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
    public partial class MayTinhMini : Form
    {
        public MayTinhMini()
        {
            InitializeComponent();
        }

        private void MayTinhMini_Load(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumber1.Text == "" || txtNumber2.Text == "")
                    throw new Exception("Bạn phải nhập số đầy đủ vào các ô trống!!!");
  
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                double result = -999999999999999999;

                if (rdAdd.Checked)
                {
                    result = num1 + num2;
                }

                if (rdSub.Checked)
                {
                    result = num1 - num2;
                }

                if (rdMul.Checked)
                {
                    result = num1 * num2;
                }

                if (rdDiv.Checked)
                {
                    if (num2 == 0)
                    {
                        throw new Exception("Không thể thực hiện phép chia cho 0!!!");
                    }
                    result = num1 / num2;
                }

                if (rdMod.Checked)
                {
                    result = (int) num1 % num2;
                }

                txtResult.Text = result.ToString();

            }

            catch (FormatException)
            {
                MessageBox.Show("Vui lòng chỉ nhập số!!!");
            }

            catch (DivideByZeroException)   // Chia số kiểu double không bắt được (Phế)
            {
                MessageBox.Show("Không thể thực hiện phép chia cho 0!!!");
            }

            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MayTinhMini_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
                e.Cancel = true;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            txtNumber1.Text = txtNumber2.Text = txtResult.Text = ""; 
        }

        private void rdAdd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdSub_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdMul_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdDiv_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdMod_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelBIG_Click(object sender, EventArgs e)
        {
            // Chưa làm xong
            //int x = 0;
            //int y = 0;
            //labelBIG.Location = new Point(x, y);
        }
    }
}
