using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhanSo
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

        public PhanSo Cong(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tu = a.tu * b.mau + a.mau * b.tu;
            kq.mau = a.mau * b.mau;
            return kq;
        }

        public void Nhap()
        {
            Console.Write("Nhap tu : ");
            tu = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau : ");
            mau = int.Parse(Console.ReadLine());
      }
        public PhanSo Tru(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tu = a.tu * b.mau - a.mau * b.tu;
            kq.mau = a.mau * b.mau;
            return kq;

        }

        public PhanSo Nhan(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tu = a.tu * b.tu;
            kq.mau = a.mau * b.mau;
            return kq;
        }

        public PhanSo Chia(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tu = a.tu * b.mau;
            kq.mau = a.mau * b.tu;
            return kq;

        }

        public void Xuat()
        {
            Console.WriteLine("{0}/{1}", tu, mau);
        }
    }
}

