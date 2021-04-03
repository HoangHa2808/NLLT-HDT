using System;
using System.Collections.Generic;
using System.Text;

namespace CPU
{
    class CPU
    {
        public string tensp;
        public string hang;
        public double gtien;
        public int namsx;
        public float tdo;

        public void Nhap()
        {
            Console.Write("Nhap ten san pham: ");
            tensp= Console.ReadLine();

            Console.Write("Nhap hang: ");
            hang = Console.ReadLine();

            Console.Write("Nhap gia san pham: ");
            gtien= double.Parse(Console.ReadLine());

            Console.Write("Nhap nawm san xuat: ");
            namsx = int.Parse(Console.ReadLine());

            Console.Write("Nhap toc do: ");
            tdo = float.Parse(Console.ReadLine());

        }

        public void Xuat()
        {
            Console.WriteLine("Ten san pham la: " + tensp);
            Console.WriteLine("Hang san pham la: " + hang);
            Console.WriteLine("Gia tien la: " + gtien);
            Console.WriteLine("Nam san xuat la : " + namsx);
            Console.WriteLine("Toc do cua CPU la: " + tdo);
            Console.ReadKey();
        }
    }
}
