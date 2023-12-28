using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BT4_OOP
{
    internal class Program
    {
        class Mang
        {
            private int n;
            private double[] A;

            public Mang() { }

            public void Nhap()
            {
                Console.Write("Nhap so phan tu : ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap mang");
                A = new double[n];
                for(int i=0; i<n; i++)
                {
                    A[i] = new double();
                    Console.Write("Nhap A[{0}] : ", i);
                    A[i] = double.Parse(Console.ReadLine());
                }
            }
            public void Input()
            {
                Console.Write("Mang : ");
                for(int i=0; i<n; i++)
                {
                    Console.Write("\t{0}", A[i]);
                }
            }
            public void Sapxep(int m)
            {
                for(int i=0; i<n-1; i++)
                {
                    for(int j=i+1; j<n; j++)
                    {
                        if (A[i] > A[j])
                        {
                            double x = A[i];
                            A[i] = A[j];
                            A[j] = x;
                        }
                    }
                }
                if (m == 1)
                {
                    for(int i=n-1; i>=0; i--)
                    {
                        Console.Write("\t{0}", A[i]);
                    }
                }
                else if(m==0)
                    this.Input();
            }

            public int Timkiem(double x)
            {
                int dem = 0;
                for(int i=0; i<n; i++)
                {
                    if (A[i] == x)
                        dem++;
                }
                return dem;
            }
            public int TimKiem(double x)
            {
                int vtri = -1;
                for (int i = 0; i < n; i++)
                {
                    if (A[i] == x)
                    {
                        vtri = i;
                        break;
                    }
                }
                return vtri;
            }
        }
        static void Main(string[] args)
        {
            Mang mang = new Mang();
            mang.Nhap();
            mang.Input();

            // sap xep theo yeu cau
            int sx;
            Console.Write("\nNhap 0 (tang dan) hoac 1(giam dan) : ");
            sx = int.Parse(Console.ReadLine());
            mang.Sapxep(sx);

            //tim kiem phan tu
            double x;
            Console.Write("\nNhap gia tri can tim : ");
            x = double.Parse(Console.ReadLine());
            //Console.Write("So phan tu co gia tri bang {0} la : {1}",x, mang.Timkiem(x));
            Console.Write("ket qua vi tri cua {0} la : {1}", x, mang.TimKiem(x));

            Console.ReadKey();
        }
    }
}
