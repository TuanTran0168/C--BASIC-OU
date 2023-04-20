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
    public partial class MainForm : Form
    {
        public static string tenDangNhap;
        public MainForm()
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbTenDangNhap.Text = tenDangNhap;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtHoTen.Text == "")
                return;

            ListViewItem item = new ListViewItem(txtHoTen.Text);
            item.SubItems.Add(dateTimePicker1.Value.ToShortDateString());
            item.SubItems.Add((rdNam.Checked ? rdNam : rdNu).Text);
            item.ImageIndex = rdNam.Checked ? 0 : 1;

            listView1.Items.Add(item);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
        }
    }
}