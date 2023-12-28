using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanhoHCN
{
    class HCN
    {
        double cd;
        double cr;

        public void nhap()
        {
            Console.WriteLine("Nhap chieu dai: ");
            cd = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            cr = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.Write("\tcd " + cd.ToString("0.00") + "\tcr " + cr.ToString("0.00"));
        }
        public double Cd
        {
            get { return cd; }
            set { cd = value; }
        }
        public double Cr
        {
            get { return cr; }
            set { cr = value; }
        }
        public double tinhdt()
        {
            return cd * cr;
        }

    }

    class CH
    {
        int maphong;
        HCN kichthuoc;
        public HCN Kichthuoc
        {
            set { kichthuoc = value; }
            get { return kichthuoc; }
        }
        public void nhapch()
        {
            Console.WriteLine("Nhap ma phong: ");
            maphong = int.Parse(Console.ReadLine());
            kichthuoc = new HCN();
            Console.WriteLine("Kich thuoc phong: ");
            kichthuoc.nhap();
        }
        public void xuatch()
        {
            Console.Write("\nma phong:" + maphong.ToString());
            kichthuoc.xuat(); Console.Write("\tdien tich:" + kichthuoc.tinhdt().ToString());
        }
    }

    class CHNew : CH
    {
        string HuongBC;
        
        public string HuongBanCong
        {
            set { HuongBC = value; }
            get { return HuongBC; }
        }
        public void nhapCHNew()
        {
            base.nhapch();
            Console.Write("nhap huong ban cong:"); HuongBC = Console.ReadLine();
        }
        public void xuatCHNew()
        {
            base.xuatch();
            Console.WriteLine("\thuong ban cong:" + HuongBC);
        }
    }

    class DSCanHo
    {
        private int n;
        private CHNew[] A;

        public void NhapDS()
        {
            Console.Write("Nhap so can ho : ");
            n = int.Parse(Console.ReadLine());
            A = new CHNew[n + 1];
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Nhap so can ho {i} : ");
                A[i] = new CHNew();
                A[i].nhapCHNew();
            }
        }
        public void XuatDS()
        {
            for (int i = 1; i <= n; i++)
            {
                A[i].xuatCHNew();
            }
        }
        public void CheckHuong(string M)
        {
            bool kq = false;
            for (int i = 1; i <= n; i++)
            {
                if (M == A[i].HuongBanCong)
                {
                    kq = true;
                    break;
                }
            }
            if (kq == false)
                Console.Write("Het can huong ", M);
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (M == A[i].HuongBanCong)
                        A[i].xuatCHNew();
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DSCanHo A = new DSCanHo();
            A.NhapDS();
            A.XuatDS();

            string huongTk;
            Console.Write("Nhap huong ban cong : ");
            huongTk = Console.ReadLine();
            A.CheckHuong(huongTk);

            Console.ReadKey();

        }
    }
}
