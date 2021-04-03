using System;
using System.Collections.Generic;
using System.Text;

namespace Bai4._2
{
    class PhanSo
    {
        public int tu;
        public int mau;

        public PhanSo()
        {
            mau = 1;
        }


        public PhanSo(int t, int m)
        {
            tu = t;
            mau = m;
        }

        public void Xuat()
        {
            Console.Write("{0}/{1}\t", tu, mau);
                       
        }
        
    }
}
