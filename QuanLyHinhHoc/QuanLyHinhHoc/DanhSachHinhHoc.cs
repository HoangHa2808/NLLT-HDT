using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
	class DanhSachHinhHoc
	{
		List<HinhHoc> collection = new List<HinhHoc>();

		public void Them(HinhHoc hh)
		{
			collection.Add(hh);
		}

		public override string ToString()
		{
			string s = "";
			foreach (var item in collection)
				s += "\n" + item;
			return s;
		}

		public void Xuat()
		{
			Console.WriteLine(this.collection);
		}

		public DanhSachHinhHoc NhapTuFile()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			string[] s;
			string str;
			StreamReader sr = new StreamReader("D:\\Data.txt");
			str = sr.ReadToEnd();
			s = str.Split(' ');

			for (int i = 0; i < s.Length; i -= -1)
			{
				if (s[i] == "HV")
					kq.Them(new HinhVuong(float.Parse(s[i + 1].Trim())));
				if (s[i] == "HT")
					kq.Them(new HinhTron(float.Parse(s[i + 1].Trim())));
				if (s[i] == "HCN")
					kq.Them(new HinhChuNhat(float.Parse(s[i + 1].Trim()), float.Parse(s[i + 2].Trim())));
			}

			return kq;
		}

		public DanhSachHinhHoc TimHinhVuongCoDienTichX(float dt)
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();

			foreach (var item in collection)
				if (item is HinhVuong && ((HinhVuong)item).TinhDT() == dt)
					kq.Them(item);

			return kq;
		}

		public DanhSachHinhHoc TimHinhVuongCoChuViX(float cv)
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();

			foreach (var item in collection)
				if (item is HinhVuong && ((HinhVuong)item).TinhCV() == cv)
					kq.Them(item);

			return kq;
		}

		public float TimDTHVMin()
		{
			float min;
			min = 1000;

			foreach (var item in collection)
				if (item is HinhVuong && ((HinhVuong)item).TinhDT() < min)
					min = ((HinhVuong)item).TinhDT();

			return min;
		}

		public DanhSachHinhHoc TimHinhVuongCoDTMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float min;
			min = TimDTHVMin();

			foreach (var item in collection)
				if (item is HinhVuong && ((HinhVuong)item).TinhDT() == min)
					kq.Them(item);

			return kq;
		}

		public float TimCVHVMin()
		{
			float min;
			min = 1000;

			foreach (var item in collection)
				if (item is HinhVuong && ((HinhVuong)item).TinhCV() < min)
					min = ((HinhVuong)item).TinhCV();

			return min;
		}

		public DanhSachHinhHoc TimHinhVuongCoCVMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float min;
			min = TimCVHVMin();

			foreach (var item in collection)
				if (item is HinhVuong && ((HinhVuong)item).TinhCV() == min)
					kq.Them(item);

			return kq;
		}

		public float TimCanhHVMin()
		{
			float min;
			min = 1000;

			foreach (var item in collection)
				if (item is HinhVuong && ((HinhVuong)item).canh < min)
					min = ((HinhVuong)item).canh;

			return min;
		}

		public DanhSachHinhHoc TimHinhVuongCoCanhMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float min;
			min = TimCanhHVMin();

			foreach (var item in collection)
				if (item is HinhVuong && ((HinhVuong)item).canh == min)
					kq.Them(item);

			return kq;
		}

		public float TimCanhHVMax()
		{
			float max;
			max = -1;

			foreach (var item in collection)
				if (item is HinhVuong && ((HinhVuong)item).canh > max)
					max = ((HinhVuong)item).canh;

			return max;
		}

		public DanhSachHinhHoc TimHinhVuongCoCanhMax()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float max;
			max = TimCanhHVMax();

			foreach (var item in collection)
				if (item is HinhVuong && ((HinhVuong)item).canh == max)
					kq.Them(item);

			return kq;
		}

		public float TimDTHVMax()
		{
			float max;
			max = -1;

			foreach (var item in collection)
				if (item is HinhVuong && ((HinhVuong)item).TinhDT() > max)
					max = ((HinhVuong)item).TinhDT();

			return max;
		}

		public DanhSachHinhHoc TimHinhVuongCoDTMax()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float max;
			max = TimDTHVMax();

			foreach (var item in collection)
				if (item is HinhVuong && ((HinhVuong)item).TinhDT() == max)
					kq.Them(item);

			return kq;
		}

		public float TimCVHVMax()
		{
			float max;
			max = -1;

			foreach (var item in collection)
				if (item is HinhVuong && ((HinhVuong)item).TinhCV() > max)
					max = ((HinhVuong)item).TinhCV();

			return max;
		}

		public DanhSachHinhHoc TimHinhVuongCoCVMax()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float max;
			max = TimCVHVMax();

			foreach (var item in collection)
				if (item is HinhVuong && ((HinhVuong)item).TinhCV() == max)
					kq.Them(item);

			return kq;
		}

		public DanhSachHinhHoc TimHinhTronCoDienTichX(float dt)
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();

			foreach (var item in collection)
				if (item is HinhTron && ((HinhTron)item).TinhDT() == dt)
					kq.Them(item);

			return kq;
		}

		public DanhSachHinhHoc TimHinhTronCoChuViX(float cv)
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();

			foreach (var item in collection)
				if (item is HinhTron && ((HinhTron)item).TinhCV() == cv)
					kq.Them(item);

			return kq;
		}

		public float TimDTHTMin()
		{
			float min;
			min = 1000;

			foreach (var item in collection)
				if (item is HinhTron && ((HinhTron)item).TinhDT() < min)
					min = ((HinhTron)item).TinhDT();

			return min;
		}

		public DanhSachHinhHoc TimHinhTronCoDTMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float min;
			min = TimDTHTMin();

			foreach (var item in collection)
				if (item is HinhTron && ((HinhTron)item).TinhDT() == min)
					kq.Them(item);

			return kq;
		}

		public float TimCVHTMin()
		{
			float min;
			min = 1000;

			foreach (var item in collection)
				if (item is HinhTron && ((HinhTron)item).TinhCV() < min)
					min = ((HinhTron)item).TinhCV();

			return min;
		}

		public DanhSachHinhHoc TimHinhTronCoCVMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float min;
			min = TimCVHTMin();

			foreach (var item in collection)
				if (item is HinhTron && ((HinhTron)item).TinhCV() == min)
					kq.Them(item);

			return kq;
		}

		public float TimBanKinhHTMin()
		{
			float min;
			min = 1000;

			foreach (var item in collection)
				if (item is HinhTron && ((HinhTron)item).banKinh < min)
					min = ((HinhTron)item).banKinh;

			return min;
		}

		public DanhSachHinhHoc TimHinhTronCoBanKinhMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float min;
			min = TimBanKinhHTMin();

			foreach (var item in collection)
				if (item is HinhTron && ((HinhTron)item).banKinh == min)
					kq.Them(item);

			return kq;
		}

		public float TimBanKinhHTMax()
		{
			float max;
			max = -1;

			foreach (var item in collection)
				if (item is HinhTron && ((HinhTron)item).banKinh > max)
					max = ((HinhTron)item).banKinh;

			return max;
		}

		public DanhSachHinhHoc TimHinhTronCoBanKinhMax()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float max;
			max = TimBanKinhHTMax();

			foreach (var item in collection)
				if (item is HinhTron && ((HinhTron)item).banKinh == max)
					kq.Them(item);

			return kq;
		}

		public float TimDTHTMax()
		{
			float max;
			max = -1;

			foreach (var item in collection)
				if (item is HinhTron && ((HinhTron)item).TinhDT() > max)
					max = ((HinhTron)item).TinhDT();

			return max;
		}

		public DanhSachHinhHoc TimHinhTronCoDTMax()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float max;
			max = TimDTHTMax();

			foreach (var item in collection)
				if (item is HinhTron && ((HinhTron)item).TinhDT() == max)
					kq.Them(item);

			return kq;
		}

		public float TimCVHTMax()
		{
			float max;
			max = -1;

			foreach (var item in collection)
				if (item is HinhTron && ((HinhTron)item).TinhCV() > max)
					max = ((HinhTron)item).TinhCV();

			return max;
		}

		public DanhSachHinhHoc TimHinhTronCoCVMax()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float max;
			max = TimCVHTMax();

			foreach (var item in collection)
				if (item is HinhTron && ((HinhTron)item).TinhCV() == max)
					kq.Them(item);

			return kq;
		}

		public DanhSachHinhHoc TimHinhChuNhatCoDienTichX(float dt)
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();

			foreach (var item in collection)
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhDT() == dt)
					kq.Them(item);

			return kq;
		}

		public DanhSachHinhHoc TimHinhChuNhatCoChuViX(float cv)
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();

			foreach (var item in collection)
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhCV() == cv)
					kq.Them(item);

			return kq;
		}

		public float TimDTHCNMin()
		{
			float min;
			min = 1000;

			foreach (var item in collection)
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhDT() < min)
					min = ((HinhChuNhat)item).TinhDT();

			return min;
		}

		public DanhSachHinhHoc TimHinhChuNhatCoDTMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float min;
			min = TimDTHCNMin();

			foreach (var item in collection)
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhDT() == min)
					kq.Them(item);

			return kq;
		}

		public float TimCVHCNMin()
		{
			float min;
			min = 1000;

			foreach (var item in collection)
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhCV() < min)
					min = ((HinhChuNhat)item).TinhCV();

			return min;
		}

		public DanhSachHinhHoc TimHinhChuNhatCoCVMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float min;
			min = TimCVHCNMin();

			foreach (var item in collection)
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhCV() == min)
					kq.Them(item);

			return kq;
		}

		public float TimChieuDaiHCNMin()
		{
			float min;
			min = 1000;

			foreach (var item in collection)
				if (item is HinhChuNhat && ((HinhChuNhat)item).a < min)
					min = ((HinhChuNhat)item).a;

			return min;
		}

		public DanhSachHinhHoc TimHinhChuNhatCoChieuDaiMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float min;
			min = TimChieuDaiHCNMin();

			foreach (var item in collection)
				if (item is HinhChuNhat && ((HinhChuNhat)item).a == min)
					kq.Them(item);

			return kq;
		}

		public float TimChieuDaiHCNMax()
		{
			float max;
			max = -1;

			foreach (var item in collection)
				if (item is HinhChuNhat && ((HinhChuNhat)item).a > max)
					max = ((HinhChuNhat)item).a;

			return max;
		}

		public DanhSachHinhHoc TimHinhChuNhatCoChieuDaiMax()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float max;
			max = TimChieuDaiHCNMax();

			foreach (var item in collection)
				if (item is HinhChuNhat && ((HinhChuNhat)item).a == max)
					kq.Them(item);

			return kq;
		}

		public float TimDTHCNMax()
		{
			float max;
			max = -1;

			foreach (var item in collection)
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhDT() > max)
					max = ((HinhChuNhat)item).TinhDT();

			return max;
		}

		public DanhSachHinhHoc TimHinhChuNhatCoDTMax()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float max;
			max = TimDTHCNMax();

			foreach (var item in collection)
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhDT() == max)
					kq.Them(item);

			return kq;
		}

		public float TimCVHCNMax()
		{
			float max;
			max = -1;

			foreach (var item in collection)
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhCV() > max)
					max = ((HinhChuNhat)item).TinhCV();

			return max;
		}

		public DanhSachHinhHoc TimHinhChuNhatCoCVMax()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float max;
			max = TimCVHCNMax();

			foreach (var item in collection)
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhCV() == max)
					kq.Them(item);

			return kq;
		}

		public float TimTongDTHinhVuong()
		{
			float sum;
			sum = 0;

			foreach (var item in collection)
				if (item is HinhVuong)
					sum += ((HinhVuong)item).TinhDT();

			return sum;
		}

		public float TimTongDTHinhTron()
		{
			float sum;
			sum = 0;

			foreach (var item in collection)
				if (item is HinhTron)
					sum += ((HinhTron)item).TinhDT();

			return sum;
		}

		public float TimTongDTHinhChuNhat()
		{
			float sum;
			sum = 0;

			foreach (var item in collection)
				if (item is HinhChuNhat)
					sum += ((HinhChuNhat)item).TinhDT();

			return sum;
		}

		public string TimKieuHinhCoTongDTMax()
		{
			string kq;
			float sumMax;
			kq = "";
			sumMax = TimTongDTHinhVuong();

			foreach (var item in collection)
			{
				if (item is HinhTron && TimTongDTHinhTron() > sumMax)
				{
					sumMax = TimTongDTHinhTron();
					kq = "HinhTron";
				}
				if (item is HinhChuNhat && TimTongDTHinhChuNhat() > sumMax)
				{
					sumMax = TimTongDTHinhTron();
					kq = "HinhChuNhat";
				}
			}

			return kq;
		}

		public string TimKieuHinhCoTongDTMin()
		{
			string kq;
			float sumMin;
			kq = "";
			sumMin = TimTongDTHinhVuong();

			foreach (var item in collection)
			{
				if (item is HinhTron && TimTongDTHinhTron() < sumMin)
				{
					sumMin = TimTongDTHinhTron();
					kq = "HinhTron";
				}
				if (item is HinhChuNhat && TimTongDTHinhChuNhat() < sumMin)
				{
					sumMin = TimTongDTHinhChuNhat();
					kq = "HinhChuNhat";
				}
			}

			return kq;
		}

		public float TimTongCVHinhVuong()
		{
			float sum;
			sum = 0;

			foreach (var item in collection)
				if (item is HinhVuong)
					sum += ((HinhVuong)item).TinhCV();

			return sum;
		}

		public float TimTongCVHinhTron()
		{
			float sum;
			sum = 0;

			foreach (var item in collection)
				if (item is HinhTron)
					sum += ((HinhTron)item).TinhCV();

			return sum;
		}

		public float TimTongCVHinhChuNhat()
		{
			float sum;
			sum = 0;

			foreach (var item in collection)
				if (item is HinhChuNhat)
					sum += ((HinhChuNhat)item).TinhCV();

			return sum;
		}

		public string TimKieuHinhCoTongCVMax()
		{
			string kq;
			float sumMax;
			kq = "";
			sumMax = TimTongCVHinhVuong();

			foreach (var item in collection)
			{
				if (item is HinhTron && TimTongCVHinhTron() > sumMax)
				{
					sumMax = TimTongCVHinhTron();
					kq = "HinhTron";
				}
				if (item is HinhChuNhat && TimTongCVHinhChuNhat() > sumMax)
				{
					sumMax = TimTongCVHinhChuNhat();
					kq = "HinhChuNhat";
				}
			}

			return kq;
		}

		public string TimKieuHinhCoTongCVMin()
		{
			string kq;
			float sumMin;
			kq = "";
			sumMin = TimTongCVHinhVuong();

			foreach (var item in collection)
			{
				if (item is HinhTron && TimTongCVHinhTron() < sumMin)
				{
					sumMin = TimTongCVHinhTron();
					kq = "HinhTron";
				}
				if (item is HinhChuNhat && TimTongCVHinhChuNhat() < sumMin)
				{
					sumMin = TimTongCVHinhChuNhat();
					kq = "HinhChuNhat";
				}
			}

			return kq;
		}

		public int DemSoLuongHinhVuong()
		{
			int count;
			count = 0;

			foreach (var item in collection)
				if (item is HinhVuong)
					count -= -1;

			return count;
		}

		public int DemSoLuongHinhTron()
		{
			int count;
			count = 0;

			foreach (var item in collection)
				if (item is HinhTron)
					count -= -1;

			return count;
		}

		public int DemSoLuongHinhChuNhat()
		{
			int count;
			count = 0;

			foreach (var item in collection)
				if (item is HinhChuNhat)
					count -= -1;

			return count;
		}

		public DanhSachHinhHoc DanhSachHinhVuong()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();

			foreach (var item in collection)
				if (item is HinhVuong)
					kq.Them(item);

			return kq;
		}

		public DanhSachHinhHoc DanhSachHinhTron()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();

			foreach (var item in collection)
				if (item is HinhTron)
					kq.Them(item);

			return kq;
		}

		public DanhSachHinhHoc DanhSachHinhChuNhat()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();

			foreach (var item in collection)
				if (item is HinhChuNhat)
					kq.Them(item);

			return kq;
		}

		public DanhSachHinhHoc SapXepHinhVuongTangTheoDT()
		{
			DanhSachHinhHoc kq = DanhSachHinhVuong();

			kq.collection = kq.collection.OrderBy(x => (x as HinhVuong).TinhDT()).ToList();

			return kq;
		}

		public DanhSachHinhHoc SapXepHinhVuongGiamTheoDT()
		{
			DanhSachHinhHoc kq = DanhSachHinhVuong();

			kq.collection = kq.collection.OrderByDescending(x => (x as HinhVuong).TinhDT()).ToList();

			return kq;
		}

		public DanhSachHinhHoc SapXepHinhTronTangTheoDT()
		{
			DanhSachHinhHoc kq = DanhSachHinhTron();

			kq.collection = kq.collection.OrderBy(x => (x as HinhTron).TinhDT()).ToList();

			return kq;
		}

		public DanhSachHinhHoc SapXepHinhTronGiamTheoDT()
		{
			DanhSachHinhHoc kq = DanhSachHinhTron();

			kq.collection = kq.collection.OrderByDescending(x => (x as HinhTron).TinhDT()).ToList();

			return kq;
		}

		public DanhSachHinhHoc SapXepHinhChuNhatTangTheoDT()
		{
			DanhSachHinhHoc kq = DanhSachHinhChuNhat();

			kq.collection = kq.collection.OrderBy(x => (x as HinhChuNhat).TinhDT()).ToList();

			return kq;
		}

		public DanhSachHinhHoc SapXepHinhChuNhatGiamTheoDT()
		{
			DanhSachHinhHoc kq = DanhSachHinhChuNhat();

			kq.collection = kq.collection.OrderByDescending(x => (x as HinhChuNhat).TinhDT()).ToList();

			return kq;
		}

		public DanhSachHinhHoc SapXepHinhVuongTangTheoCV()
		{
			DanhSachHinhHoc kq = DanhSachHinhVuong();

			kq.collection = kq.collection.OrderBy(x => (x as HinhVuong).TinhCV()).ToList();

			return kq;
		}

		public DanhSachHinhHoc SapXepHinhVuongGiamTheoCV()
		{
			DanhSachHinhHoc kq = DanhSachHinhVuong();

			kq.collection = kq.collection.OrderByDescending(x => (x as HinhVuong).TinhCV()).ToList();

			return kq;
		}

		public DanhSachHinhHoc SapXepHinhTronTangTheoCV()
		{
			DanhSachHinhHoc kq = DanhSachHinhTron();

			kq.collection = kq.collection.OrderBy(x => (x as HinhTron).TinhCV()).ToList();

			return kq;
		}

		public DanhSachHinhHoc SapXepHinhTronGiamTheoCV()
		{
			DanhSachHinhHoc kq = DanhSachHinhTron();

			kq.collection = kq.collection.OrderByDescending(x => (x as HinhTron).TinhCV()).ToList();

			return kq;
		}

		public DanhSachHinhHoc SapXepHinhChuNhatTangTheoCV()
		{
			DanhSachHinhHoc kq = DanhSachHinhChuNhat();

			kq.collection = kq.collection.OrderBy(x => (x as HinhChuNhat).TinhCV()).ToList();

			return kq;
		}

		public DanhSachHinhHoc SapXepHinhChuNhatGiamTheoCV()
		{
			DanhSachHinhHoc kq = DanhSachHinhChuNhat();

			kq.collection = kq.collection.OrderBy(x => (x as HinhChuNhat).TinhCV()).ToList();

			return kq;
		}

		public float TimDTMax()
		{
			float max;
			max = -1;

			foreach (var item in collection)
			{
				if (item is HinhVuong && ((HinhVuong)item).TinhDT() > max)
					max = ((HinhVuong)item).TinhDT();
				if (item is HinhTron && ((HinhTron)item).TinhDT() > max)
					max = ((HinhTron)item).TinhDT();
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhDT() > max)
					max = ((HinhChuNhat)item).TinhDT();
			}

			return max;
		}

		public float TimDTMin()
		{
			float min;
			min = TimDTMax();

			foreach (var item in collection)
			{
				if (item is HinhVuong && ((HinhVuong)item).TinhDT() < min)
					min = ((HinhVuong)item).TinhDT();
				if (item is HinhTron && ((HinhTron)item).TinhDT() < min)
					min = ((HinhTron)item).TinhDT();
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhDT() < min)
					min = ((HinhChuNhat)item).TinhDT();
			}

			return min;
		}

		public float TimCVMax()
		{
			float max;
			max = -1;

			foreach (var item in collection)
			{
				if (item is HinhVuong && ((HinhVuong)item).TinhCV() > max)
					max = ((HinhVuong)item).TinhCV();
				if (item is HinhTron && ((HinhTron)item).TinhCV() > max)
					max = ((HinhTron)item).TinhCV();
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhCV() > max)
					max = ((HinhChuNhat)item).TinhCV();
			}

			return max;
		}

		public float TimCVMin()
		{
			float min;
			min = TimCVMax();

			foreach (var item in collection)
			{
				if (item is HinhVuong && ((HinhVuong)item).TinhCV() < min)
					min = ((HinhVuong)item).TinhCV();
				if (item is HinhTron && ((HinhTron)item).TinhCV() < min)
					min = ((HinhTron)item).TinhCV();
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhCV() < min)
					min = ((HinhChuNhat)item).TinhCV();
			}

			return min;
		}

		public DanhSachHinhHoc XoaCacHinhCoDTMax()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float max;
			max = TimDTMax();

			foreach (var item in collection)
				if (item is HinhVuong && ((HinhVuong)item).TinhDT() != max ||
					item is HinhTron && ((HinhTron)item).TinhDT() != max ||
					item is HinhChuNhat && ((HinhChuNhat)item).TinhDT() != max)
					kq.Them(item);

			return kq;
		}

		public DanhSachHinhHoc XoaCacHinhCoDTMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float min;
			min = TimDTMin();

			foreach (var item in collection)
				if (item is HinhVuong && ((HinhVuong)item).TinhDT() != min ||
					item is HinhTron && ((HinhTron)item).TinhDT() != min ||
					item is HinhChuNhat && ((HinhChuNhat)item).TinhDT() != min)
					kq.Them(item);

			return kq;
		}

		public DanhSachHinhHoc XoaCacHinhCoCVMax()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float max;
			max = TimCVMax();

			foreach (var item in collection)
				if (item is HinhVuong && ((HinhVuong)item).TinhCV() != max ||
					item is HinhTron && ((HinhTron)item).TinhCV() != max ||
					item is HinhChuNhat && ((HinhChuNhat)item).TinhCV() != max)
					kq.Them(item);

			return kq;
		}

		public DanhSachHinhHoc XoaCacHinhCoCVMin()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float min;
			min = TimCVMin();

			foreach (var item in collection)
				if (item is HinhVuong && ((HinhVuong)item).TinhCV() != min ||
					item is HinhTron && ((HinhTron)item).TinhCV() != min ||
					item is HinhChuNhat && ((HinhChuNhat)item).TinhCV() != min)
					kq.Them(item);

			return kq;
		}

		public void XoaTaiViTri(int vt)
		{
			collection.RemoveAt(vt);
		}

		public void ThemTaiViTri(int vt, int kieu)
		{
			if (kieu == 1)
			{
				HinhVuong hv = new HinhVuong();
				hv.Nhap();
				collection.Insert(vt, hv);
			}
			if (kieu == 2)
			{
				HinhTron ht = new HinhTron();
				ht.Nhap();
				collection.Insert(vt, ht);
			}
			if (kieu == 3)
			{
				HinhChuNhat hcn = new HinhChuNhat();
				hcn.Nhap();
				collection.Insert(vt, hcn);
			}
			Console.WriteLine("Nhap thanh cong!");
		}

		public int DemDoiTuongHinhHoc()
		{
			int count;
			count = 0;

			foreach (var item in collection)
				count -= -1;

			return count;
		}

		public string XuatBangTongHop()
		{
			string str;
			str = "\tBANG TONG HOP THONG TIN\n" +
				$"1) Tong so cac doi tuong hinh hoc: {DemDoiTuongHinhHoc()}\n" +
				$"2) Tong so hinh vuong: {DemSoLuongHinhVuong()}\n" +
				$"3) Tong so hinh tron: {DemSoLuongHinhTron()}\n" +
				$"4) Tong so hinh chu nhat: {DemSoLuongHinhChuNhat()}\n" +
				$"\nA. Danh sach hinh vuong: \n" + SapXepHinhVuongTangTheoDT() +
				$"\n\nB. Danh sach hinh tron: \n" + SapXepHinhTronTangTheoDT() + 
				$"\n\nC. Danh sach hinh chu nhat: \n" + SapXepHinhChuNhatTangTheoDT() +
				$"\n";

			return str;
		}
		
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
			str = "" + SapXepHinhVuongTangTheoDT();

			return str;
		}

		public void GhiDanhSachHinhVuongXuongFile()
		{
			string str;
			str = XuatHinhVuong();

			using (StreamWriter file = new StreamWriter(@"hinhvuong.txt", append: false))
			{
				file.Write(str);
			}
		}

		public string XuatHinhTron()
		{
			string str;
			str = "" + SapXepHinhTronTangTheoDT();

			return str;
		}

		public void GhiDanhSachHinhTronXuongFile()
		{
			string str;
			str = XuatHinhTron();

			using (StreamWriter file = new StreamWriter(@"hinhtron.txt", append: false))
			{
				file.Write(str);
			}
		}

		public string XuatHinhChuNhat()
		{
			string str;
			str = "" + SapXepHinhChuNhatTangTheoDT();

			return str;
		}

		public void GhiDanhSachHinhChuNhatXuongFile()
		{
			string str;
			str = XuatHinhChuNhat();

			using (StreamWriter file = new StreamWriter(@"hinhchunhat.txt", append: false))
			{
				file.Write(str);
			}
		}
	}
}