using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT7_OOP
{
    internal class Program
    {
        class SinhVien
        {
            private int maSV;
            private String HoTen;
            private int NamSinh;
            private double DiemLT;
            private double DiemCSDL;
            private double DiemTB;

            //ham tao co doi va khong doi
            public SinhVien() { }
            public SinhVien(int maSV, string hoTen, int namSinh, double diemLT, double diemCSDL)
            {
                this.maSV = maSV;
                HoTen = hoTen;
                NamSinh = namSinh;
                DiemLT = diemLT;
                DiemCSDL = diemCSDL;
                //DiemTB = diemTB;
            }
            public int MSV()
            {
                return maSV;
            }

            // ham nhap thong tin Sinh vien
            public void Nhap()
            {
                Console.Write("Nhap ma Sv : ");                 
                maSV = int.Parse(Console.ReadLine());
                Console.Write("Nhap ho ten sv : ");             
                HoTen = Console.ReadLine();
                Console.Write("Nhap nam sinh sv : ");           
                NamSinh = int.Parse(Console.ReadLine());
                Console.Write("Nhap diem lap trinh : ");        
                DiemLT = double.Parse(Console.ReadLine());
                Console.Write("Nhap diem co so du lieu ; ");    
                DiemCSDL = double.Parse(Console.ReadLine());
            }

            // ham in thong tin sinh vien ra mh
            public void Input()
            {
                Console.WriteLine($"{maSV}\t{HoTen}\t{NamSinh}\t{DiemLT}\t{DiemCSDL}\t{DiemTB}");
            }
            // ham tinh diem tb cua sinh vien > 8.0
            public double diemTB() {
                this.DiemTB = (this.DiemLT + this.DiemCSDL) / 2;
                return this.DiemTB;
            }
        }

        class DSSV
        {
            private int n;
            private SinhVien[] SV;

            //nhap sd sinh vien
            public void NhapDS()
            {
                Console.Write("Nhpa so luong sinh vien : ");    n = int.Parse(Console.ReadLine());
                SV = new SinhVien[n];
                for(int i=0; i<n; i++)
                {
                    SV[i] = new SinhVien();
                    Console.WriteLine("Nhap thong tin sv[" + i + "] : ");
                    SV[i].Nhap();
                }
            }

            // in ds sinh vien
            public void Input()
            {
                for(int i=0; i<n; i++)
                {
                    SV[i].Input();
                }
            }

            //lietke dtb .. 8.0
            public void Lietke()
            {
                int dem = 0;
                for(int i=0; i<n; i++)
                {
                    if (SV[i].diemTB() >= 8)
                    {
                        dem++;
                        SV[i].Input();
                    }
                }
                if (dem == 0)
                    Console.Write("Khong co sv nao!");
            }
            // sap xep sinh vien theo ma sv
            public void Sapxep()
            {
                for(int i=0; i<n-1; i++)
                {
                    for(int j=i; j<=n-1; j++)
                    {
                        if (SV[i].MSV() > SV[j].MSV())
                        {
                            SinhVien x = SV[i];
                            SV[i] = SV[j];
                            SV[j] = x;
                        }
                    }
                    SV[i].Input();
                }
                SV[n - 1].Input();
            }
        }
        static void Main(string[] args)
        {
            DSSV dSSV = new DSSV();
            dSSV.NhapDS();
            Console.WriteLine("Danh sach sinh vien : ");
            dSSV.Input();
            // liet ke sinh vien co diem b >8.0
            Console.WriteLine("DANH SACH SINH VIEN Co DTB >= 8.0");
            dSSV.Lietke();
            //sapxep ds theo ma sv
            Console.WriteLine("DANH SACH SAU KHI SAP XEP : ");
            dSSV.Sapxep();
            Console.ReadKey();
        }
    }
}
