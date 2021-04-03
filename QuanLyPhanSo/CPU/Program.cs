using System;

namespace CPU
{
    class Program
    {
        static void Main(string[] args)
        {
            CPU a = new CPU();
            a.Nhap();
            Console.WriteLine("\tThong tin cua san phan la");
            a.Xuat();
            Console.ReadKey();
        }
    }
}
