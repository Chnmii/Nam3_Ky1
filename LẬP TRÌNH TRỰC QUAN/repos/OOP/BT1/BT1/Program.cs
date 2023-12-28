using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BT1

{
    class Sinh_Vien
    {
        //properties
        private string _HoTen;
        private int _NamSinh;
        private double _DiemLT;
        private double _DiemCSDL;
        private double _DiemTKW;
        private double _DiemTB; 
        public Sinh_Vien() { }

        public Sinh_Vien(string hoTen, int namSinh, double diemLT, double diemCSDL, double diemTKW)
        {
            _HoTen = hoTen;
            _NamSinh = namSinh;
            _DiemLT = diemLT;
            _DiemCSDL = diemCSDL;
            _DiemTKW = diemTKW;
        }
        
        // get set
        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        public int NamSinh
        {
            get { return _NamSinh; }    
            set { _NamSinh = value; }
        }
        public double DiemLT
        {
            get { return _DiemLT; }
            set { _DiemLT = value; }
        }
        public double DemCSDL
        {
            get { return _DiemCSDL; }
            set { _DiemCSDL = value; }
        }
        public double DemTKW
        {
            get { return _DiemTKW; }
            set { _DiemTKW = value; }
        }
        public double DiemTB
        {
            get { return _DiemTB; }
            set { _DiemTB = value; }
        }
        public void Nhap()
        {
            Console.Write("Nhap ho ten : ");
            _HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh : ");
            _NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem Lap trinh : ");
            _DiemLT = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem CSDL : ");
            _DiemCSDL = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem TK Web : ");
            _DiemTKW = double.Parse(Console.ReadLine());
        }
       /* */
        public void Print()
        {
            Console.WriteLine($"\t {_HoTen}  \t  { _NamSinh}  \t  { _DiemLT}  \t  { _DiemCSDL}  \t  { _DiemTKW}");
        }
        // tinh diem trung binh
        public double Tinh_DTB()
        {
            _DiemTB = (_DiemLT + _DiemCSDL + _DiemTKW) / 3;
            return _DiemTB;
        }
        // check diem
        public bool Check5()
        {
            if (_DiemLT >= 5 && _DiemCSDL >= 5 && _DiemTKW >= 5)
                return true;
            else
                return false;
        }
    }
    class DS_SV
    {
        private int n;
        private Sinh_Vien[] A;

        public void NhapDS()
        {
            Console.Write("Nhap so SV : ");
            n = int.Parse(Console.ReadLine());
            A = new Sinh_Vien[n];
            for(int i=0; i<n; i++)
            {
                A[i] = new Sinh_Vien();
                A[i].Nhap();
            }
        }
        // xuat danh sach sinh vien
        public void Xuat()
        {
            Console.WriteLine("Danh sach SV : ");
            for(int i=0; i<n; i++)
            {
                A[i].Print();
            }
        }
        // tinh diem trung binh
        public int Khoa_Luan()
        {
            int dem = 0;
            for(int i=0; i<n; i++)
            {
                if (A[i].DiemTB >= 8 && A[i].Check5() == true)
                {
                    dem++;
                }                    
            }
            return dem;
        }
        public int Chuyen_De()
        {
            int dem = 0;
            for(int i=0; i<n; i++)
            {
                if (A[i].Check5() == true)
                    dem++;
            }
            return dem;
        }
    }
    class Sinh_Vien_Tester
    {
        static void Main(string[] args)
        {
            /*
            int n;
            Console.WriteLine("Nhap so sinh vien : ");
            n = int.Parse(Console.ReadLine());
            Sinh_Vien[] A;
            A = new Sinh_Vien[n];
            for(int i=0; i<n; i++)
            {
                A[i] = new Sinh_Vien();
                A[i].Nhap();
            }
            // xuat danh sach
            Console.WriteLine("Danh sach sinh vien");
            for(int i=0; i<n; i++)
            {
                A[i].Print();
            }
            Console.WriteLine();
            */
            DS_SV A = new DS_SV();
            A.NhapDS();
            A.Xuat();
            //in so luong
            Console.WriteLine("So luong SV duoc lam khoa luan : {0}", A.Khoa_Luan());
            Console.WriteLine("So luong SV duoc lam chuyen de : {0}", A.Chuyen_De());
        }
    }
}
