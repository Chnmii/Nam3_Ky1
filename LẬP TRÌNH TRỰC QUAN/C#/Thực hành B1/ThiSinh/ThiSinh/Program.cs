using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiSinh
{
    class ThiSinh
    {
        private int sbd;
        private string ht;
        private double m1, m2, m3;

        public ThiSinh()
        {
            this.sbd = 0;
            this.ht = "";
            this.m1 = 0;
            this.m2 = 0;
            this.m3 = 0;
        }

        public void nhap()
        {
            Console.WriteLine("Nhap so bao danh: ");
            sbd = int.Parse(Console.ReadLine());
            Console.WriteLine("Ho ten: ");
            ht = Console.ReadLine();
            Console.WriteLine("Diem m1: ");
            m1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Diem m2: ");
            m2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Diem m3: ");
            m3 = double.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.Write(sbd + " | " + ht + " | " + m1 + " | " + m2 + " | " + m3);
        }

        public double TongDiem()
        {
            return m1 + m2 + m3;
        }
    }

    class TuyenSinh : ThiSinh
    {
        private int kvuc;

        public void nhapts()
        {
            base.nhap();
            Console.WriteLine("Khu vuc: ");
            kvuc = int.Parse(Console.ReadLine());
        }

        public void xuatts()
        {
            base.xuat();
            Console.Write(" | " + kvuc);
        }

        public double Tong()
        {
            return this.TongDiem() + kvuc - 1;
        }
    }

    class DanhSach
    {
        int n;
        TuyenSinh[] a;

        public void nhap()
        {
            Console.WriteLine("Nhap so thi sinh: ");
            n = int.Parse(Console.ReadLine());
            a = new TuyenSinh[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = new TuyenSinh();
                Console.WriteLine("Thi sinh " + (i + 1) + ": ");
                a[i].nhapts();
            }
        }

        public void TrungTuyen(double diem)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i].Tong() >= diem) a[i].xuatts();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSach ts;
            ts = new DanhSach();
            ts.nhap();

            double d;
            Console.WriteLine("Nhap diem chuan: ");
            d = double.Parse(Console.ReadLine());
            Console.WriteLine("Danh sach trung tuyen: ");
            ts.TrungTuyen(d);

            Console.ReadKey();
        }
    }
}
