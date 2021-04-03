using System;
using System.Collections.Generic;
using System.Text;

namespace ThueBao
{
    class ThueBao
    {
        public string sdt;
        public string tenkh;
        public string diachi;
        

        public void Nhap()
        {
            Console.Write("Nhap so dien thoai: ");
            sdt = Console.ReadLine();

            Console.Write("Nhap ho ten khach hang: ");
            tenkh = Console.ReadLine();

            Console.Write("Nhap dia chi: ");
            diachi = Console.ReadLine();

        }

        public void Xuat()
        {
            Console.WriteLine("So dien thoai la: " +sdt);
            Console.WriteLine("Ho ten khach hang la: " + tenkh);
            Console.WriteLine("Dia chi la: " + diachi);
         
            Console.ReadKey();
        }
    }
}
