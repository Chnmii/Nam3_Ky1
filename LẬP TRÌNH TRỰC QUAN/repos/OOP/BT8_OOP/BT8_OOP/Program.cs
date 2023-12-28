using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT8_OOP
{
    internal class Program
    {
        class Sach
        {
            private String MaS;
            private String TenSach;
            private String TenTG;
            private int Soluong;

            public Sach() { }
            public int Soluongsach
            {
                get { return Soluong; }
                set { Soluong = value; }
            }
            public void Nhap()
            {
                Console.Write("Nhap ma sach : ");       MaS = Console.ReadLine();
                Console.Write("Nhap ten sach : ");      TenSach = Console.ReadLine();
                Console.Write("Nhap ten tac gia : ");   TenTG = Console.ReadLine();
                Console.Write("Nhap so luong sach : "); Soluong = int.Parse(Console.ReadLine());
            }
            public void Input()
            {
                Console.Write($"\n{MaS}\t{TenSach}\t{TenTG}\t{Soluong}");
            }
        }

        class NewSACH : Sach
        {
            private String Qrcode;

            public NewSACH() { }
            public NewSACH(string qrcode)
            {
                Qrcode = qrcode;
            }
            public string QRcode
            {
                get { return Qrcode; }
                set { Qrcode = value; }
            }
            // nhap 
            public void Nhapnew()
            {
                this.Nhap();
                Console.Write("Nhap ma Qrcode : ");
                Qrcode = Console.ReadLine();
            }
            // xuat 
            public void Inputnew()
            {
                this.Input();
                Console.Write($"\t{Qrcode}");
            }

        }
        class DS_Sach
        {
            private int n;
            private NewSACH[] sach;

            public void nhapds()
            {
                Console.Write("Nhap so luong sach : ");
                n = int.Parse(Console.ReadLine());
                sach = new NewSACH[n];
                for(int i=0; i<n; i++)
                {
                    sach[i] = new NewSACH();
                    sach[i].Nhapnew();
                }
            }
            // xuat
            public void Input()
            {
                for(int i=1; i<n; i++)
                {
                    sach[i].Inputnew();
                }
            }

            // check
            public void Check(String x)
            {
                int dem = 0, m = 0;
                for(int i=0; i<n; i++)
                {
                    if (sach[i].QRcode == x)
                    {
                        dem++;
                        m = sach[i].Soluongsach;
                    }
                }
                if(dem == 0)
                {
                    Console.Write("=> Khong co sach co ma QR : " + x);
                    return;
                }
                else
                {
                    if (m != 0)
                    {
                        Console.Write("=> Con " + m + " sach " + x);
                    }
                    else
                        Console.Write("=> Khong con sach!");
                    
                    return;
                }
            }
        }
        static void Main(string[] args)
        {
            DS_Sach A = new DS_Sach();
            A.nhapds();

            // check ma qr
            string maqr;
            Console.Write("\nNhap ma QR can check : "); maqr = Console.ReadLine();
            A.Check(maqr);

            Console.ReadKey();
        }
    }
}
