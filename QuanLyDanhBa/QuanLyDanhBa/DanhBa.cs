using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.IO;

namespace QuanLyDanhBa
{
    class DanhBa
    {
        public ThueBao[] a = new ThueBao[100];
        public int len = 0;

        public void Them(ThueBao tb)
        {
            a[len++] = tb;
        }

        public void NhapTuFile()
        {
            string path = @"data.txt";
            StreamReader sr = new StreamReader(path);
            string str = "\t";
            while ((str = sr.ReadLine()) != null)
            {
                Them(new ThueBao(str));
            }
        }


        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < len; i++)
            {
                int k = i + 1;
                s += k.ToString().PadLeft(2) + ")   " + a[i];
            }
            return s;
        }


        #region SoLanXuatHienNhieuNhat
        public int DemSoDTTheoThueBao(string cmnd)
        {
            int dem = 0;
            for (int i = 0; i < len; i++)
            {
                if (a[i].soCMND == cmnd)
                    dem++;
            }
            return dem;
        }

        public int TimSoLanXuatHienNhieuNhat()
        {
            int max = -1;
            for (int i = 0; i < len; i++)
            {
                int dem = DemSoDTTheoThueBao(a[i].soCMND);
                if (dem > max)
                    max = dem;
            }
            return max;
        }

        bool CoChua(ThueBao tb)
        {
            for (int i = 0; i < len; i++)
            {
                if (a[i].soCMND == tb.soCMND)
                    return true;
            }
            return false;
        }

        #endregion

        public DanhBa TimThueBaoCoNhieuSDT()
        {
            DanhBa kq = new DanhBa();
            int max = TimSoLanXuatHienNhieuNhat();
            for (int i = 0; i < len; i++)
            {
                if (DemSoDTTheoThueBao(a[i].soCMND) == max && !kq.CoChua(a[i]))
                    kq.Them(a[i]);
            }
            return kq;
        }
       


        #region SapXep
        public void SapXepTheoChieuTangCuaTen()
        {
            SapXep(KieuSapXep.TangTheoHoTen);
        }

        public void SapXepTheoChieuGiamCuaTen()
        {
            SapXep(KieuSapXep.GiamTheoHoTen);
        }

        public void SapXepTangNgaySinh()
        {
            SapXep(KieuSapXep.TangTheoNgaySinh);
        }

        public void SapXepGiamNgaySinh()
        {
            SapXep(KieuSapXep.GiamTheoNgaySinh);

        }

        public enum KieuSapXep
        {
            TangTheoHoTen = 1,
            GiamTheoHoTen = 2,
            TangTheoNgaySinh = 3,
            GiamTheoNgaySinh= 4
        }

        private int KiemTraDieuKien(ThueBao thueBao1, ThueBao thueBao2, KieuSapXep k)
        {
            if (k == KieuSapXep.TangTheoHoTen)
                return thueBao1.hoTen.CompareTo(thueBao2.hoTen);
            if (k == KieuSapXep.GiamTheoHoTen)
                return - thueBao1.hoTen.CompareTo(thueBao2.hoTen);
            if (k == KieuSapXep.TangTheoNgaySinh)
                return thueBao1.ngaySinh.CompareTo(thueBao2.ngaySinh);
            if (k == KieuSapXep.GiamTheoNgaySinh)
                return - thueBao1.ngaySinh.CompareTo(thueBao2.ngaySinh);
            return -1;
        }

        public void SapXep(KieuSapXep k)
        {
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (KiemTraDieuKien(a[i], a[j], k) == 1)
                    {
                        ThueBao tam = a[i];
                        a[i] = a[j];
                        a[j] = tam;
                    }
                }
            }
        }
        #endregion


        #region ThanhPhoXuatHienNhieuNhat
        public int DemThanhPhoXuatHienNhieuNhat(string Tinh)
        {
            int dem = 0;
            for (int i = 0; i < len; i++)
            {
                if (a[i].diaChi == Tinh)
                   dem++;
            }
            return dem;
        }

        public int TimThanhPhoXuatHienNhieuNhat()
        {

            int max = -1;
            for (int i = 0; i < len; i++)
            {
              if (max < DemThanhPhoXuatHienNhieuNhat(a[i].diaChi))               
                    max = DemThanhPhoXuatHienNhieuNhat(a[i].diaChi);
            }
            return max;
        }

       /* bool CoChu(ThueBao tb)
        {
            for (int i = 0; i < len; i++)
            {
                if (a[i].diaChi == tb.diaChi)
                    return true;
            }
            return false;
        }*/

        /*public DanhBa XuatHienNhieuNhat()
        {
            DanhBa xh = new DanhBa();
            int max = TimThanhPhoXuatHienNhieuNhat();
            for (int i = 0; i < len; i++)
            {
                if (DemSoDTTheoThueBao(a[i].diaChi) == max )
                    xh.Them(a[i]);
            }
            return xh;
        }*/

        public List<String> TPhoXuatHienNhieuNhat()
        {
            List<string> tp = new List<string>();
            int max = TimThanhPhoXuatHienNhieuNhat();
            for (int i = 0; i < len; i++)
            {
                if(DemThanhPhoXuatHienNhieuNhat(a[i].diaChi)== max && !tp.Contains(a[i].diaChi))
                tp.Add(a[i].diaChi);
            }
            return tp;
        }
        #endregion


        public void Xuat()
        {
            Console.WriteLine("\n===== Danh sach thue bao ====");
            for (int i = 0; i < len; i++)
            {
                a[i].Xuat();
            }
        }



    }
}
