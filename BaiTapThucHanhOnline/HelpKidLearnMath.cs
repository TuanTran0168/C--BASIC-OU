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
    public partial class HelpKidLearnMath : Form
    {
        public HelpKidLearnMath()
        {
            InitializeComponent();
        }

        private void btnNum_MouseClick(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;

            txtTraLoi.Text += btn.Text;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(lbSo1.Text);
                int num2 = int.Parse(lbSo2.Text);
                string chuoiPhepTinh = lbPhepTinh.Text;

                int result = 0;

                if (chuoiPhepTinh == "+")
                {
                    result = num1 + num2;
                }
                else if (chuoiPhepTinh == "-")
                {
                    result = num1 - num2;
                }
                else if (chuoiPhepTinh == "*")
                {
                    result = num1 * num2;
                }
                else if (chuoiPhepTinh == "/")
                {
                    result = num1 / num2;
                }
                else if (chuoiPhepTinh == "%")
                {
                    result = num1 % num2;
                }

                string chuoiTraLoi = txtTraLoi.Text;
                if (chuoiTraLoi == "")
                {
                    throw new Exception("Bạn không được bỏ trống!!!");
                }

                double answer = double.Parse(chuoiTraLoi);
                if (result == answer)
                {
                    txtKetQua.Text = "Chính xác! Đáp án là: " + answer;
                }
                else
                {
                    txtKetQua.Text = "Sai rồi! Đáp án là: " + result;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn phải nhập số!!!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            try
            {
                string chuoiTraLoi = txtTraLoi.Text;
                string chuoiKetQua = txtKetQua.Text;
                if (chuoiTraLoi != "" && chuoiKetQua == "")
                {
                    throw new Exception("Bạn không xem kết quả à???");
                }

                if (chuoiTraLoi == "" && chuoiKetQua != "")
                {
                    throw new Exception("Bạn không được bỏ trống!!!");
                }

                string[] arrOperator = { "+", "-", "*", "/", "%" };
                Random rand = new Random();
                int randIndex = rand.Next(5);
                lbPhepTinh.Text = arrOperator[randIndex];

                int randNum1 = rand.Next(0, 10);
                int randNum2 = rand.Next(0, 10);

                if ((randIndex == 3 && randNum2 == 0) || (randIndex == 4 && randNum2 == 0))
                {
                    randNum2 = rand.Next(1, 10);
                }

                lbSo1.Text = randNum1.ToString();
                lbSo2.Text = randNum2.ToString();

                if (chuoiTraLoi != "" && chuoiKetQua != "")
                    txtKetQua.Text = txtTraLoi.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            string chuoiTraLoi = txtTraLoi.Text;
            if (chuoiTraLoi != "")
            {
                chuoiTraLoi = chuoiTraLoi.Substring(0, chuoiTraLoi.Length - 1);
                txtTraLoi.Text = chuoiTraLoi;
            }
        }

        private void btnDauAm_Click(object sender, EventArgs e)
        {
            string chuoiTraLoi = txtTraLoi.Text;
            int lengthOfChuoiTraLoi = chuoiTraLoi.Length;

            if (chuoiTraLoi == "")
            {
                chuoiTraLoi = "-" + chuoiTraLoi;
            }
            else
            {
                if (chuoiTraLoi.Substring(0, 1) == "-") // Có dấu trừ
                {
                    if (lengthOfChuoiTraLoi > 1) // Chuỗi dài hơn 1
                    {
                        chuoiTraLoi = chuoiTraLoi.Substring(1, lengthOfChuoiTraLoi - 1);
                    }
                    else // Chuỗi không dấu trừ mà chỉ có 1 kí tự mà nó là dấu trừ luôn
                    {
                        chuoiTraLoi = "";
                    }
                }
                else  // Không có dấu trừ
                {
                    chuoiTraLoi = "-" + chuoiTraLoi;
                }
            }

            txtTraLoi.Text = chuoiTraLoi;
        }

        private void HelpKidLearnMath_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
                e.Cancel = true;
        }

        private void HelpKidLearnMath_Load(object sender, EventArgs e)
        {

        }
    }
}
