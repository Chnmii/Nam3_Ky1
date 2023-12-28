using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2_OOP
{

    internal class Program
    {
        class Phan_So
        {
            private int TuSo;
            private int MauSo;
            
            public Phan_So(int TuSo, int MauSo) 
            {
                this.TuSo = TuSo;
                this.MauSo = MauSo;
            }
            
            public Phan_So()
            {
                TuSo = 0;
                MauSo = 1;
            }
            //nhap phan so
            public void NhapPS()
            {
                Console.Write("Nhap tu : ");
                TuSo = int.Parse(Console.ReadLine());
                Console.Write("Nhap mau : ");
                MauSo = int.Parse(Console.ReadLine());

                //Console.WriteLine();
            }
            //in ps
            public void Input()
            {
                Console.WriteLine($"{TuSo}/{MauSo}");
            }
            //RUT GON PS
            public int USCLN(int a, int b)
            {
                if (a != 0)
                {
                    if (a > 0)
                    {
                        while (a != b)
                        {
                            if (a > b) a -= b;
                            else b -= a;
                        }
                        return a;
                    }
                    else
                    {
                        a = -a;
                        while (a != b)
                        {
                            if (a > b) a -= b;
                            else b -= a;
                        }
                        return a;
                    }
                }
                else return 0;
            }

            public Phan_So Rutgon()
            {
                int s = this.USCLN(this.TuSo, this.MauSo);
                if (s != 0)
                {
                    if (s > 0)
                    {
                        this.TuSo = this.TuSo / s;
                        this.MauSo = this.MauSo / s;
                    }
                    else
                    {
                        this.TuSo = this.TuSo / (-s);
                        this.MauSo = this.MauSo / (s);
                    }
                }
                return this;
            }

            public Phan_So Tong(Phan_So M)
            {
                Phan_So A = new Phan_So();
                A.TuSo = this.TuSo * M.MauSo + this.MauSo * M.TuSo;
                A.MauSo = this.MauSo * M.MauSo;
                A.Rutgon();
                return A;
            }
            public Phan_So Hieu(Phan_So M)
            {
                Phan_So A = new Phan_So();
                A.TuSo = this.TuSo * M.MauSo - this.MauSo * M.TuSo;
                A.MauSo = this.MauSo * M.MauSo;
                A.Rutgon();
                return A;
            }
            public Phan_So Tich(Phan_So M)
            {
                Phan_So A = new Phan_So();
                A.TuSo = this.TuSo * M.TuSo;
                A.MauSo = this.MauSo * M.MauSo;
                A.Rutgon();
                return A;
            }
            public Phan_So Thuong(Phan_So M)
            {
                Phan_So A = new Phan_So();
                A.TuSo = this.TuSo * M.MauSo;
                A.MauSo = this.MauSo * M.TuSo;
                A.Rutgon();
                return A;
            }
        }
        static void Main(string[] args)
        {
            Phan_So A, B;
            A = new Phan_So();
            B = new Phan_So();

            Console.Write("Nhap ps A : ");
            A.NhapPS();
            Console.Write("Nhap ps B : ");
            B.NhapPS();

            Console.WriteLine("Phan so A va B : ");
            A.Input();
            B.Input();

            A.Rutgon();
            B.Rutgon();

            Console.WriteLine("SAU khi rut gon : ");
            Console.Write("Phan so A : ");
            A.Input();
            Console.Write("Phan so B : ");
            B.Input();

            // tinh tong hieu tich thuong
            Phan_So q1, q2, q3, q4;
            q1 = new Phan_So();
            q2 = new Phan_So();
            q3 = new Phan_So();
            q4 = new Phan_So();

            q1 = A.Tong(B);
            q2 = A.Hieu(B);
            q3 = A.Tich(B);
            q4 = A.Thuong(B);


            Console.Write("Tong =");    q1.Input();
            Console.Write("Hieu =");    q2.Input();
            Console.Write("Tich =");    q3.Input();
            Console.Write("Thuong =");  q4.Input();

            Console.ReadKey();
        }
    }
}
