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

namespace KTGK_2051050549_TranDangTuan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changeBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
                //listBox1.BackColor = colorDialog1.Color;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush solidBrush = new SolidBrush(Color.Green);
            StringFormat myFormat = new StringFormat();
            myFormat.Alignment = StringAlignment.Center;
            myFormat.LineAlignment = StringAlignment.Near;

            string chuoi = "Chương trình minh họa Game đoán hình";
            Font font = new Font("Arial", 20, FontStyle.Bold);

            g.DrawString(chuoi, font, solidBrush, new Point(600, 30), myFormat);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Bạn muốn thoát game", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dlgResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #region Biến toàn cục của Tuấn
        string path = @"D:\BaiThiCuaDangTuan\De3\Hinh\";
        string pathLuu = Application.StartupPath + "FileLog.txt";
        int diChuyen;
        bool dangChoiGame;
        int soNgauNhien1, soNgauNhien2;
        string tenHinh1, tenHinh2, tenHinh3, tenHinh4;
        string hinhNguoiChoiChon;
        int soLanChoi;
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox picClick = (PictureBox)sender;

            hinhNguoiChoiChon = picClick.Name.Substring(10, 1);

            if (soNgauNhien1.ToString() != hinhNguoiChoiChon && dangChoiGame == true)
            {
                soLanChoi++;

                if(soNgauNhien2.ToString() == hinhNguoiChoiChon)
                {
                    picClick.Image = Image.FromFile(path + "poooh2.jpg");

                    listBox1.Items.Add(soLanChoi + ". Thắng (Đoán ô " + hinhNguoiChoiChon + " ra ô " + soNgauNhien2 + ")");
                }
                else
                {
                    picClick.Image = Image.FromFile(path + "Wrong.png");
                    listBox1.Items.Add(soLanChoi + ". Thua (Đoán ô " + hinhNguoiChoiChon + " ra ô " + soNgauNhien2 + ")");

                    if (soNgauNhien2.ToString() == tenHinh1)
                    {
                        pictureBox1.Image = Image.FromFile(path + "poooh2.jpg");
                    }

                    if (soNgauNhien2.ToString() == tenHinh2)
                    {
                        pictureBox2.Image = Image.FromFile(path + "poooh2.jpg");
                    }

                    if (soNgauNhien2.ToString() == tenHinh3)
                    {
                        pictureBox3.Image = Image.FromFile(path + "poooh2.jpg");
                    }

                    if (soNgauNhien2.ToString() == tenHinh4)
                    {
                        pictureBox4.Image = Image.FromFile(path + "poooh2.jpg");
                    }
                }
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;

                timer1.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dangChoiGame == true)
            {
                StreamWriter streamWriter;

                if (File.Exists(pathLuu) == false)
                {
                    streamWriter = new StreamWriter(pathLuu);
                    
                    foreach (string item in listBox1.Items)
                    {
                        streamWriter.WriteLine(item);
                    }
                }
                else
                {
                    streamWriter = File.AppendText(pathLuu);
                   
                    foreach (string item in listBox1.Items)
                    {
                        streamWriter.WriteLine(item);
                    }
                }

                streamWriter.Close();
            }
        }

        private void KhoiTaoAnh()
        {
            pictureBox1.Image = Image.FromFile(path + "poooh1.jpg");
            pictureBox2.Image = Image.FromFile(path + "poooh1.jpg");
            pictureBox3.Image = Image.FromFile(path + "poooh1.jpg");
            pictureBox4.Image = Image.FromFile(path + "poooh1.jpg");
        }
        private void ResetGame()
        {
            KhoiTaoAnh();
            listBox1.Items.Clear();
            soLanChoi = 0;
            dangChoiGame = false;
            this.BackColor = Color.White;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manageEmplyeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FQuanLyNhanVien fQLNV = new FQuanLyNhanVien();
            fQLNV.Show();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoAnh();
            diChuyen = 3;
            dangChoiGame = false;
            soLanChoi = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += diChuyen;
            if (pictureBox1.Left < panel1.Left || pictureBox1.Right >panel1.Width)
            {
                diChuyen = -diChuyen;
            }

            pictureBox2.Left -= diChuyen;
            if (pictureBox2.Left < panel1.Left || pictureBox2.Right > panel1.Width)
            {
                diChuyen = -diChuyen;
            }

            pictureBox3.Top -= diChuyen;
            if (pictureBox3.Bottom < panel1.Top || pictureBox3.Bottom < panel1.Height)
            {
                diChuyen = -diChuyen;
            }

            pictureBox4.Top += diChuyen;
            if (pictureBox4.Bottom < panel1.Top || pictureBox4.Bottom < panel1.Height)
            {
                diChuyen = -diChuyen;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            dangChoiGame = true;
            timer1.Enabled = true;
            do
            {
                Random random = new Random();
                soNgauNhien1 = random.Next(1, 5);
                soNgauNhien2 = random.Next(1, 5);

            } while (soNgauNhien1 == soNgauNhien2);
            KhoiTaoAnh();
            pictureBox1.Enabled = dangChoiGame;
            pictureBox2.Enabled = dangChoiGame;
            pictureBox3.Enabled = dangChoiGame;
            pictureBox4.Enabled = dangChoiGame;


            //MessageBox.Show(pictureBox1.Name.Substring(10, 1));
            tenHinh1 = pictureBox1.Name.Substring(10, 1);
            tenHinh2 = pictureBox2.Name.Substring(10, 1);
            tenHinh3 = pictureBox3.Name.Substring(10, 1);
            tenHinh4 = pictureBox4.Name.Substring(10, 1);

            if (soNgauNhien1.ToString() == tenHinh1)
            {
                pictureBox1.Image = Image.FromFile(path + "poooh2.jpg");
            }

            if (soNgauNhien1.ToString() == tenHinh2)
            {
                pictureBox2.Image = Image.FromFile(path + "poooh2.jpg");
            }

            if (soNgauNhien1.ToString() == tenHinh3)
            {
                pictureBox3.Image = Image.FromFile(path + "poooh2.jpg");
            }

            if (soNgauNhien1.ToString() == tenHinh4)
            {
                pictureBox4.Image = Image.FromFile(path + "poooh2.jpg");
            }
        }
    }
}
