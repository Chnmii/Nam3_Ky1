using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Vidu1_CanHo_OOP
{
    internal class Program
    {
        class HCN
        {
            private double cd, cr;
            public void nhap()
            {
                Console.Write("Nhap chieu dai : ");
                cd = double.Parse(Console.ReadLine());
                Console.Write("Nhap chieu rong : ");
                cr = double.Parse(Console.ReadLine());
            }
            public void xuat()
            {
                Console.Write("\t|cd " + cd.ToString("0.00") + "\t|cr " + cr.ToString("0.00"));
            }
            public double Cd
            {
                get { return Cd; }
                set { Cd = value; }
            }
            public double Cr
            {
                get { return Cr; }
                set { Cr = value; }
            }
            public double TinhDT()
            {
                return cd * cr;
            }
        }

        class CanHo
        {
            private int MaPhong;
            private HCN kichthuoc;
            public HCN KichThuoc
            {
                get { return kichthuoc; }
                set { kichthuoc = value; }
            }
            public int Maphong
            {
                get { return MaPhong; }
                set { MaPhong = value; }
            }
            public void nhapch()
            {
                Console.Write("Nhap ma phong : ");
                MaPhong = int.Parse(Console.ReadLine());
                kichthuoc = new HCN();
                kichthuoc.nhap();
            }
            public void xuatch()
            {
                Console.Write("\t|ma phong " + MaPhong.ToString());
                kichthuoc.xuat();
                Console.Write("\t|dien tich " + kichthuoc.TinhDT().ToString());
            }
            // CLASS Can Ho moi co huong ban cong
            class CanHoNew : CanHo
            {
                private string HuongBC;
                /*public CanHoNew() : base()
                {
                    HuongBC = "Huong Nam";
                }*/
                public string huongbc
                {
                    get { return HuongBC; }
                    set { HuongBC = value; }
                }
                public void nhapCHNew()
                {
                    this.nhapch();
                    Console.Write("nhap huong ban cong:"); HuongBC = Console.ReadLine();
                }
                public void xuatCHNew()
                {
                    this.xuatch();
                    Console.WriteLine("\t|huong ban cong " + HuongBC);
                }

            }
            // danh sach can ho
            class DSCanHo
            {
                private int n;
                private CanHoNew[] A;

                public void NhapDS()
                {
                    Console.Write("Nhap so can ho : ");
                    n = int.Parse(Console.ReadLine());
                    A = new CanHoNew[n+1];
                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine($"Nhap so can ho {i} : ");
                        A[i] = new CanHoNew();
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
                        if (M == A[i].huongbc)
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
                            if (M == A[i].huongbc)
                                A[i].xuatCHNew();
                        }
                    }
                }
            }

            static void Main(string[] args)
            {
                /*
                CanHoNew hn = new CanHoNew();
                hn.nhapCHNew();
                hn.xuatCHNew();
                */
                DSCanHo A = new DSCanHo();
                A.NhapDS();
                A.XuatDS();

                // check
                string huongTk;
                Console.Write("Nhap thiet ke : ");
                huongTk = Console.ReadLine();
                A.CheckHuong(huongTk);
                

                Console.ReadKey();
            }
        }
    }
}
