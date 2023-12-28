using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btn_qlThueXe_OOP
{
    internal class Program
    {
        class Hop_Dong_Thue
        {
            private String Hoten;
            private int gio;
            private String Loai_Xe;
            private int TienThue;

            // ham nhap
            public void Nhap()
            {
                Console.Write("Nhap Ho ten nguoi thue xe : ");
                Hoten = Console.ReadLine();
                Console.Write("Nhap so gio thue xe : ");
                gio = int.Parse(Console.ReadLine());
                Console.Write("Nhap loai xa thue : ");
                Loai_Xe = Console.ReadLine();
            }
            public int Tien_Thue
            {
                get { return TienThue; }
                set { TienThue = value; }
            }
            public void TinhTien()
            {
                if(this.Loai_Xe == "xe du lich")
                {
                    if (this.gio == 1)
                        this.TienThue = 250000;
                    else
                        this.TienThue = 250000 + (this.gio - 1) * 70000;
                }
                if (this.Loai_Xe == "xe tai")
                {
                    if (this.gio == 1)
                        this.TienThue = 250000;
                    else
                        this.TienThue = 220000 + (this.gio - 1) * 85000;
                }
            }
            public void Xuat()
            {
                this.TinhTien();
                Console.WriteLine($"{Hoten}\t|{Loai_Xe}\t|{gio}\t|{TienThue}");
            }

        }
        // clas danh sach
        class DS_ThueXe
        {
            private int n;
            private Hop_Dong_Thue[] A;

            public void Nhap_SD()
            {
                Console.Write("Nhap so luong hop dong thue : ");
                n = int.Parse(Console.ReadLine());
                A = new Hop_Dong_Thue[n + 1];
                for(int i=1; i<=n; i++)
                {
                    Console.WriteLine($"Nhap thong tin cua HD{i} : ");
                    A[i] = new Hop_Dong_Thue();
                    A[i].Nhap();
                }
            }
            public void Xuat_DS()
            {
                for (int i = 1; i <= n; i++)
                {
                    A[i].Xuat();
                }
            }
        }
        static void Main(string[] args)
        {
            DS_ThueXe DS = new DS_ThueXe();
            DS.Nhap_SD();
            DS.Xuat_DS();

            Console.ReadKey();
        }
    }
}
