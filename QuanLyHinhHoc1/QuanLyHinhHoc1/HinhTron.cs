using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHinhHoc1
{
    class HinhTron : HinhHoc
    {
        public float bKinh;

        public HinhTron()
        {

        }

        public HinhTron(float r)
        {
            bKinh = r;
        }

        public override string KieuHinhHoc()
        {
            return KieuHinhHoc();
        }

        public override float TinhCV()
        {
            return (float)Math.Round(Math.PI * bKinh * 2);
        }

        public override float TinhDT()
        {
            return (float)Math.Round(Math.PI * bKinh * bKinh, 0);
        }

        public override string ToString()
        {
            //return "Hinh tron co ban kinh = " + bKinh + " chu vi = " + TinhCV() + " dien tich = " + TinhDT();
            return string.Format("Hinh tron:\n\t co ban kinh = {0}, chu vi = {1}, dien tich = {2}", bKinh, TinhCV(), TinhDT());
        }
    }
}
