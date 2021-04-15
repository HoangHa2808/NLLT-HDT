using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;


namespace QuanLyHinhHoc
{
    internal class TangDTHVuong : IComparer<HinhHoc>
    {
        public int Compare(HinhHoc x, HinhHoc y)
        {
            return (x as HinhVuong).TinhDT().CompareTo((y as HinhVuong).TinhDT());
        }
    }

    class DanhBaHinhHoc
    {
        List<HinhHoc> hhoc = new List<HinhHoc>();


        #region ChucNangThemXoa
        public void Add(HinhHoc hh)
        {
            hhoc.Add(hh);
        }

        public void Remove(HinhHoc hh)
        {
            hhoc.Remove(hh);
        }
        #endregion

        #region HamNhap,Dinhdang,Truyvan
        public void NhapTuFile()
        {
            string path = @"data.txt";
            StreamReader sr = new StreamReader(path);
            string str = "\t";
            HinhHoc hh = new HinhHoc();
            while ((str = sr.ReadLine()) != null)
            {
                string[] line = str.Split(' ');
                string type = line[0];
                switch (type)
                {
                    case "HV":
                        hh = new HinhVuong(int.Parse(line[1].Trim()));
                        break;

                    case "HT":
                        hh = new HinhTron(int.Parse(line[1].Trim()));
                        break;

                    case "HCN":
                        hh = new HinhChuNhat(int.Parse(line[1].Trim()), int.Parse(line[2].Trim()));
                        break;
                }
                hhoc.Add(hh);
            }
        }

        public override string ToString()
        {
            string s = " ";
            foreach (HinhHoc item in hhoc)
            {
                s += "\n" + item;
            }
            return s;
        }

        public void Xuat()
        {
            Console.WriteLine(this.ToString());
        }
        #endregion

        //Câu 3(đề bài) cần tìm hiểu 

        #region DanhSachCacHinh
        public DanhBaHinhHoc ListHVuong()
        {
            DanhBaHinhHoc hoc = new DanhBaHinhHoc();
            foreach (var item in hhoc)
                if (item is HinhVuong)
                    hoc.Add(item);
            return hoc;
        }

        public DanhBaHinhHoc ListHTron()
        {
            DanhBaHinhHoc hoc = new DanhBaHinhHoc();
            foreach (var item in hhoc)
            {
                if (item is HinhTron)
                    hoc.Add(item);
            }
            return hoc;
        }

        public DanhBaHinhHoc ListHCN()
        {
            DanhBaHinhHoc hoc = new DanhBaHinhHoc();
            foreach (var item in hhoc)
            {
                if (item is HinhChuNhat)
                    hoc.Add(item);
            }
            return hoc;
        }
        #endregion

        #region TimDTMin
        #region DTMinHVuong
        float TinhDTHVuongMin()
        {
            float min = float.MaxValue;
            foreach (var item in hhoc)
            {
                if (item is HinhVuong)
                {
                    float dt = ((HinhVuong)item).TinhDT();
                    if (dt < min)
                        min = dt;
                }
            }
            return min;
        }

        public DanhBaHinhHoc TinhHVuongCoDTMin()
        {
            DanhBaHinhHoc kq = new DanhBaHinhHoc();
            float min = TinhDTHVuongMin();
            foreach (var item in hhoc)
            {
                if (item is HinhVuong && ((HinhVuong)item).TinhDT() == min)
                    kq.Add(item);

            }
            return kq;
        }
        #endregion

        #region DTMinHTron
        float TinhDTHTronMin()
        {
            float min = float.MaxValue;
            foreach (var item in hhoc)
            {
                if (item is HinhTron)
                {
                    float dt = ((HinhTron)item).TinhDT();
                    if (dt < min)
                        min = dt;
                }
            }
            return min;
        }

