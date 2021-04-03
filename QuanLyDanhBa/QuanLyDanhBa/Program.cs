using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;


namespace QuanLyDanhBa
{
    class Program
    {
        enum Menu
        {
            Thoat = 0, 
            TimSoLan,
            ThueBaoCoNhieuSDTNhat,
            SapXepTangHoTen,
            SapXepGiamHoTen,
            SapXepTangNgaySinh,
            SapXepGiamNgaySinh,
            TPhoXuatHienNhieuNhat
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DanhBa db = new DanhBa();
            db.NhapTuFile();
            Console.WriteLine(db);
           
            while (true)
            {
                
                Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ He thong Menu ~ ~ ~ ~ ~ ~ ~ ~");
                Console.WriteLine("Quan ly danh ba.");
                Console.WriteLine("{0}. Thoat chuong trinh.", (int)Menu.Thoat);
                Console.WriteLine("{0}. Tim thue bao co so lan xuat hien nhieu nhat", (int)Menu.TimSoLan);
                Console.WriteLine("{0}. Tim thue bao co nhieu so nhat", (int)Menu.ThueBaoCoNhieuSDTNhat);
                Console.WriteLine("{0}. Sap xep thue bao theo chieu tang cua ten.", (int)Menu.SapXepTangHoTen);
                Console.WriteLine("{0}. Sap xep thue bao theo chieu giam cua ten.", (int)Menu.SapXepGiamHoTen);
                Console.WriteLine("{0}. Sap xep thue bao theo chieu tang cua ngay sinh.", (int)Menu.SapXepTangNgaySinh);
                Console.WriteLine("{0}. Sap xep thue bao theo chieu giam cua ngay sinh.", (int)Menu.SapXepGiamNgaySinh);
                Console.WriteLine("{0}. Tim thanh pho xuat hien nhieu nhat", (int)Menu.TPhoXuatHienNhieuNhat);
        
                Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
                Console.Write("Nhap thu tu can tim: ");
                
                Menu menu = (Menu)int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (menu)
                {
                    case Menu.Thoat:
                        Console.WriteLine("Cam on ban vi da su dung");
                        return;
                   /* case Menu.NhapTuFile:
                        Console.Clear();
                        db.NhapTuFile();
                        Console.WriteLine(db);
                        Console.ReadKey();
                        break;*/

                    case Menu.TimSoLan:                                              
                        int solan = db.TimSoLanXuatHienNhieuNhat();
                        Console.Write("\tSo thue bao xuat hien nhieu nhat: "+ solan);                        
                        break;

                    case Menu.ThueBaoCoNhieuSDTNhat:
                        Console.WriteLine("\tThue bao co nhieu sdt nhat");
                        db.TimThueBaoCoNhieuSDT();
                        Console.WriteLine(db);
                        break;

                    case Menu.SapXepTangHoTen:                        
                        Console.WriteLine("\tSap xep ho theo chieu tang");
                        db.SapXepTheoChieuTangCuaTen();
                        Console.WriteLine(db);
                        break;

                    case Menu.SapXepGiamHoTen:                       
                        Console.WriteLine("\tSap xep ho theo chieu giam");
                        db.SapXepTheoChieuGiamCuaTen();
                        Console.WriteLine(db);
                        break;

                    case Menu.SapXepTangNgaySinh:                       
                        Console.WriteLine("\tSap xep ngay sinh theo chieu tang");
                        db.SapXepTangNgaySinh();
                        Console.WriteLine(db);
                        break;

                    case Menu.SapXepGiamNgaySinh:                       
                        Console.WriteLine("\tSap xep ngay sinh theo chieu giam");
                        db.SapXepGiamNgaySinh();
                        Console.WriteLine(db);
                        break;

                    case Menu.TPhoXuatHienNhieuNhat:                        
                        Console.Write("Nhap ten thanh pho : ");
                        string tpho = Console.ReadLine();
                        
                        Console.Write("\tThanh pho co nhieu thue bao nhat la: " +);                       
                        Console.WriteLine(db);

                        break;

                   /* case Menu.Xuat:
                        Console.Clear();
                        db.Xuat();
                        Console.ReadKey();
                        break;
                   */
                }
                Console.WriteLine("\n\tNhap mot phim bat ky de tiep tuc.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
