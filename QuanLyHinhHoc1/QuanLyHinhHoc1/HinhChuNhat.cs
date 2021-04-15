using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHinhHoc1
{
    class HinhChuNhat : HinhHoc
    {
        public float chieuDai;
        public float chieuRong;

        public HinhChuNhat()
        {

        }

        public HinhChuNhat(float cd, float cr)
        {
            chieuDai = cd;
            chieuRong = cr;
        }

        public override string KieuHinhHoc()
        {
            return KieuHinhHoc();
        }
        public override float TinhCV()
        {
            return (float)Math.Round((chieuDai + chieuRong) * 2);
        }

        public override float TinhDT()
        {
            return (float)Math.Round(chieuDai * chieuRong);
        }

        public override string ToString()
        {
            //return "Hinh chu nhat co chieu dai = " + chieuDai + " chieu rong = " + chieuRong + " chu vi = "+TinhCV()+" dien tich = " + TinhDT();
            return string.Format("Hinh chu nhat:\n\t co chieu dai = {0}, chieu rong = {1}, chu vi = {2}, dien tich = {3}", chieuDai, chieuRong, TinhCV(), TinhDT());
        }
    }
}
