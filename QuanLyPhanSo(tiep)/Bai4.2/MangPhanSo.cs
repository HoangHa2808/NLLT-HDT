using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Bai4._2
{
    class MangPhanSo
    {
        public PhanSo[] a = new PhanSo[100];
        public int length = 0;

        public void Them(PhanSo x)
        {
            a[length++] = x;

        }

        public void NhapTuFile()
        {
            string path = @"data.txt";
            StreamReader sr = new StreamReader(path);
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                string[] tam = s.Split('/');
                int tu = int.Parse(tam[0]);
                int mau = int.Parse(tam[1]);
                Them(new PhanSo(tu, mau));
            }
        }

        public void NhapNgauNhien()
        {
            Console.Write("Nhap vao phan tu cua mang: ");
            length = int.Parse(Console.ReadLine());
            Random r = new Random();
            for (int i = 0; i < length; i++)
            {
                a[i] = new PhanSo(r.Next(10), r.Next(10));
            }
        }

        public int TimSoAm()
        {
            PhanSo SoAm = new PhanSo();
            int dem = 0;
            for (int i = 0; i < length; i++)
            {
                if ((float)a[i].tu / a[i].mau < 0)
                    dem++;
            }
            return dem;
        }

        public int TimSoDuong()
        {
            PhanSo SoDuong = new PhanSo();
            int dem = 0;
            for (int i = 0; i < length; i++)
            {
                if ((float)a[i].tu / a[i].mau > 0)
                    dem++;
            }
            return dem;
        }

        //public int TimMaxAm()
        //{
        //    PhanSo MaxAm = new PhanSo();
        //    for (int i = 0; i < length; i++)
        //    {

        //    }
        //}

        public PhanSo TimMax()
        {
            PhanSo max = new PhanSo(int.MinValue, 1);
            for (int i = 0; i < length - 1; i++)
            {
                float x = a[i].tu / a[i].mau;
                float y = max.tu / max.mau;
                if (x > y) max = a[i];
            }
            return max;
        }
        public void Xuat()
        {
            Console.WriteLine("Cac phan tu la: ");
            for (int i = 0; i < length; i++)

                a[i].Xuat();

        }
    }
}
