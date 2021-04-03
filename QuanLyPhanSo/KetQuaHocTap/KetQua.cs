using System;
using System.Collections.Generic;
using System.Text;

namespace KetQuaHocTap
{
    class KetQua
    {
        public string mahp;
        public string tenhp;
        public byte tchi;
        public float diem;

        public void Nhap()
        {
            Console.Write("Nhap ma hoc phan: ");
            mahp = Console.ReadLine();

            Console.Write("Nhap ten hoc phan: ");
            tenhp = Console.ReadLine();

            Console.Write("Nhap tin chi: ");
            tchi = byte.Parse(Console.ReadLine());

            Console.Write("Nhap diem la : ");
            diem = float.Parse(Console.ReadLine());

        }

        public void Xuat()
        {
            Console.WriteLine("Ma hoc phan la: " + mahp);
            Console.WriteLine("Ten hoc phan la: " + tenhp);
            Console.WriteLine("So tin chi la: " + tchi);
            Console.WriteLine("Diem la : " + diem);
            Console.ReadKey();
        }
    }
}
