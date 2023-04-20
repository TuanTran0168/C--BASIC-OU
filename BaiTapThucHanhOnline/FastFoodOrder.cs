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
    public partial class FastFoodOrder : Form
    {
        public FastFoodOrder()
        {
            InitializeComponent();
        }

        string[] tenBan = { "Bàn 1", "Bàn 2", "Bàn 3", "Bàn 4"};
        DataTable tableOrder;

        private void FastFoodOrder_Load(object sender, EventArgs e)
        {
            cbbTenBan.Items.AddRange(tenBan);
            tableOrder = new DataTable();
            tableOrder.Columns.Add("Món ăn");
            tableOrder.Columns.Add("Số lượng");

            dataGridViewOrder.DataSource = tableOrder;

            dataGridViewOrder.Columns[0].Width = (int) (dataGridViewOrder.Width * 0.5);
            dataGridViewOrder.Columns[1].Width = (int)(dataGridViewOrder.Width * 0.4);

            //listView1.View = View.Details;

            //listView1.Columns.Add("Món ăn", 200);
            //listView1.Columns.Add("Số lượng", 200);
        }

        private void cbbTenBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chọn " + cbbTenBan.Text);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DataRow row;
            bool check = true;

            foreach (DataRow item in tableOrder.Rows)
            {
                if (item[0].ToString() == btn.Text)
                {
                    check = false;
                    item[1] = int.Parse(item[1].ToString()) + 1;
                    break;
                }
            }

           if (check == true)
            {
                row = tableOrder.NewRow();
                row[0] = btn.Text;
                row[1] = 1;

                tableOrder.Rows.Add(row);
            }
            //ListViewItem item = new ListViewItem(btn.Text);
            //listView1.Items.Add(item);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tableOrder.Rows.Clear();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter;
            SaveFileDialog saveFileDialog;
            string fileName = "";

            saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
            }
            else
            {
                fileName = @"E:\TXT\GiaoDien\FileLog.txt";
            }

            streamWriter = new StreamWriter(fileName);
            for (int i = 0; i < dataGridViewOrder.Rows.Count - 1; i++)
            {
                streamWriter.WriteLine(dataGridViewOrder.Rows[i].Cells[0].Value.ToString() + " " + 
                    dataGridViewOrder.Rows[i].Cells[1].Value.ToString());
            }
            streamWriter.Close();
        }
    }
}
