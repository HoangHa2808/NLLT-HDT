using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace QuanLyDanhBa
{
    enum GioiTinh
    {
        Nam =1,
        Nu
    }

    class ThueBao
    {
        public string soCMND;
        public string hoTen;
        public string diaChi;
        public GioiTinh gioiTinh;
        public DateTime ngaySinh;
        public string sDT;


        public ThueBao()
        {

        }

        public ThueBao(string soCMND, string hoTen, string diaChi, GioiTinh gioiTinh, DateTime ngaySinh, string sDT)
        {
            this.soCMND = soCMND;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.sDT = sDT;
        }

        public ThueBao(string line)
        {
            string[] s = line.Split(',');
            this.soCMND = s[0].Trim();
            this.hoTen = s[1].Trim();
            this.diaChi = s[2].Trim();
            this.gioiTinh = s[3].Trim() == "Nam" ? GioiTinh.Nam : GioiTinh.Nu;
            this.ngaySinh = DateTime.Parse(s[4]);
            this.sDT = s[5].Trim();
        }

        public void Xuat()
        {          
            Console.WriteLine("{0} {1} {2} {3} {4} {5}",soCMND, hoTen, diaChi, gioiTinh, ngaySinh, sDT);
        }

        public override string ToString()
        {
            string s ="{0} {1} {2} {3} {4} {5}\n";
            return string.Format(s,soCMND.PadRight(7), hoTen.PadRight(20), diaChi.PadRight(40), ngaySinh.ToShortDateString().PadRight(11), sDT.PadRight(11), gioiTinh);
        }
    }


}
