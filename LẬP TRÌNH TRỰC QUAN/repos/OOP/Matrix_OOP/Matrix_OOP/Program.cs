using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_OOP
{
    internal class Program
    {
        class Matrix
        {
            private int hang, cot;
            private int[,] A;

            public Matrix(int a, int b)
            {
                hang = a;
                cot = b;
                this.A = new int[a, b];
            }
            // nhap matrix
            public void Nhap()
            {
                Console.Write("Nhap so hang : ");
                hang = int.Parse(Console.ReadLine());
                Console.Write("Nhap so cot : ");
                cot = int.Parse(Console.ReadLine());

                //this.A = new int[hang, cot];

                for (int i = 1; i <= hang; i++)
                {
                    //this.A[i] = new int[i,cot];
                    for (int j = 1; j <= cot; j++)
                    {
                        A[i, j] = new int();
                        Console.Write($"Nhap a[{i}][{j}] : ");
                        this.A[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }
            // xuat matrix
            public void Input()
            {
                Console.WriteLine("Matri : ");
                for (int i = 1; i <= hang; i++)
                {
                    for (int j = 1; j <= cot; j++)
                    {
                        Console.Write(A[i,j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            // cong hai matrix
            public void Tong(Matrix X, Matrix Y)
            {

                if (X.hang == Y.hang && X.cot == Y.cot)
                {
                    Matrix M;
                    Console.WriteLine("Tong A + B la : ");
                    M = new Matrix(X.hang + 1, X.cot + 1);
                    for (int i = 1; i <= X.cot; i++)
                    {
                        for (int j = 1; j <= X.cot; j++)
                        {
                            M.A[i, j] = new int();
                            M.A[i, j] = X.A[i, j] + Y.A[i, j];
                            Console.Write($" {M.A[i, j]}");
                        }
                        Console.WriteLine();
                    }
                    //Console.WriteLine("Tong A + B la : ");
                    //M.Input();
                    
                }
                else
                    Console.WriteLine("Hai MT khong cung cap!");
            }
            // hieu hai MT
            public void Hieu(Matrix Z)
            {
                if (this.hang == Z.hang && this.cot == Z.cot)
                {
                    Matrix M;
                    Console.WriteLine("Tong A - B la : ");
                    M = new Matrix(this.hang + 1, this.cot + 1);
                    for (int i = 1; i <= this.cot; i++)
                    {
                        for (int j = 1; j <= this.cot; j++)
                        {
                            M.A[i, j] = new int();
                            M.A[i, j] = this.A[i, j] - Z.A[i, j];
                            Console.Write($" {M.A[i, j]}");
                        }
                        Console.WriteLine();
                    }
                    //Console.WriteLine("Tong A - B la : ");
                    //M.Input();
                }
                else
                    Console.WriteLine("Hoa MT khong cung cap!");
            }

            // tich hai MT
            public Matrix Tich2MT(Matrix a, Matrix b)
            {
                Matrix c = new Matrix(this.hang+1, this.cot+1);
                if (a.cot != b.hang)
                {
                    Console.Write("\n\t ERROR: Khong thuc hien dc phep nhan !!!");
                }
                else
                {
                    for (int i = 1; i <= this.hang; i++)
                    {
                        for (int j = 1; j <= this.cot; j++)
                        {
                            c.A[i, j] = 0;
                            for (int k = 1; k <= b.hang; k++)
                            {
                                c.A[i, j] += a.A[i, k] * b.A[k, j];
                            }
                            Console.Write($"  {c.A[i, j]}");
                        }
                        Console.WriteLine();
                    }
                        
                }
                return c;
            }

            static void Main(string[] args)
            {
                Matrix M, N, Tich;
                M = new Matrix(4, 5);
                N = new Matrix(4, 5);
                // NHAP MATRIX
                Console.WriteLine("Nhap matrix A : ");
                M.Nhap();
                Console.WriteLine("Nhap matrix B : ");
                N.Nhap();

                // in hai MT
                Console.WriteLine("Matrix A : ");
                M.Input();
                Console.WriteLine("Matrix B : ");
                N.Input();
                
                // cong hai matrix
                M.Tong(M,N);

                //hieu hai MT
                //Console.WriteLine("Tong A - B : ");
                M.Hieu(N);

                //Tich hai MT
                Console.WriteLine("Tich hai MT : ");
                Tich = new Matrix(4, 5);
                Tich = M.Tich2MT(M, N);
                //Tich.Input();
/*                */
                Console.ReadKey();
            }
        }
    }
}

// bug
