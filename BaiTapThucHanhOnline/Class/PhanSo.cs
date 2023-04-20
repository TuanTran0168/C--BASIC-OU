using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapThucHanhOnline.Class
{
    internal class PhanSo
    {
        private int tuSo, mauSo;

        public int TuSo
        {
            get { return tuSo; }
            set { tuSo = value; }
        }

        public int MauSo { 
            get { return mauSo; }
            set { mauSo = value; }
        }

        public PhanSo()
        {
            this.tuSo = 0;
            this.mauSo = 1;
        }

        public PhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            if (mauSo == 0)
                this.mauSo = 1;
            else
                this.mauSo = mauSo;
        }

        private void RutGon()
        {
            int UCLN = ToanHoc.UCLN(this.tuSo, this.mauSo);
            if (UCLN > 0)
            {
                tuSo = tuSo / UCLN;
                mauSo = mauSo / UCLN;
            }
        }

        public PhanSo Cong(PhanSo p)
        {
            PhanSo ketQua = new PhanSo();
            ketQua.tuSo = this.tuSo * p.mauSo + p.tuSo * this.mauSo;
            ketQua.mauSo = this.mauSo * p.mauSo;
    
            ketQua.RutGon();
            return ketQua;
        }

        public PhanSo Tru(PhanSo p)
        {
            PhanSo ketQua = new PhanSo();
            ketQua.tuSo = this.tuSo * p.mauSo - p.tuSo * this.mauSo;
            ketQua.mauSo = this.mauSo * p.mauSo;

            ketQua.RutGon();
            return ketQua;
        }

        public PhanSo Nhan(PhanSo p)
        {
            PhanSo ketQua = new PhanSo();
            ketQua.tuSo = this.tuSo * p.tuSo;
            ketQua.mauSo = this.mauSo * p.mauSo;

            ketQua.RutGon();
            return ketQua;
        }

        public PhanSo Chia(PhanSo p)
        {
            PhanSo ketQua = new PhanSo();
            ketQua.tuSo = this.tuSo * p.mauSo;
            ketQua.mauSo = this.mauSo * p.tuSo;

            ketQua.RutGon();
            return ketQua;
        }
    }
}
