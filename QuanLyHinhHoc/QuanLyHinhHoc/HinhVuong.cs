using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHinhHoc
{
    class HinhVuong : HinhHoc
    {

        public float canh;

        public HinhVuong()
        {
        }

        public HinhVuong(float c)
        {
            canh = c;
        }

        public override float TinhCV()
        {
            return (float)Math.Round(canh * 4);
        }

        public override float TinhDT()
        {
            return (float)Math.Round(canh * canh, 0);
        }

        public override string ToString()
        {
            //return "Hinh vuong co canh = " + canh + " chu vi = "+ TinhCV()+ " dien tich = " + TinhDT();
            return string.Format("Hinh vuong:\n\t co canh = {0}, chu vi = {1}, dien tich = {2}", canh, TinhCV(), TinhDT());
        }
    }
}
