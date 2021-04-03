using System;
using System.Collections.Generic;
using System.Text;

namespace SinhVien
{
    class SinhVien
    {
        public int mssv;
        public int ngay;
        public int thang;
        public int nam;
        public string hoTen;
        public string queQuan;

        public void Nhap()
        {
            Console.Write("Nhap ma so sinh vien : ");
            mssv = int.Parse(Console.ReadLine());

            Console.Write("Nhap ngay sinh : ");
            ngay = int.Parse(Console.ReadLine());

            Console.Write("Nhap thang sinh : ");
            thang = int.Parse(Console.ReadLine());

            Console.Write("Nhap nam sinh : ");
            nam = int.Parse(Console.ReadLine());

            Console.Write("Nhap ho ten : ");
           hoTen = Console.ReadLine();

            Console.Write("Nhap que quan : ");
            queQuan = Console.ReadLine();

        }
        public void Xuat()
        {
            Console.WriteLine("\nMSSV la : " + mssv);
            Console.WriteLine("Ngay sinh la: "+ ngay);
            Console.WriteLine("Thang sinh la: "+ thang);
            Console.WriteLine("Nam sinh la: "+ nam);
            Console.WriteLine("Ho ten la: " + hoTen);
            Console.WriteLine("Que quan la: " + queQuan);
        }

    }
}
