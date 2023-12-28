using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_OOP
{
    internal class Program
    {
        class Diem
        {
            private double x, y;

            public Diem() 
            {
                x = 0; y = 0; 
            }
            public Diem(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            // nhap toa do
            public void Nhap()
            {
                Console.Write("Nhap hoanh do : ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Nhap tung do : ");
                y = int.Parse(Console.ReadLine());
            }
            //xuat tao do
            public void Input()
            {
                Console.WriteLine($"({x},{y})");
            }
            //tinhs khoang cach hai diem
            public double Khoang_Cach(Diem A)
            {
                return Math.Sqrt(Math.Pow(this.x - A.x, 2) + Math.Pow(this.y - A.y, 2));
            }
        }
        static void Main(string[] args)
        {
            Diem diemA = new Diem();
            Diem diemB = new Diem();
            //nhap 2 diem
            diemA.Nhap();
            diemB.Nhap();
            // in hai diem
            diemA.Input();
            diemB.Input();
            // khoang cach hai diem
            Console.WriteLine($"Khong cach A B la : {diemA.Khoang_Cach(diemB)}");
            Console.ReadKey();
        }
    }
}
