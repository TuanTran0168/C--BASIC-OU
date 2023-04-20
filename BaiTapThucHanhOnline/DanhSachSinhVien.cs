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
    public partial class DanhSachSinhVien : Form
    {
        public DanhSachSinhVien()
        {
            InitializeComponent();
        }

        private void capNhat()
        {
            if (txtHoTen.Text != "")
            {
                listBoxA.Items.Add(txtHoTen.Text);
                txtHoTen.Text = "";
                txtHoTen.Focus();
            }
            else
            {
                MessageBox.Show("Bạn không được bỏ trống");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            capNhat();
        }

        private void DanhSachSinhVien_Load(object sender, EventArgs e)
        {
            listBoxA.SelectionMode = SelectionMode.MultiSimple;
            listBoxB.SelectionMode = SelectionMode.MultiSimple;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                capNhat();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void btnTrai1_Click(object sender, EventArgs e)
        {
            // Danh sách các phần tử được chọn theo Text
            ListBox.SelectedObjectCollection ds = listBoxA.SelectedItems;
            // Danh sách các phần tử được chọn theo vị trí
            ListBox.SelectedIndexCollection ds2 = listBoxA.SelectedIndices;

            foreach (string item in ds)
            {
                listBoxB.Items.Add(item);
            }

            for (int i = ds2.Count - 1; i >= 0; i--)
            {
                listBoxA.Items.RemoveAt(ds2[i]);
            }
        }

        private void btnPhai1_Click(object sender, EventArgs e)
        {
            // Danh sách các phần tử được chọn theo vị trí
            ListBox.SelectedIndexCollection ds2 = listBoxB.SelectedIndices;
            
            while (listBoxB.SelectedIndices.Count > 0)
            {
                listBoxA.Items.Add(listBoxB.Items[listBoxB.SelectedIndices[0]]);
                listBoxB.Items.RemoveAt(listBoxB.SelectedIndices[0]);
            }
        }

        private void btnTrai2_Click(object sender, EventArgs e)
        {
            listBoxB.Items.AddRange(listBoxA.Items);
            listBoxA.Items.Clear();
        }

        private void btnPhai2_Click(object sender, EventArgs e)
        {
            listBoxA.Items.AddRange(listBoxB.Items);
            listBoxA.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            listBoxA.Items.Clear();
            listBoxA.Items.Clear();
        }
    }
}