        public DanhBaHinhHoc TinhHTronCoDTMin()
        {
            DanhBaHinhHoc kq = new DanhBaHinhHoc();
            float min = TinhDTHTronMin();
            foreach (var item in hhoc)
            {
                if (item is HinhTron && ((HinhTron)item).TinhDT() == min)
                    kq.Add(item);
            }
            return kq;
        }
        #endregion

        #region DTMinHCN
        float TinhDTHCNMin()
        {
            float min = float.MaxValue;

            foreach (var item in hhoc)
            {
                if (item is HinhChuNhat)
                {
                    float dt = ((HinhChuNhat)item).TinhDT();
                    if (dt < min)
                        min = dt;
                }
            }
            return min;
        }

        public DanhBaHinhHoc TinhHCNCoDTMin()
        {
            DanhBaHinhHoc kq = new DanhBaHinhHoc();
            float min = TinhDTHCNMin();
            foreach (var item in hhoc)
            {
                if (item is HinhChuNhat && ((HinhChuNhat)item).TinhDT() == min)
                    kq.Add(item);
            }
            return kq;
        }
        #endregion

        #endregion

        #region TimCVMin

        #region CVMinHTron
        float TinhCVHTronMin()
        {
            float min = float.MaxValue;

            foreach (var item in hhoc)
            {
                if (item is HinhTron)
                {
                    float cv = ((HinhTron)item).TinhCV();
                    if (cv < min)
                        min = cv;
                }
            }
            return min;
        }

        public DanhBaHinhHoc TinhHTronCoCVMin()
        {
            DanhBaHinhHoc kq = new DanhBaHinhHoc();
            float min = TinhCVHTronMin();
            foreach (var item in hhoc)
            {
                if (item is HinhTron && ((HinhTron)item).TinhCV() == min)
                    kq.Add(item);
            }
            return kq;
        }
        #endregion

        #region CVMinHVuong
        float TinhCVHVuongMin()
        {
            float min = float.MaxValue;
            foreach (var item in hhoc)
            {
                if (item is HinhVuong)
                {
                    float cv = ((HinhVuong)item).TinhCV();
                    if (cv < min)
                        min = cv;
                }
            }

            return min;
        }

        public DanhBaHinhHoc TinhHVuongCoCVMin()
        {
            DanhBaHinhHoc kq = new DanhBaHinhHoc();
            float min = TinhCVHVuongMin();
            foreach (var item in hhoc)
            {
                if (item is HinhVuong && ((HinhVuong)item).TinhCV() == min)
                    kq.Add(item);
            }
            return kq;
        }
        #endregion

        #region CVMinHCN
        float TinhCVHCNMin()
        {
            float min = float.MaxValue;

            foreach (var item in hhoc)
            {
                if (item is HinhChuNhat)
                {
                    float cv = ((HinhChuNhat)item).TinhCV();
                    if (cv < min)
                        min = cv;
                }
            }
            return min;
        }

        public DanhBaHinhHoc TinhHCNCoCVMin()
        {
            DanhBaHinhHoc kq = new DanhBaHinhHoc();
            float min = TinhCVHCNMin();
            foreach (var item in hhoc)
            {
                if (item is HinhChuNhat && ((HinhChuNhat)item).TinhCV() == min)
                    kq.Add(item);
            }
            return kq;
        }
        #endregion

        #endregion

       /* #region SapXep
        public List<HinhHoc> getList<T>()
        {
            List<HinhHoc> newList = new List<HinhHoc>();
            newList = hhoc.Where(p => p is T).ToList();
            return newList;
        }
       

        public List<HinhHoc> sortByG<T>(bool isP)
        {
            List<HinhHoc> newList = getList<T>();
            if (isP)
            {
                newList = newList.OrderByDescending(x => x.TinhCV()).ToList();
            }
            else
            {
                newList = newList.OrderByDescending(x => x.TinhDT()).ToList();
            }
            return newList;
        }

        public List<HinhHoc> sortByT<T>(bool isS)
        {
            List<HinhHoc> newList = getList<T>();
            if (isS)
            {
                newList = newList.OrderBy(x => x.TinhCV()).ToList();
            }
            else
            {
                newList = newList.OrderBy(x => x.TinhDT()).ToList();
            }
            return newList;
        }
        #endregion */

