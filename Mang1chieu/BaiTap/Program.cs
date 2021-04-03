using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace BaiTap
{
    class Program
    {
        static int[] a = new int[100];
        static int lengthkq = 0;
        static void Main(string[] args)
        {
            NhapNgauNhien();
            Console.WriteLine("Mang vua nhap la : ");
            Xuat(a,lengthkq);

            Console.Write("Cac so am la: ");
            TimTatCaCacSoAm(ref lengthkq);

            Console.Write("\nCac so duong la : ");
            TimTatCaCacSoDuong(ref lengthkq);

            /*Console.WriteLine("\nCac so chan la : ");
            int phanTu = 0;
            int[] kq = TimTatCaCacSoChan(ref phanTu);
            Xuat(kq,phanTu);*/

            

            Console.Write("\nCac so le la : ");
            int phanTu = 0;
            int[] kq = TimTatCaCacSoLe(ref phanTu);
            Xuat(kq, phanTu);

            Console.Write("Cac so nguyen to la : ");
            kq = TimTatCaCacSoNguyenTo(ref phanTu);
             Xuat(kq, phanTu);
            //TimTatCaPhanTuLonHon(ref lengthkq,x);

            Console.ReadKey();
        }


        static void NhapNgauNhien()
        {
            Console.Write("Nhap so phan tu cua mang : ");
            lengthkq = int.Parse(Console.ReadLine());
            Random n = new Random();
            for (int i = 0; i < lengthkq; i++)
            {
                a[i] = n.Next(-100,100);
            }

        }

        static int[] TimTatCaCacSoAm(ref int lengthkq)
        {
            
            for (int i = 0 ; i < lengthkq; i++)
            {

                if (a[i] < 0)
                    Console.Write(a[i]+"\t");         
            }
            return a;
        }

        static int[] TimTatCaCacSoDuong(ref int lengthkq)
        {
            for (int i = 0; i < lengthkq;i++)
            {
                if (a[i] > 0)

                    Console.Write(a[i]+"\t");             
            }
            return a;
        }

        /*static int[] TimTatCaCacSoChan(ref int phanTu)
        {
            int[] kq = new int[100];
            for (int i = 0; i < lengthkq; i++)
            {
                if (a[i] % 2 == 0)
                {
                    kq[phanTu++] = a[i];
                }
                   
            }
            return kq;
        }*/

        static int[] TimTatCaCacSoLe(ref int phanTu)
        {
            int[] kq = new int[100];
            for (int i = 0; i < lengthkq; i++)
            {
                if (a[i] % 2 != 0)
                    kq[phanTu++] = a[i];              
            }
             return kq;
        }
       
        
        #region SoNguyenTo
        static int[] TimTatCaCacSoNguyenTo(ref int phanTu)
        {
            int[] kq = new int[100];
            for (int i =0; i <phanTu; i++)
            {
                if (LaSoNgTo(a[i]))
                kq[phanTu++] = a[i];
            }
            return kq;
        }

        static bool LaSoNgTo(int so)
        {
            if (so <= 1)
                return false;
            for (int i = ; i < so; i++)
             {
                if (so % i == 0)
                    return false;
            }
            return true;
        }
        #endregion

       /* static int[] TimTatCaPhanTuLonHon(ref int lengthkq, int x)
		{
			int[] kq = new int[100];
			for(int i=0;i<length;i++)
				if(a[i]>x)
				{
					kq[lengthkq++] = a[i];
				}
			return kq;
		}
       */


        static void Xuat(int[] h, int phanTu) 
        {
            
            for (int i = 0; i < phanTu; i++)
            {
                Console.Write("\t " + h[i]);
            }
            Console.WriteLine();
        }
    }
}
   
