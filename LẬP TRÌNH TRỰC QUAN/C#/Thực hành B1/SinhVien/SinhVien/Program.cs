using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    class SV
    {
        private string ht;
        private string nsinh;
        private double dLT;
        private double dCSDL;
        private double dTKW;

        public SV()
        {
            this.ht = "";
            this.nsinh = "";
            this.dLT = 0;
            this.dCSDL = 0;
            this.dTKW = 0;
        }

        public double DLT { get { return this.dLT; } set { this.dLT = value; } }
        public double DCSDL { get { return this.dCSDL; } set { this.dCSDL = value; } }
        public double DTKW { get { return this.dTKW; } set { this.dTKW = value; } }


        public void nhap()
        {
            Console.WriteLine("Nhap ho ten: ");
            ht = Console.ReadLine();
            Console.WriteLine("Ngay sinh: ");
            nsinh = Console.ReadLine();
            Console.WriteLine("Diem mon Lap trinh: ");
            dLT = double.Parse(Console.ReadLine());
            Console.WriteLine("Diem mon Co so du lieu: ");
            dCSDL = double.Parse(Console.ReadLine());
            Console.WriteLine("Diem mon Thiet ke web: ");
            dTKW = double.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine(ht + " | " + nsinh + " | " + dLT + " | " + dCSDL + " | " + dTKW);
        }
        public double DTB()
        {
            return 1.0 * (dLT + dCSDL + dTKW) / 3;
        }
    }

    class DanhSach
    {
        private int n;
        private SV[] a;

        public void nhapds()
        {
            Console.WriteLine("Nhap so sinh vien: ");
            n = int.Parse(Console.ReadLine());
            a = new SV[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = new SV();
                Console.WriteLine("Sinh vien " + (i + 1) + ": ");
                a[i].nhap();
            }
        }

        public void xuatds()
        {
            for (int i = 0; i < n; i++)
            {
                a[i].xuat();
            }
        }

        public void SV_Khoaluan()
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i].DTB() >= 8 && a[i].DLT >= 5 && a[i].DCSDL >= 5 && a[i].DTKW >= 5)
                    a[i].xuat();
            }
        }

        public void SV_CDTN()
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i].DLT >= 5 && a[i].DCSDL >= 5 && a[i].DTKW >= 5)
                    a[i].xuat();
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSach sv;
            sv = new DanhSach();    
            sv.nhapds();

            Console.WriteLine("Danh sach sinh vien lam khoa luan: ");
            sv.SV_Khoaluan();
            Console.WriteLine("Danh sach sinh vien lam chuyen de tot nghiep: ");
            sv.SV_CDTN();

            Console.ReadKey();
        }
    }
}
