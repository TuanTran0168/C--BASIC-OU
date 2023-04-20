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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cácBàiTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tìmSốLớnNhấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimSoLonNhat timSoLonNhat = new TimSoLonNhat();
            timSoLonNhat.MdiParent = this;
            timSoLonNhat.Show();
        }

        private void máyTínhMiniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MayTinhMini mayTinhMini = new MayTinhMini();
            mayTinhMini.MdiParent = this;
            mayTinhMini.Show();
        }

        private void randomNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomNumbers randomNumbers = new RandomNumbers();
            randomNumbers.MdiParent = this;
            randomNumbers.Show();
        }

        private void giúpBéHọcToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpKidLearnMath helpKidLearnMath = new HelpKidLearnMath();
            helpKidLearnMath.MdiParent = this;
            helpKidLearnMath.Show();
        }

        private void formTínhTiềnNhaSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DentalPaymentForm dentalPaymentForm = new DentalPaymentForm();
            dentalPaymentForm.MdiParent = this;
            dentalPaymentForm.Show();
        }

        private void securityPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecurityPanel securityPanel = new SecurityPanel();
            securityPanel.MdiParent = this;
            securityPanel.Show();
        }

        private void phânSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhepTinhPhanSo phepTinhPhanSo = new PhepTinhPhanSo();
            phepTinhPhanSo.MdiParent = this;
            phepTinhPhanSo.Show();
        }

        private void gameTângBóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameTangBong gameTangBong = new GameTangBong();
            gameTangBong.MdiParent = this;
            gameTangBong.Show();
        }

        private void gameXúcSắcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XucSac xucSac = new XucSac();
            xucSac.MdiParent = this;
            xucSac.Show();
        }

        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachSinhVien danhSachSinhVien = new DanhSachSinhVien();
            danhSachSinhVien.MdiParent = this;
            danhSachSinhVien.Show();
        }

        private void diChuyểnẢnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiChuyenAnh diChuyenAnh = new DiChuyenAnh();
            diChuyenAnh.MdiParent = this;
            diChuyenAnh.Show();
        }

        private void đặtĐồĂnNhanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastFoodOrder fastFoodOrder = new FastFoodOrder();
            fastFoodOrder.MdiParent = this;
            fastFoodOrder.Show();
        }

        private void câu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MayTinh mayTinh = new MayTinh();
            mayTinh.MdiParent = this;
            mayTinh.Show();
        }

        private void câu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MayTinhMini mayTinhMini = new MayTinhMini();
            mayTinhMini.MdiParent = this;
            mayTinhMini.Show();
        }

        private void câu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomNumbers randomNumbers = new RandomNumbers();
            randomNumbers.MdiParent = this;
            randomNumbers.Show();
        }

        private void câu6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpKidLearnMath helpKidLearnMath = new HelpKidLearnMath();
            helpKidLearnMath.MdiParent = this;
            helpKidLearnMath.Show();
        }

        private void câu7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DentalPaymentForm dentalPaymentForm = new DentalPaymentForm();
            dentalPaymentForm.MdiParent = this;
            dentalPaymentForm.Show();
        }

        private void câu8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecurityPanel securityPanel = new SecurityPanel();
            securityPanel.MdiParent = this;
            securityPanel.Show();
        }

        private void câu9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecurityPanel securityPanel = new SecurityPanel();
            securityPanel.MdiParent = this;
            securityPanel.Show();
        }

        private void câu12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameTangBong gameTangBong = new GameTangBong();
            gameTangBong.MdiParent = this;
            gameTangBong.Show();
        }

        private void câu13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XucSac xucSac = new XucSac();
            xucSac.MdiParent = this;
            xucSac.Show();
        }

        private void câu18ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiChuyenAnh diChuyenAnh = new DiChuyenAnh();
            diChuyenAnh.MdiParent = this;
            diChuyenAnh.Show();
        }

        private void câu20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastFoodOrder fastFoodOrder = new FastFoodOrder();
            fastFoodOrder.MdiParent = this;
            fastFoodOrder.Show();
        }

        private void câu23ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.MdiParent = this;
            mainForm.Show();
        }

        private void câu25ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
