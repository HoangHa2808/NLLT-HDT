using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Bai4._2
{
    class Program
    {
        enum Menu
        {
            Thoat = 0,
            Nhap = 1,
            Xuat = 2,
            TimSoAm,
            TimSoDuong,
            TimMax,
            TimMinAm,
            TimMaxDuong,
            TimMinDuong
        }

        static void Main(string[] args)
        {
            MangPhanSo ds = new MangPhanSo();
            while (true)
            {
                Console.WriteLine("\nNhap {0} de thoat", (int)Menu.Thoat);
                Console.WriteLine("Nhap {0} de nhap tu file.", (int)Menu.Nhap);
                Console.WriteLine("Nhap {0} de xuat file hien hanh.", (int)Menu.Xuat);
                Console.WriteLine("Nhap {0} de dem so phan so am trong mang.", (int)Menu.TimSoAm);
                Console.WriteLine("Nhap {0} de dem so phan so duong trong mang.", (int)Menu.TimSoDuong);
                Console.WriteLine("Nhap {0} de tim phan so am lon nhat", (int)Menu.TimMax);
                Menu menu = (Menu)int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case Menu.Thoat: return;
                    /*case Menu.Nhap:
                        ds.NhapNgauNhien();
                        break;*/
                    case Menu.Nhap:
                        Console.Clear();
                        ds.NhapTuFile();
                        break;


                    case Menu.TimSoAm:
                        Console.Clear();
                        Console.Write("Mang hien hanh la: "+ ds.TimSoAm());
                       break;

                    case Menu.TimSoDuong:
                        Console.Clear();
                        Console.Write("Mang hien hanh la : "+ ds.TimSoDuong());                   
                      break;

                    case Menu.TimMax:
                        Console.Clear();
                        Console.Write("Mang hien hanh la: " + ds.TimMax());
                        break;

                    case Menu.Xuat:
                        Console.Clear();
                        ds.Xuat();
                        break;
                } 
            }
        }
    }
}
