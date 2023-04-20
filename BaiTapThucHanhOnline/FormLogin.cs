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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        bool co;
        int soLan;
        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
            co = false;
            soLan = 3;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == String.Empty || txtMatKhau.Text != "admin")
            {
                if (soLan > 1)
                {
                    MessageBox.Show("Sai rồi");
                }
                soLan--;

                if (soLan == 0)
                {
                    MessageBox.Show("Khóa acc");
                }
                //Application.Exit();
            }
            else
            {
                MainForm.tenDangNhap = txtTenDangNhap.Text;
                co = true;
                this.Close();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (co == false)
            {
                Application.Exit();
            }
        }
    }
}
