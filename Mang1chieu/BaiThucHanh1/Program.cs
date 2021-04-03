using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;


namespace BaiThucHanh1
{
    class Program
    {
        #region thucHanh
        /*static int[] h = new int[100];//Khai bao mang 1 chieu h so nguyen voi kich thuc toi da la 100 phan tu
        static int length = 0;//chieu dai cua mang
        static void Main(string[] args)
        {
            //Nhap();
            NhapNgauNhien();
            Xuat();

            int t = 1;
            Console.Write("\nNhap so can tim : ");
            t = int.Parse(Console.ReadLine());
            int vt = TimViTriDauTien(t);
            Console.WriteLine("Vi tri cua {0} la {1}", t, vt);

            NhapNgauNhien();
            Xuat();

            XoaPhanTuTaiViTri(vt);
            //XoaViTriDauTien(t);
            Xuat();
            Console.ReadKey();
        }
        /*static void Nhap()
        {
           Console.Write("Nhap vao so phan tu cua mang : ");
            length = int.Parse(Console.ReadLine());
           for (int i = 0; i < length; i++)
            {
                Console.Write(" h[{0}] = ", i);
                h[i] = int.Parse(Console.ReadLine());
           }
        }*/

        /*static void XoaViTriDauTien(int t)
         {
             XoaPhanTuTaiViTri(TimViTriDauTien(t));
         }

         static void XoaPhanTuTaiViTri(int vt)
         {
             Console.Write("\nNhap vao phan tu can xoa : ");
             length = int.Parse(Console.ReadLine());
             for (int i = vt; i < length - 1; i++)
             {
                 h[i] = h[i + 1];
             } //tính từ vị trí 0
             length--;
         }
         static void NhapNgauNhien()
         {
             Console.Write("Nhap vao so phan tu cua mang : ");
             length = int.Parse(Console.ReadLine());
             Random n = new Random();
             for (int i = 0; i < length; i++)
             {
                 h[i] = n.Next(100);
             }
         }
         static int TimViTriDauTien(int t)
         {

             for (int i = 0; i < length ; i++)
             {
                 if (h[i] == t)
                     return i;
             }
             return -1;
         }

         static void Xuat()
         {
             Console.Write(" Mang vua nhap la : ");
             for (int i = 0; i < length; i++)
             {
                 Console.Write("\t " + h[i]);
             }
         }*/
        #endregion

        #region TimMax.Min
        /*static void Main (string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                NhapNgauNhien();
                Xuat();
                //int max = TimPhanTuLonNhat();
                //int min = TimPhanTuNhoNhat();


                Console.ReadKey();
            }

                    static void NhapNgauNhien()
            {
                Console.Write("Nhập số phần tử cua mảng : ");
                length = int.Parse(Console.ReadLine());
                Random n = new Random();
                for (int i =0; i <length; i++)
                {
                    h[i] = n.Next(100);
                }

            }
                    /*static int TimPhanTuLonNhat()
            {
                int max = h[0];
                for (int i = 0; i < length; i++)
                {
                    if (max < h[i])
                        max = h[i];

                }
               Console.WriteLine("\nPhần tử lớn nhất là : {0}", max);
                return max;
            }

        static void Xuat()
        {
            Console.Write("Mảng vừa nhập là : ");
            for (int i =0; i < length; i++)
            {
                Console.Write("\t {0}" , h[i]);
            }
        }
    

        static int TimPhanTuNhoNhat()
        {
            int min = h[0];
            for (int i =0; i <length; i++)
            {
                if (min > h[i])
                    min = h[i];
            }
            Console.Write("\nPhần tử nhỏ nhất là : {0}", min);
            return min;
       }




    }*/
}
#endregion
