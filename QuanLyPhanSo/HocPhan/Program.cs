using System;

namespace HocPhan
{
    class Program
    {
        static void Main(string[] args)
        {
            
            HocPhan a = new HocPhan();
            a.Nhap();
            Console.WriteLine("\tThong tin cua hoc phan la");
            a.Xuat();
           
            Console.ReadKey();
        }
    }
}
