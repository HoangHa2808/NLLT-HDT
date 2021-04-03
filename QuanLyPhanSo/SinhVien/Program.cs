using System;
using System.Collections.Generic;
using System.Text;

namespace SinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien a = new SinhVien();
           
            a.Nhap();
            Console.WriteLine("\tThong tin cua sinh vien la");
            a.Xuat();
            Console.ReadKey();
        }
    }
}
