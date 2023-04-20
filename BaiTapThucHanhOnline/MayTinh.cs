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
    public partial class MayTinh : Form
    {
        public MayTinh()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int a, b;
            int kq = 0;
            try
            {
                a = Int32.Parse(txtSo1.Text);
                b = Int32.Parse(txtSo2.Text);
                switch (((Button)sender).Text)
                {
                    case "+":
                        kq = a + b;
                        break;
                    case "-":
                        kq = a - b;
                        break;
                    case "*":
                        kq = a * b;
                        break;
                    case "/":
                        kq = a / b;
                        break;
                    default:
                        break;
                }
                txtKetqua.Text = kq.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Không được phép nhập ký tự!!!");

            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Không được phép chia cho 0!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
