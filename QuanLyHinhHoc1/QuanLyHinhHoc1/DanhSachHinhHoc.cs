using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;


namespace QuanLyHinhHoc1
{
	internal class TangDTHVuong : IComparer<HinhHoc>
	{
		public int Compare(HinhHoc x, HinhHoc y)
		{
			return (x as HinhVuong).TinhDT().CompareTo((y as HinhVuong).TinhDT());
		}
	}

	class DanhSachHinhHoc
	{
		List<HinhHoc> hhoc = new List<HinhHoc>();
		//List<string> listKieuHinhHoc;

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

		#region HamNhap,Xuat,Dinhdang,Truyvan
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
		
		#region TimDT,CVTaiX
		public List<HinhHoc> TimDTTheoX<T>(float x)
		{
			return hhoc.Where(y => y is T && y.TinhDT() == x).ToList();
		}

		public List<HinhHoc> TimCVTheoX<T>(float x)
		{
			return hhoc.Where(y => y is T && y.TinhCV() == x).ToList();
		}
		#endregion

		#region DanhSachCacHinh
		public DanhSachHinhHoc ListHVuong()
		{
			DanhSachHinhHoc hoc = new DanhSachHinhHoc();
			foreach (var item in hhoc)
				if (item is HinhVuong)
					hoc.Add(item);
			return hoc;
		}

		public DanhSachHinhHoc ListHTron()
		{
			DanhSachHinhHoc hoc = new DanhSachHinhHoc();
			foreach (var item in hhoc)
			{
				if (item is HinhTron)
					hoc.Add(item);
			}
			return hoc;
		}