        #region CanhMaxMin

        #region CanhMaxMinHVuong
        float TimHVuongCoCanhMax()
        {
            float max = -1;
            foreach (var item in hhoc)
            {
                if (item is HinhVuong)
                {
                    float canh = ((HinhVuong)item).canh;
                    if (canh > max)
                        max = canh;
                }
            }
            return max;
        }

        public DanhBaHinhHoc TimCanhHVuongMax()
        {
            DanhBaHinhHoc kq = new DanhBaHinhHoc();
            float max = TimHVuongCoCanhMax();
            foreach (var item in hhoc)
            {
                if (item is HinhVuong && ((HinhVuong)item).canh == max)
                    kq.Add(item);
            }
            return kq;
        }
        float TimHVuongCoCanhMin()
        {
            float min = float.MaxValue;
            foreach (var item in hhoc)
            {
                if (item is HinhVuong)
                {
                    float canh = ((HinhVuong)item).canh;
                    if (canh < min)
                        min = canh;
                }
            }
            return min;
        }

        public DanhBaHinhHoc TimCanhHVuongMin()
        {
            DanhBaHinhHoc kq = new DanhBaHinhHoc();
            float min = TimHVuongCoCanhMin();
            foreach (var item in hhoc)
            {
                if (item is HinhVuong && ((HinhVuong)item).canh == min)
                    kq.Add(item);
            }
            return kq;
        }
        #endregion

        #region CanhMaxMinHTron
        float TimHTronCoCanhMax()
        {
            float max = -1;
            foreach (var item in hhoc)
            {
                if (item is HinhTron)
                {
                    float bkinh = ((HinhTron)item).bKinh;
                    if (bkinh > max)
                        max = bkinh;
                }
            }
            return max;
        }

        public DanhBaHinhHoc TimCanhHTronMax()
        {
            DanhBaHinhHoc kq = new DanhBaHinhHoc();
            float max = TimHTronCoCanhMax();
            foreach (var item in hhoc)
            {
                if (item is HinhTron && ((HinhTron)item).bKinh == max)
                    kq.Add(item);
            }
            return kq;
        }
        float TimHTronCoCanhMin()
        {
            float min = float.MaxValue;
            foreach (var item in hhoc)
            {
                if (item is HinhTron)
                {
                    float bkinh = ((HinhTron)item).bKinh;
                    if (bkinh < min)
                        min = bkinh;
                }
            }
            return min;
        }

        public DanhBaHinhHoc TimCanhHTronMin()
        {
            DanhBaHinhHoc kq = new DanhBaHinhHoc();
            float min = TimHTronCoCanhMin();
            foreach (var item in hhoc)
            {
                if (item is HinhTron && ((HinhTron)item).bKinh == min)
                    kq.Add(item);
            }
            return kq;
        }
        #endregion

        #region CanhMaxMinHCN
        float TimHCNCoCanhMax()
        {
            float max = -1;
            foreach (var item in hhoc)
            {
                if (item is HinhChuNhat)
                {
                    float cdai = ((HinhChuNhat)item).TinhCV() / ((HinhChuNhat)item).chieuRong * 2;
                    if (cdai > max)
                        max = cdai;
                }
            }
            return max;
        }

        public DanhBaHinhHoc TimCanhHCNMax()
        {
            DanhBaHinhHoc kq = new DanhBaHinhHoc();
            float max = TimHCNCoCanhMax();
            foreach (var item in hhoc)
            {
                if (item is HinhChuNhat && ((HinhChuNhat)item).TinhCV() / ((HinhChuNhat)item).chieuRong * 2 == max)
                    kq.Add(item);
            }
            return kq;
        }

