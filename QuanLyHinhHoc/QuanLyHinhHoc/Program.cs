using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyHinhHoc
{
    class Program
    {
        enum Menu
        {
            Thoat, Nhap, Xuat,

            TimHinhVuongCoSVBangX, TimMaxMinDTCVHVuong, SapXepHVuong,
            CanhHVMaxMin, TongDTCVHVuong, DemSLHVuong,

            TimHinhTronCoSVBangX, TimMaxMinDTCVHTron, SapXepHTron,
            CanhHTMaxMin, TongDTCVHTron, DemSLHTron,

            TimHinhCNCoSVBangX, TimMaxMinDTCVHCN, SapXepHCN,
            CanhHCNMaxMin, TongDTCVHCN, DemSLHCN,

            HinhCoDTMaxMin,  HinhCoCVMaxMin,
            
            DemSoLuong, SapXepCacHinh

        }
        static void Main(string[] args)
        {
            DanhBaHinhHoc dbhh = new DanhBaHinhHoc();
            Console.WriteLine(dbhh);
            float x;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("========= He thong Menu =========");
                Console.WriteLine("{0}. Thoat khoi chuong trinh.", (int)Menu.Thoat);
                Console.WriteLine("{0}. Nhap du lieu tu file.", (int)Menu.Nhap);
                Console.WriteLine("{0}. Xuat danh sach.", (int)Menu.Xuat);
                Console.WriteLine("=====> Quan ly hinh hoc <=====");
                Console.WriteLine("\t<== Hinh Vuong ==>");
                Console.WriteLine("{0}. Tim tat ca ca hinh co S, V la x.", (int)Menu.TimHinhVuongCoSVBangX);
                Console.WriteLine("{0}. Tim hinh co dien tich, chu vi nho nhat.", (int)Menu.TimMaxMinDTCVHVuong);
                Console.WriteLine("{0}. Sap xep tang dan, giam dan dien tich.", (int)Menu.SapXepHVuong);
                Console.WriteLine("{0}. Tim canh nho nhat, lon nhat.", (int)Menu.CanhHVMaxMin);
                Console.WriteLine("{0}. Tinh tong dien tich, chu vi.",(int)Menu.TongDTCVHVuong);
                Console.WriteLine("{0}. Dem so luong hinh.", (int)Menu.DemSLHVuong);
                Console.WriteLine("\t<== Hinh Tron ==>");
                Console.WriteLine("{0}. Tim hinh co dien tich, chu vi nho nhat.", (int)Menu.TimMaxMinDTCVHTron);
                Console.WriteLine("{0}. Sap xep tang dan, giam dan dien tich hinh tron.", (int)Menu.SapXepHTron);
                Console.WriteLine("{0}. Tim canh nho nhat, lon nhat.", (int)Menu.CanhHTMaxMin);
                Console.WriteLine("{0}. Tinh tong dien tich, chu vi.", (int)Menu.TongDTCVHTron);
                Console.WriteLine("{0}. Dem so luong hinh.", (int)Menu.DemSLHTron);
                Console.WriteLine("\t<== Hinh Chu Nhat =>");
                Console.WriteLine("{0}. Tim hinh co dien tich, chu vi nho nhat.", (int)Menu.TimMaxMinDTCVHCN);
                Console.WriteLine("{0}. Sap xep tang dan, giam dan dien tich.", (int)Menu.SapXepHCN);
                Console.WriteLine("{0}. Tim canh lon nhat, nho nhat.", (int)Menu.CanhHCNMaxMin);
                Console.WriteLine("{0}. Tinh tong dien tich, chu vi.", (int)Menu.TongDTCVHCN);
                Console.WriteLine("{0}. Dem so luong hinh.", (int)Menu.DemSLHCN);
                Console.WriteLine("   <== Chuc nang chung cua cac hinh ==>");
                Console.WriteLine("{0}. Tim tat ca hinh co dien tich lon nhat, nho nhat.", (int)Menu.HinhCoDTMaxMin);
                Console.WriteLine("{0}. Tim tat ca hinh co chu vi lon nhat, nho nhat.", (int)Menu.HinhCoCVMaxMin);
                Console.WriteLine("{0}. Dem so luong hinh hoc.", (int)Menu.DemSoLuong);
                Console.WriteLine("{0}. Compare", (int)Menu.Compare);
                Console.WriteLine("=================================");
                Console.WriteLine();
                Console.Write("Nhap so thu tu: ");
                Menu menu = (Menu)int.Parse(Console.ReadLine());

                switch (menu)
                {
                    #region ChucNangNhapXuatCoBan
                    case Menu.Thoat:
                        Console.Clear();
                        Console.WriteLine("Cam on vi da su dung.");
                        return;

                    case Menu.Nhap:
                        Console.Clear();
                        dbhh.NhapTuFile();
                        break;

                    case Menu.Xuat:
                        Console.Clear();
                        Console.WriteLine(" => Xuat danh sach hinh hoc." + dbhh.ToString());
                        break;
                    #endregion

                    #region case 3: Tim
                    //case Menu.TimHinhVuongCoSVBangX:
                    //    Console.Clear();
                    //    Console.WriteLine("Nhap dien tich hinh vuong:x = ");
                    //    x = float.Parse(Console.ReadLine());
                    //    Console.WriteLine($"Hinh vuong co dien tich = {0}", x);
                    //    Console.WriteLine(dbhh.TimHVCoDTBangx(x));
                    //    Console.ReadKey();

                    //    Console.WriteLine("Nhap chu vi hinh vuong:x = ");
                    //    x = float.Parse(Console.ReadLine());
                    //    Console.WriteLine($"Hinh vuong co chu vi = {0}", x);
                    //    Console.WriteLine(dbhh.TimHVCoCVBangx(x));
                    //    break;
                    #endregion

                    #region TimMaxMinDT-CV
                    case Menu.TimMaxMinDTCVHVuong:
                        Console.Clear();
                        Console.Write("Dien tich nho nhat la: ");
                        dbhh.TinhHVuongCoDTMin().Xuat();
                        Console.WriteLine();

                        Console.Write("Chu vi nho nhat la: ");
                        dbhh.TinhHVuongCoCVMin().Xuat();
                        break;

                    case Menu.TimMaxMinDTCVHTron:
                        Console.Clear();
                        Console.Write("Dien tich nho nhat la: ");
                        dbhh.TinhHTronCoDTMin().Xuat();
                        Console.WriteLine();

                        Console.Write("Chu vi nho nhat la: ");
                        dbhh.TinhHTronCoCVMin().Xuat();
                        break;

                    case Menu.TimMaxMinDTCVHCN:
                        Console.Clear();
                        Console.Write("Dien tich nho nhat la: ");
                        dbhh.TinhHCNCoDTMin().Xuat();
                        Console.WriteLine();

                        Console.Write("Chu vi nho nhat la: ");
                        dbhh.TinhHCNCoCVMin().Xuat();
                        break;
                    #endregion

                    #region SapXep
                    case Menu.SapXepHVuong:
                        Console.Clear();
                      Console.WriteLine("\tSap xep tang, giam theo dien tich, chu vi: ");
                        Console.WriteLine("=> Tang dan");
                        dbhh.sortByT<HinhVuong>(false).Xuat();
                        Console.WriteLine();

                        Console.WriteLine("=> Giam dan");
                        dbhh.sortByG<HinhVuong>(false).Xuat();
                        break;

                    case Menu.SapXepHTron:
                        Console.Clear();
                        Console.WriteLine("\tSap xep tang, giam theo dien tich, chu vi: ");
                        Console.WriteLine("=> Tang dan");
                        dbhh.sortByT<HinhTron>(true).Xuat();
                        Console.WriteLine();

                        Console.WriteLine("=> Giam dan");
                        dbhh.sortByG<HinhTron>(true).Xuat();
                        break;

                    case Menu.SapXepHCN:
                        Console.Clear();
                        Console.WriteLine("\tSap xep tang, giam theo dien tich, chu vi: ");
                        Console.WriteLine("=> Tang dan");
                        dbhh.sortByT<HinhChuNhat>(true).Xuat();
                        Console.WriteLine();

                        Console.WriteLine("=> Giam dan");
                        dbhh.sortByG<HinhChuNhat>(true).Xuat();
                        break;

                    //case Menu.SapXepHVuong:
                    //    Console.Clear();
                    //    Console.WriteLine("\tSap xep tang, giam theo dien tich, chu vi: ");
                    //    Console.WriteLine("=> Tang dan");
                    //    List<HinhHoc> res = dbhh.sortByT<HinhVuong>(false);
                    //    foreach (HinhVuong re in res)
                    //    {
                    //        Console.WriteLine(re.ToString());
                    //    }
                    //    Console.WriteLine();

                    //    Console.WriteLine("=> Giam dan");
                    //    List<HinhHoc> res1 = dbhh.sortByG<HinhVuong>(false);
                    //    foreach (HinhVuong re in res1)
                    //    {
                    //        Console.WriteLine(re.ToString());
                    //    }
                    //    break;

                    //case Menu.SapXepHTron:
                    //    Console.Clear();
                    //    Console.WriteLine("\tSap xep tang, giam theo dien tich, chu vi: ");
                    //    Console.WriteLine("=> Tang dan");
                    //    List<HinhHoc> ht = dbhh.sortByT<HinhTron>(false);
                    //    foreach (HinhTron re in ht)
                    //    {
                    //        Console.WriteLine(re.ToString());
                    //    }
                    //    Console.WriteLine();

                    //    Console.WriteLine("=> Giam dan");
                    //    List<HinhHoc> ht1 = dbhh.sortByG<HinhTron>(false);
                    //    foreach (HinhTron re in ht1)
                    //    {
                    //        Console.WriteLine(re.ToString());
                    //    }
                    //    break;

                    //case Menu.SapXepHCN:
                    //    Console.Clear();
                    //    Console.Clear();
                    //    Console.WriteLine("\tSap xep tang, giam theo dien tich, chu vi: ");
                    //    Console.WriteLine("=> Tang dan");
                    //    List<HinhHoc> hcn = dbhh.sortByT<HinhChuNhat>(false);
                    //    foreach (HinhChuNhat re in hcn)
                    //    {
                    //        Console.WriteLine(re.ToString());
                    //    }
                    //    Console.WriteLine();

                    //    Console.WriteLine("=> Giam dan");
                    //    List<HinhHoc> hcn1 = dbhh.sortByG<HinhChuNhat>(false);
                    //    foreach (HinhChuNhat re in hcn1)
                    //    {
                    //        Console.WriteLine(re.ToString());
                    //    }
                    //    break;
                    #endregion

                    #region CanhMaxMin
                    case Menu.CanhHVMaxMin:
                        Console.Clear();
                        Console.WriteLine("Canh lon nhat la: ");                        
                        dbhh.TimCanhHVuongMax().Xuat();
                        Console.WriteLine();
                        
                        Console.WriteLine("Canh nho nhat la: ");                       
                        dbhh.TimCanhHVuongMin().Xuat();
                        break;

                    case Menu.CanhHTMaxMin:
                        Console.Clear();
                        Console.Write("Canh lon nhat la: ");
                        dbhh.TimCanhHTronMax().Xuat();
                        Console.WriteLine();

                        Console.Write("Canh nho nhat la: ");
                        dbhh.TimCanhHTronMin().Xuat();
                        break;

                    case Menu.CanhHCNMaxMin:
                        Console.Clear();
                        Console.Write("Canh lon nhat la: ");
                        dbhh.TimCanhHCNMax().Xuat();
                        Console.WriteLine();

                        Console.Write("Canh nho nhat la: ");
                        dbhh.TimCanhHCNMin().Xuat();
                        break;
                    #endregion

                    #region TongDT-CV
                    case Menu.TongDTCVHVuong:
                        Console.Clear();
                        Console.WriteLine("Tong dien tich la: " + dbhh.TinhTongDTHVuong());                      
                        Console.WriteLine();

                        Console.WriteLine("Tong chu vi la: "+ dbhh.TinhTongCVHVuong());                        
                        break;

                    case Menu.TongDTCVHTron:
                        Console.Clear();
                        Console.WriteLine("Tong dien tich la: " + dbhh.TinhTongDTHTron());
                        Console.WriteLine();

                        Console.WriteLine("Tong chu vi la: " + dbhh.TinhTongCVHTron());
                        break;

                    case Menu.TongDTCVHCN:
                        Console.Clear();
                        Console.WriteLine("Tong dien tich la: " + dbhh.TinhTongDTHCN());
                        Console.WriteLine();

                        Console.WriteLine("Tong chu vi la: " + dbhh.TinhTongCVHCN());
                        break;
                    #endregion

                    #region DemSLuong
                    case Menu.DemSLHVuong:
                        Console.Clear();
                        Console.Write("So luong hinh hoc la: ");
                        Console.WriteLine(dbhh.DemSoLuong());
                        //Dictionary<string, int> hv = dbhh.DemSLHVuong();
                        //foreach (var item in hv)
                        //{
                        //    Console.WriteLine(item.Key + ":" + item.Value);
                        //}
                        break;

                    case Menu.DemSLHTron:
                        Console.Clear();
                        Console.Write("So luong hinh hoc la: ");
                        Console.WriteLine(dbhh.DemSoLuong());
                        break;

                    case Menu.DemSLHCN:
                        Console.Write("So luong hinh hoc la: ");
                        Console.WriteLine(dbhh.DemSoLuong());
                        break;

                        #endregion
                                              
                    #region Chung
                    case Menu.HinhCoDTMaxMin:
                        Console.Clear();
                        Console.WriteLine("Hinh co dien tich lon nhat la: ");
                        Console.Write(dbhh.TinhHinhCoDTMax());
                        Console.WriteLine();

                        Console.WriteLine("Hinh co dien tich nho nhat la: ");
                        Console.WriteLine(dbhh.TinhHinhCoDTMin());
                        break;

                    case Menu.HinhCoCVMaxMin:
                        Console.Clear();
                        Console.WriteLine("Hinh co chu vi lon nhat la: ");
                        Console.WriteLine(dbhh.TinhHinhCoCVMax());
                        Console.WriteLine();

                        Console.WriteLine("Hinh co chu vi nho nhat la: ");
                        Console.WriteLine(dbhh.TinhHinhCoCVMin());
                        break;

                    case Menu.SapXepCacHinh:
                        Console.Clear();
                        Console.WriteLine("\tSap xep tang, giam theo dien tich, chu vi: ");
                        Console.WriteLine("=> Tang dan");
                        dbhh.sortByT<HinhHoc>(true).Xuat();
                        Console.WriteLine();

                        Console.WriteLine("=> Giam dan");
                        dbhh.sortByG<HinhHoc>(true).Xuat();
                        break;

                        #endregion

                       
                    #region Them
                    case Menu.DemSoLuong:
                        Console.Clear();
                        Console.WriteLine("So luong cac hinh la:");
                        Dictionary<string, int> result = dbhh.DemSLHinhHoc();
                        foreach (var item in result)
                        {
                            Console.Write('\t');
                            Console.WriteLine(item.Key + ":" + item.Value);
                        }
                        break;
                        #endregion
               }
                Console.WriteLine("\nNhap mot phim bat ky de tiep tuc.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
