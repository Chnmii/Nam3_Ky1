using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT6
{
    internal class Program
    {
        class NhanVien
        {
            private String hoten;
            private int namsinh;
            private String diachi;
            private int luongcb;
            private double heso;
            private int phucap;
            private double tongtien;

            public NhanVien() { }

            // nhap  nhan vien
            public void Nhap()
            {
                Console.Write("Nhap ho ten NV : ");
                hoten = Console.ReadLine();
                Console.Write("Nhap nam sinh : ");
                namsinh = int.Parse(Console.ReadLine());
                Console.Write("Nhap dia chi : ");
                diachi = Console.ReadLine();
                Console.Write("Nhap luong co ban : ");
                luongcb = int.Parse(Console.ReadLine());
                Console.Write("Nhap he so luong : ");
                heso = double.Parse(Console.ReadLine());
                Console.Write("Nhap phu cap : ");
                phucap = int.Parse(Console.ReadLine());
                
            }
            // tinh tong luong
            public double Tongluong()
            {
                double tong;
                tong = this.luongcb * this.heso + this.phucap;
                return tong;
            }
            // input thong tin nhan vien
            public void Input()
            {
                Console.WriteLine($"{this.hoten}\t{this.namsinh}\t{this.diachi}\t{this.luongcb}\t{this.heso}\t{this.phucap}\t{this.tongtien}");
            }
        }
        static void Main(string[] args)
        {
            NhanVien nhanVien = new NhanVien();
            // nhap du lieu nhan vien
            nhanVien.Nhap();
            //tinh tong luong
            nhanVien.Tongluong();
            // input thong tin nhan vien
            Console.WriteLine("Thong tin nhan vien : ");
            nhanVien.Input();

            Console.ReadKey();
        }
    }
}
