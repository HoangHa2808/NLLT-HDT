using System;

namespace ThueBao
{
    class Program
    {
        static void Main(string[] args)
        {
            ThueBao a = new ThueBao();
            a.Nhap();
            Console.WriteLine("\tThong tin khach hang la");
            a.Xuat();
            Console.ReadKey();
        }
    }
}
