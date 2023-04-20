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
    public partial class RandomNumbers : Form
    {
        public RandomNumbers()
        {
            InitializeComponent();
        }

        #region Biến toàn cục

        int point;

        #endregion

        private void rdPlay_Click(object sender, EventArgs e)
        {
            if (rd3.Checked == false && rd11.Checked == false)
                MessageBox.Show("Vui lòng chọn option!!!");
            else
            {
                Random rand = new Random();
                int num1 = rand.Next(0, 10); // random (0 -> 9)
                int num2 = rand.Next(0, 10);
                int num3 = rand.Next(0, 10);

                lbNum1.Text = num1.ToString();
                lbNum2.Text = num2.ToString();
                lbNum3.Text = num3.ToString();

                int sum = num1 + num2 + num3;
                int minNumLeft = 3;
                int maxNumLeft = 10;

                int minNumRight = 11;
                int maxNumRight = 18;

                if (rd3.Checked)
                {
                    if ((sum >= minNumLeft && sum <= maxNumLeft))
                        point += 10;
                    else
                        point -= 10;
                }

                if (rd11.Checked)
                {
                    if ((sum >= minNumRight && sum <= maxNumRight))
                        point += 10;
                    else
                        point -= 10;
                }

                lbPoint.Text = point.ToString();
            }
        }

        private void RandomNumbers_Load(object sender, EventArgs e)
        {
            point = 0;
            rd3.Checked = false;
            rd11.Checked = false;
            lbNum1.Text = lbNum2.Text = lbNum3.Text = lbPoint.Text = "";
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            if (rd3.Checked == false && rd11.Checked == false)
                MessageBox.Show("Chưa chơi mà đã đòi chơi lại!!!");
            else
            {
                point = 0;
                rd3.Checked = false;
                rd11.Checked = false;
                lbNum1.Text = lbNum2.Text = lbNum3.Text = lbPoint.Text = point.ToString();
            }
        }

        private void rd_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                radioButton.BackColor = Color.AntiqueWhite;
            }
            else
            {
                radioButton.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RandomNumbers_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = false;
        }
    }
}
