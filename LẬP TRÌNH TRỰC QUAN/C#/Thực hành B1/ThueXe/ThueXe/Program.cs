using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThueXe
{
    class ThueXe
    {
        private string HT;
        private int SoGio;
        private string LoaiXe;

        public ThueXe()
        {
            this.HT = "";
            this.SoGio = 0;
            this.LoaiXe = "";
        }

        public string ht { get; set; }
        public int sogio { get; set; }
        public string loai { get; set; }

        public void nhap()
        {
            Console.WriteLine("Nhap ho ten nguoi thue: ");
            HT = Console.ReadLine();
            Console.WriteLine("So gio thue: ");
            SoGio = int.Parse(Console.ReadLine());
            Console.WriteLine("Loai xe thue: ");
            LoaiXe = Console.ReadLine();
        }
        public int Tongtien()
        {
            if (LoaiXe == "xe du lich")
            {
                return 250000 + ((SoGio - 1) * 70000);
            }
            if (LoaiXe == "xe tai")
            {
                return 220000 + ((SoGio - 1) * 85000);
            }
            else
            {
                return 0;
            }
                
        }
        public void xuat()
        {
            Console.WriteLine(HT + " | " + SoGio + " | " + LoaiXe + " | " + this.Tongtien());
        }

        
    }

    class DS_TX
    {
        private int n;
        private ThueXe[] a;

        public void nhapds()
        {
            Console.WriteLine("Nhap so nguoi thue: ");
            n = int.Parse(Console.ReadLine());
            a = new ThueXe[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = new ThueXe();
                Console.WriteLine("Nguoi thue " + (i + 1) + ": ");
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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DS_TX ds;
            ds = new DS_TX();
            ds.nhapds();
            ds.xuatds();

            Console.ReadKey();
        }
    }
}
