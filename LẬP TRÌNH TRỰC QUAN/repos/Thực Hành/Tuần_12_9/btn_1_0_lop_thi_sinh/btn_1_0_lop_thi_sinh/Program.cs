using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btn_1_0_lop_thi_sinh
{
    internal class Program
    {
        class ThiSinh
        {
            private String sbd;
            private String Hoten;
            private double m1, m2, m3;

            public ThiSinh() { }

            // ham nhap
            public void Nhap()
            {
                Console.Write("Nhap so bao danh : ");    sbd = Console.ReadLine();
                Console.Write("Nhap ho ten : ");            Hoten = Console.ReadLine();
                Console.Write("Nhap diem m1 : ");     
                m1 = double.Parse(Console.ReadLine());
                Console.Write("Nhap diem m2 : ");
                m2 = double.Parse(Console.ReadLine());
                Console.Write("Nhap diem m3 : ");
                m3 = double.Parse(Console.ReadLine());
            }

            //ham xuat
            public void Xuat()
            {
                Console.Write($"{sbd}\t{Hoten}\t{m1}\t{m2}\t{m3}");
            }
            // tinh tong diem
            public Double Tong()
            {
                return m1 + m2 + m3;
            }
        }

        // class lop tuyen sinh
        class Tuyen_Sinh : ThiSinh
        {
            private int khuvuc;

            public void NhapTS()
            {
                this.Nhap();
                Console.Write("Nhap khu vuc : ");
                khuvuc = int.Parse(Console.ReadLine());
            }
            public void XuatTS()
            {
                this.Xuat();
                Console.Write($"\t{khuvuc}");
            }
            public double TongDiem()
            {
                return this.Tong() + khuvuc - 1;
            }

        }
        // class danh sach
        class DS_ThiSinh
        {
            private int n;
            Tuyen_Sinh[] A;

            // nhap danh sach
            public void NhapDS()
            {
                Console.Write("Nhap so thi thi sinh :");
                n = int.Parse(Console.ReadLine());
                A = new Tuyen_Sinh[n+1];
                for(int i=1; i<=n; i++)
                {
                    A[i] = new Tuyen_Sinh();
                    
                    A[i].NhapTS();
                }
            }
            // ham xuat
            public void XuatDS()
            {
                for(int i=1; i<=n; i++)
                {
                    A[i].XuatTS();
                    //Console.Write($"\t||{A[i].TongDiem()}");
                    Console.WriteLine();
                }
            }
            public void TrungTuyen(double M)
            {
                int dem = 0;
                for(int i=1; i<=n; i++)
                {
                    if (A[i].TongDiem() >= M)
                    {
                        dem++;
                        A[i].XuatTS();
                        Console.WriteLine();
                    }
                }
                if (dem == 0)
                    Console.WriteLine("Khong co thi sinh trung tuyen !");
            }
        }
        static void Main(string[] args)
        {
            DS_ThiSinh A = new DS_ThiSinh();
            A.NhapDS();
            A.XuatDS();
            //nhap diem chuan
            double DiemChuan;
            Console.Write("Nhap diem chuan : ");
            DiemChuan = double.Parse(Console.ReadLine());
            A.TrungTuyen(DiemChuan);
            //
            Console.ReadKey();
        }
    }
}
