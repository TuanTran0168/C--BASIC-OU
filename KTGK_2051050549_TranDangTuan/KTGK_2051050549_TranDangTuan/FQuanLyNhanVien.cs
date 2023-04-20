using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTGK_2051050549_TranDangTuan
{
    public partial class FQuanLyNhanVien : Form
    {
        public FQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            if(txtHoTen.Text != String.Empty || txtDiaChi.Text != String.Empty || txtDienThoai.Text != String.Empty)
            {
                item = new ListViewItem(txtHoTen.Text);
                item.SubItems.Add(dateTimePicker1.Value.ToString());
                item.SubItems.Add(txtDiaChi.Text);
                item.SubItems.Add(txtDienThoai.Text);
                listView1.Items.Add(item);
                txtHoTen.Text = "";
                txtDiaChi.Text = "";
                txtDienThoai.Text = "";
                txtHoTen.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].SubItems[0].Text = txtHoTen.Text;
            listView1.SelectedItems[0].SubItems[1].Text = dateTimePicker1.Value.ToString();
            listView1.SelectedItems[0].SubItems[2].Text = txtDiaChi.Text;
            listView1.SelectedItems[0].SubItems[3].Text = txtDienThoai.Text;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtHoTen.Text = listView1.SelectedItems[0].SubItems[0].Text;
                dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtDiaChi.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtDienThoai.Text = listView1.SelectedItems[0].SubItems[3].Text;

            }
        }
    }
}
