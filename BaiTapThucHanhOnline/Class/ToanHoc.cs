using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapThucHanhOnline.Class
{
    internal class ToanHoc
    {
        public static int UCLN(int tuSo, int mauSo)
        {
            if (tuSo == 0 || mauSo == 0)
                return 1;

            tuSo = Math.Abs(tuSo);
            mauSo = Math.Abs(mauSo);

            while (tuSo != mauSo)
            {
                if (tuSo > mauSo)
                    tuSo -= mauSo;
                else if (mauSo > tuSo)
                    mauSo -= tuSo;
            }
            return tuSo;
        }

        public static int TimUSCLN(int tuSo, int mauSo)
        {
            int tu, mau;
            tu = Math.Abs(tuSo);
            mau = Math.Abs(mauSo);
            if (mau == 0)
            {
                return tu;
            }
            return TimUSCLN(mau, tu % mau);

        }
    }
}