        float TimHCNCoCanhMin()
        {
            float min = float.MaxValue;
            foreach (var item in hhoc)
            {
                if (item is HinhChuNhat)
                {
                    float cdai = ((HinhChuNhat)item).TinhCV() / ((HinhChuNhat)item).chieuRong * 2;
                    if (cdai < min)
                        min = cdai;
                }
            }
            return min;
        }

        public DanhBaHinhHoc TimCanhHCNMin()
        {
            DanhBaHinhHoc kq = new DanhBaHinhHoc();
            float min = TimHCNCoCanhMin();
            foreach (var item in hhoc)
            {
                if (item is HinhChuNhat && ((HinhChuNhat)item).TinhCV() / ((HinhChuNhat)item).chieuRong * 2 == min)
                    kq.Add(item);
            }
            return kq;
        }
        #endregion

        #endregion

        #region TongDT-CV

        #region TongDT,CVHVuong
        public float TinhTongDTHVuong()
        {
            float sum = 0;
            foreach (var item in hhoc)
            {
                if (item is HinhVuong)
                {
                    sum += ((HinhVuong)item).TinhDT();
                }
            }
            return sum;
        }

        public float TinhTongCVHVuong()
        {
            float sum = 0;
            foreach (var item in hhoc)
            {
                if (item is HinhVuong)
                {
                    sum += ((HinhVuong)item).TinhCV();
                }
            }
            return sum;
        }

        #endregion

        #region TongDT,CVHTron
        public float TinhTongDTHTron()
        {
            float sum = 0;
            foreach (var item in hhoc)
            {
                if (item is HinhTron)
                {
                    sum += ((HinhTron)item).TinhDT();
                }
            }
            return sum;
        }

        public float TinhTongCVHTron()
        {
            float sum = 0;
            foreach (var item in hhoc)
            {
                if (item is HinhTron)
                {
                    sum += ((HinhTron)item).TinhCV();
                }
            }
            return sum;
        }

        #endregion

        #region TinhTongDT,CVHCN
        public float TinhTongDTHCN()
        {
            float sum = 0;
            foreach (var item in hhoc)
            {
                if (item is HinhChuNhat)
                {
                    sum += ((HinhChuNhat)item).TinhDT();
                }
            }
            return sum;
        }

        public float TinhTongCVHCN()
        {
            float sum = 0;
            foreach (var item in hhoc)
            {
                if (item is HinhChuNhat)
                {
                    sum += ((HinhChuNhat)item).TinhDT();
                }
            }
            return sum;
        }
        #endregion

        #endregion

        #region DemSLuong

        #region DemSLHVuong
        public int DemSoLuong()
        {
            int dem = 0;
            foreach (var item in hhoc)
                if (item is HinhVuong)
                    dem++;
            return dem;
        }
        //public Dictionary<string, int> DemSLHVuong()
        //{

        //    Dictionary<string, int> maps = new Dictionary<string, int>();
        //    foreach (HinhVuong item in hhoc)
        //    {
        //        int count = hhoc.Where(x => x.GetType() == item.GetType()).Count();

        //        if (maps.Where(x => x.Key == item.GetType().Name).ToList().Count == 0)
        //        {
        //            maps.Add(item.GetType().Name, count);
        //        }
        //    }
        //    return maps;
        //}
        #endregion

        #region DemSLHTron
        public int DemSLHinhTron()
        {
            int dem = 0;
            foreach (var item in hhoc)
                if (item is HinhTron)
                    dem++;
            return dem;
        }
        #endregion

        #region DemSLHCN
        public int DemSLHinhCN()
        {
            int dem = 0;
            foreach (var item in hhoc)
                if (item is HinhChuNhat)
                    dem++;
            return dem;
        }
        #endregion

        #endregion

        // Còn câu 11,12,13

        #region TimSVMaxMinCuaCacHinh