		public DanhSachHinhHoc ListHCN()
		{
			DanhSachHinhHoc hoc = new DanhSachHinhHoc();
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

		public DanhSachHinhHoc TinhHVuongCoDTMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
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

		public DanhSachHinhHoc TinhHTronCoDTMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
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

		public DanhSachHinhHoc TinhHCNCoDTMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
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

		public DanhSachHinhHoc TinhHTronCoCVMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float min = TinhCVHTronMin();
			foreach (var item in hhoc)
			{
				if (item is HinhTron && item.TinhCV() == min)
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

		public DanhSachHinhHoc TinhHVuongCoCVMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
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

		public DanhSachHinhHoc TinhHCNCoCVMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
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


		#region SapXep1
		/* public List<HinhHoc> getList<T>()
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
         }*/
		#endregion

		#region SapXep(HienThi)TangGiamDT,CV
		public DanhSachHinhHoc getList1<T>()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			kq.hhoc = hhoc.Where(p => p is T).ToList();
			return kq;
		}

		public DanhSachHinhHoc sortByG<T>(bool isP)
		{
			DanhSachHinhHoc newList = getList1<T>();
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

		public DanhSachHinhHoc sortByT<T>(bool isS)
		{
			DanhSachHinhHoc newList = getList1<T>();
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
		#endregion
		
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

		public DanhSachHinhHoc TimCanhHVuongMax()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
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

		public DanhSachHinhHoc TimCanhHVuongMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
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

		public DanhSachHinhHoc TimCanhHTronMax()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
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

		public DanhSachHinhHoc TimCanhHTronMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
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

		public DanhSachHinhHoc TimCanhHCNMax()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
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

		public DanhSachHinhHoc TimCanhHCNMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
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
		/*
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
        */
		#endregion

		#region demo TinhTongDienTich-ChuVi
		public float TinhTongDT<T>()
		{
			float sum = 0;
			foreach (var item in hhoc)
			{
				if (item is T)
				{
					sum += item.TinhDT();
				}
			}
			return sum;
		}

		//      public bool ASDASD()
		//{
		//          string a = "Hinh Vuong";
		//          string b = "Hinh Tron";
		//          string c = "Hinh Chu Nhat";
		//          float max = TinhTongDT<HinhTron>();
		//          if (max > TinhTongDT<HinhVuong>())
		//              max = TinhTongDT<HinhVuong>()
		//                  return a;
		//          if (max > TinhTongDT<HinhChuNhat>())
		//              max = TinhTongDT<HinhChuNhat>()
		//                  return c;
		//          return b;
		//}

		public float TinhTongCV<T>()
		{
			float sum = 0;
			foreach (var item in hhoc)
			{
				if (item is T)
				{
					sum += item.TinhCV();
				}
			}
			return sum;
		}
		#endregion

		#region DemSLuong

		public int DemSLHinh<T>()
		{
			int dem = 0;
			foreach (var item in hhoc)
				if (item is T)
					dem++;
			return dem;
		}
		/*
        #region DemSLHVuong
        public int DemSLHinhVuong()
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
        */
		#endregion

		// Còn câu 11,12,13

		#region TimSVMaxMinCuaCacHinh

		#region DienTich
		float TinhDTMax()
		{
			return hhoc.Max(x => x.TinhDT());
			// float dt = item.TinhDT();
			//if (item is HinhVuong)
			//    dt = ((HinhVuong)item).TinhD
			//    T();
			//if (item is HinhTron)
			//    dt = ((HinhTron)item).TinhDT();
			//if (dt > max)
			//    max = dt;
		}

		public DanhSachHinhHoc TinhHinhCoDTMax()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
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

		public DanhSachHinhHoc TinhHinhCoDTMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
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
		float TinhCVMax()
		{
			return hhoc.Max(x => x.TinhCV());
		}

		public DanhSachHinhHoc TinhHinhCoCVMax()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float max = TinhCVMax();
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

		public DanhSachHinhHoc TinhHinhCoCVMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
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

		#region Them

		public void ThemHinhTaiViTri(HinhHoc a, int i)
		{
			hhoc.Insert(i - 1, a);
		}
		#endregion

		#region Xoa

		#region XoaDTHinhMin,Max
		public List<HinhHoc> XoaHinhCoDTMax()
		{
			List<HinhHoc> refList = hhoc;
			float max = TinhDTMax();// Để ra ngoài ???
			List<HinhHoc> maxList = hhoc.Where(x => x.TinhDT() == max).ToList();
			foreach (var item in maxList)
			{
				refList.Remove(item);
			}
			return refList;
		}

		public List<HinhHoc> XoaHinhCoDTMin()
		{
			List<HinhHoc> dtMin = hhoc;
			float min = TinhDTMin();
			List<HinhHoc> minList = hhoc.Where(x => x.TinhDT() == min).ToList();
			foreach (var item in minList)
			{
				dtMin.Remove(item);
			}
			return dtMin;
		}
		#endregion

		#region XoaHinhCoCVMax,Min
		public List<HinhHoc> XoaHinhCoCVMax()
		{
			List<HinhHoc> cvMax = hhoc;
			float max = TinhCVMax();
			List<HinhHoc> maxList = hhoc.Where(x => x.TinhCV() == max).ToList();
			foreach (var item in maxList)
			{
				cvMax.Remove(item);
			}
			return cvMax;
		}

		public List<HinhHoc> XoaHinhCoCVMin()
		{
			List<HinhHoc> cvMin = hhoc;
			float min = TinhCVMin();
			List<HinhHoc> minList = hhoc.Where(x => x.TinhCV() == min).ToList();
			foreach (var item in minList)
			{
				cvMin.Remove(item);
			}
			return cvMin;
		}
		#endregion

		#region XoaTaiViTri
		public void XoaTaiViTri(int x)
		{
			hhoc.RemoveAt(x - 1);
		}
		#endregion

		#endregion

		#region TongDT,CV        
		public float TongDTCacHinh() => TinhTongDT<HinhChuNhat>() + TinhTongDT<HinhTron>() + TinhTongDT<HinhVuong>();
		public float TongCVCacHinh() => TinhTongCV<HinhVuong>() + TinhTongCV<HinhTron>() + TinhTongCV<HinhChuNhat>();
		public int TongCacHinh() => DemSLHinh<HinhVuong>() + DemSLHinh<HinhTron>() + DemSLHinh<HinhChuNhat>();
		#endregion
		
		#region KieuHinhCoTongDienTichMax,Min

		public string TimKieuHCoDTMax()
		{
			float hv = TinhTongDT<HinhVuong>();
			float ht = TinhTongDT<HinhTron>();
			float hcn = TinhTongDT<HinhChuNhat>();

			//         string kq = "";
			//if(hv < ht)
			//{
			//             kq = "T";

			//}
			//else if(ht<hcn)
			//{
			//             kq = "cn";
			//}
			//else
			//{
			//             kq = "v";
			//         }

			string kq = hv < ht ? "hình tròn" : ht < hcn ? "hình chữ nhật " : " hình vuông ";
			return kq;
		}

		public string TimKieuHCoDTMin()
		{
			float hv = TinhTongDT<HinhVuong>();
			float ht = TinhTongDT<HinhTron>();
			float hcn = TinhTongDT<HinhChuNhat>();
			string kq = hv > ht ? "hình tròn" : ht > hcn ? "hình chữ nhật" : "hình vuông";
			return kq;
		}

		public string TimKieuHCoCVMax()
		{
			float hv = TinhTongCV<HinhVuong>();
			float ht = TinhTongCV<HinhTron>();
			float hcn = TinhTongCV<HinhChuNhat>();
			string kq = hv < ht ? "hình tròn" : ht < hcn ? "hình chữ nhật" : "hình vuông";
			return kq;
		}

		public string TimKieuHCoCVMin()
		{
			float hv = TinhTongCV<HinhVuong>();
			float ht = TinhTongCV<HinhTron>();
			float hcn = TinhTongCV<HinhChuNhat>();
			string kq = ht > hv ? "hình vuông" : hv > hcn ? "hình chữ nhật" : "hình tròn";
			return kq;
		}
		#endregion

		public string XuatBangTongHop()
		{
			string str;
			str = "\tBANG TONG HOP THONG TIN\n" +
				$"1) Tong so cac doi tuong hinh hoc: {DemSLHinhHoc()}\n" +
				$"2) Tong so hinh vuong: {DemSLHinh<HinhVuong>()}\n" +
				$"3) Tong so hinh tron: {DemSLHinh<HinhTron>()}\n" +
				$"4) Tong so hinh chu nhat: {DemSLHinh<HinhChuNhat>()}\n" +
				$"\nA. Danh sach hinh vuong: \n" + sortByT<HinhVuong>(false) +
				$"\n\nB. Danh sach hinh tron: \n" + sortByT<HinhTron>(false) +
				$"\n\nC. Danh sach hinh chu nhat: \n" + sortByT<HinhChuNhat>(false) +
				$"\n";
			return str;
		}

		#region Ghi
		public void GhiBangTongHopXuongFile()
		{
			string str;
			str = XuatBangTongHop();

			using (StreamWriter file = new StreamWriter(@"tonghop.txt", append: false))
			{
				file.Write(str);
			}
		}

		public string XuatHinhVuong()
		{
			string str;
			str = "" + sortByT<HinhVuong>(false);

			return str;
		}

		public void GhiDanhSachHinhVuongXuongFile()
		{
			string str;
			str = XuatHinhVuong();

			using (StreamWriter file = new StreamWriter(@"hvuong.txt", append: false))
			{
				file.Write(str);
			}
		}

		public string XuatHinhTron()
		{
			string str;
			str = "" + sortByT<HinhTron>(false);

			return str;
		}

		public void GhiDanhSachHinhTronXuongFile()
		{
			string str;
			str = XuatHinhTron();

			using (StreamWriter file = new StreamWriter(@"htron.txt", append: false))
			{
				file.Write(str);
			}
		}

		public string XuatHinhChuNhat()
		{
			string str;
			str = "" + sortByT<HinhChuNhat>(false);

			return str;
		}

		public void GhiDanhSachHinhChuNhatXuongFile()
		{
			string str;
			str = XuatHinhChuNhat();

			using (StreamWriter file = new StreamWriter(@"hchunhat.txt", append: false))
			{
				file.Write(str);
			}
		}
		#endregion

	}
}