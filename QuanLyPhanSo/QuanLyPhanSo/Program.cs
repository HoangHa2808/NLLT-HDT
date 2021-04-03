using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    class Program
    {
        #region PhanSo
        /*static void Main(string[] args)
        {
            //PhanSo a = new PhanSo();
            ////a.Xuat();
            //a.Nhap();
            //a.Xuat();
            //PhanSo b = new PhanSo();
            ////b.Xuat();
            //b = a;
            //b.Xuat();
            PhanSo a = new PhanSo(1, 2);
            Console.Write("Phan so thu nhat la : ");
            a.Xuat();
            //a.Nhap();
            //a.Xuat();
            PhanSo b = new PhanSo(3, 4);
            Console.Write("Phan so thu hai la: ");
            b.Xuat();

            PhanSo c = a.Cong(a, b);
            Console.Write("Ket qua cua phep cong la: ");
            c.Xuat();

            PhanSo d = a.Tru(a, b);
            Console.Write("Ket qua cua phep tru la: ");
            d.Xuat();

            PhanSo e = a.Nhan(a, b);
            Console.Write("Ket qua cua phep nhan la : ");
            e.Xuat();

            PhanSo f = a.Chia(a, b);
            Console.Write("Ket qua cua phep chia la : ");
            f.Xuat();

            Console.ReadKey();
        }*/
        #endregion

        enum Menu
        {
            Thoat = 10,
            Nhap = 1,
            Xuat = 2,
            TimMax,
            TimTheoMau
        }

        static void Main(string[] args)
        {
            MangPhanSo ds = new MangPhanSo();
            while (true)
            {
                Console.WriteLine("Nhap {0} de thoat", (int)Menu.Thoat);
                Console.WriteLine("Nhap {0} de nhap tu file.", (int)Menu.Nhap);
                Menu menu = (Menu)int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case Menu.Thoat: return;
                    /*case Menu.Nhap:
                        ds.NhapNgauNhien();
                        break;*/
                    case Menu.Nhap:
                        ds.NhapTuFile();
                        break;

                    case Menu.Xuat:
                        ds.Xuat();
                        break;
                }
            }
            
           
            Console.ReadKey();

        }

    }
}
