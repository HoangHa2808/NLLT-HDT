using System;
using System.Collections.Generic;
using System.Text;

namespace HocPhan
{
    class HocPhan
    {
        public string mahp;
        public string tenhp;
        public byte tchi;
        public string hphan;
    
        public void Nhap()
        {
            Console.Write("Nhap ma hoc phan: ");
            mahp = Console.ReadLine();

            Console.Write("Nhap ten hoc phan: ");
            tenhp = Console.ReadLine();

            Console.Write("Nhap tin chi: ");
            int tchi = int.Parse(Console.ReadLine());

            Console.Write("Hoc phan la (bat buoc hay tu chon): ");
            hphan = Console.ReadLine();

        }

public void Xuat()
        {
            Console.WriteLine("Ma hoc phan la: " +mahp);
            Console.WriteLine("Ten hoc phan la: " + tenhp);
            Console.WriteLine("So tin chi la: " + tchi);
            Console.WriteLine("Hoc phan : " + hphan);
            Console.ReadKey();
        }
    }

}
