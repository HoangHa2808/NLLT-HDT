using System;

namespace KetQuaHocTap
{
    class Program
    {
        static void Main(string[] args)
        {
            KetQua a = new KetQua();
            a.Nhap();
            Console.WriteLine("\tKet qua hoc phan la");
            a.Xuat();

            Console.ReadKey();
        }
    }
}