        #region DienTich
        float TinhDTMax()
        {
            return hhoc.Max(x => x.TinhDT());
            // float dt = item.TinhDT();
            //if (item is HinhVuong)
            //    dt = ((HinhVuong)item).TinhDT();
            //if (item is HinhTron)
            //    dt = ((HinhTron)item).TinhDT();
            //if (dt > max)
            //    max = dt;
        }

        public DanhBaHinhHoc TinhHinhCoDTMax()
        {
            DanhBaHinhHoc kq = new DanhBaHinhHoc();
            float max = TinhDTMax();
            foreach (HinhHoc item in hhoc)
            {
                if (max == item.TinhDT())
                    kq.Add(item);
                //if (item is HinhVuong && ((HinhVuong)item).TinhDT() > max)
                //    kq.Add(item);
                //if (item is HinhTron && ((HinhTron)item).TinhDT() > max)
                //    kq.Add(item);
                //if (item is HinhChuNhat && ((HinhChuNhat)item).TinhDT() > max)
                //    kq.Add(item);
            }
            return kq;
        }

        float TinhDTMin()
        {
            return hhoc.Min(x => x.TinhDT());
        }

        public DanhBaHinhHoc TinhHinhCoDTMin()
        {
            DanhBaHinhHoc kq = new DanhBaHinhHoc();
            float min = TinhDTMin();
            foreach (HinhHoc item in hhoc)
            {
                if (min == item.TinhDT())
                    kq.Add(item);
            }
            return kq;
        }
        #endregion

        #region ChuVi
        float TimCVMax()
        {
            return hhoc.Max(x => x.TinhCV());
        }

        public DanhBaHinhHoc TinhHinhCoCVMax()
        {
            DanhBaHinhHoc kq = new DanhBaHinhHoc();
            float max = TimCVMax();
            foreach (HinhHoc item in hhoc)
            {
                if (max == item.TinhCV())
                    kq.Add(item);
            }
            return kq;
        }

        float TinhCVMin()
        {
            return hhoc.Min(x => x.TinhCV());
        }

        public DanhBaHinhHoc TinhHinhCoCVMin()
        {
            DanhBaHinhHoc kq = new DanhBaHinhHoc();
            float min = TinhCVMin();
            foreach (var item in hhoc)
            {
                if (min == item.TinhCV())
                    kq.Add(item);
            }
            return kq;
        }
        #endregion

        #endregion

        #region DemSoLuongHinhHoc
        public Dictionary<string, int> DemSLHinhHoc()
        {
            Dictionary<string, int> maps = new Dictionary<string, int>();
            foreach (HinhHoc item in hhoc)
            {
                int count = hhoc.Where(x => x.GetType() == item.GetType()).Count();

                if (maps.Where(x => x.Key == item.GetType().Name).ToList().Count == 0)
                {
                    maps.Add(item.GetType().Name, count);
                }
            }
            return maps;
        }
        #endregion

       // #region HienThi
        public DanhBaHinhHoc getList1<T>()
        {
            DanhBaHinhHoc kq = new DanhBaHinhHoc();
            kq.hhoc = hhoc.Where(p => p is T).ToList();
            return kq;
        }

        public DanhBaHinhHoc sortByG<T>(bool isP)
        {
            DanhBaHinhHoc newList = getList1<T>();
            if (isP)
            {
                newList.hhoc = newList.hhoc.OrderByDescending(x => x.TinhCV()).ToList();
            }
            else
            {
                newList.hhoc = newList.hhoc.OrderByDescending(x => x.TinhDT()).ToList();
            }
            return newList;
        }

        public DanhBaHinhHoc sortByT<T>(bool isS)
        {
            DanhBaHinhHoc newList = getList1<T>();
            if (isS)
            {
                newList.hhoc = newList.hhoc.OrderBy(x => x.TinhCV()).ToList();
            }
            else
            {
                newList.hhoc = newList.hhoc.OrderBy(x => x.TinhDT()).ToList();
            }
            return newList;
        }
    }
}