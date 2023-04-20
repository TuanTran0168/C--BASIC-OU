using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThucHanhOnline
{
    public partial class SecurityPanel : Form
    {
        public SecurityPanel()
        {
            InitializeComponent();
        }

        private void SecurityPanel_Load(object sender, EventArgs e)
        {

        }

        private void textPassCode_KeyDown(object sender, KeyEventArgs e)
        {
            string code = txtPassCode.Text;
            string groupAccess;

            if (e.KeyCode == Keys.Enter)
            {
                if (code == "1645" || code == "1689")
                {
                    groupAccess = "Technician";
                }
                else if (code == "8345")
                {
                    groupAccess = "Custodians";
                }
                else if (code == "9998" || code == "1006" || code == "1008")
                {
                    groupAccess = "Scientist";
                }
                else if (code.Length == 1)
                {
                    groupAccess = "Restricted Access";
                }
                else
                {
                    groupAccess = "Access denied";
                }
                
                listAccessLog.Items.Add(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\t" + groupAccess);
                //listAccessLog.Items.Add(String.Format("{0:dd/MM/yyyy hh:mm:ss}\t{1}", DateTime.Now, groupAccess));

                txtPassCode.Text = "";
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtPassCode.Text += btn.Text;
            txtPassCode.Focus();
            txtPassCode.SelectionStart = txtPassCode.Text.Length;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtPassCode.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string path = @"E:\TXT\GiaoDien\AccessLog.txt";
            StreamWriter streamWriter;

            if (File.Exists(path) == false)
            {
                streamWriter = new StreamWriter(path); // Chưa có file thì tạo mới

                foreach (string item in listAccessLog.Items)
                {
                    streamWriter.WriteLine(item);
                }
                streamWriter.Close();
            }
            else
            {
                streamWriter = File.AppendText(path); // Có file rồi điền thêm

                foreach (string item in listAccessLog.Items)
                {
                    streamWriter.WriteLine(item);
                }
                streamWriter.Close();
            }

            txtPassCode.Focus();
            txtPassCode.SelectionStart = txtPassCode.Text.Length;
        }
    }
}
