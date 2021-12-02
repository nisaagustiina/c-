using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_IF_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, p, l, pilih, pilihan;
            double luas, keliling;

            Console.WriteLine("Program hitung hitungan");
            Console.WriteLine("1.Luas");
            Console.WriteLine("2.Keliling");
            Console.WriteLine();

            Console.Write("Masukkan pilihan anda : ");
            pilihan = int.Parse(Console.ReadLine());

            if (pilihan == 1)
            {
                Console.WriteLine("Menghitung luas");
                Console.WriteLine("1.Luas Persegi");
                Console.WriteLine("2.Luas Persegi Panjang");
                Console.WriteLine();

                Console.Write("pilih : ");
                pilih = int.Parse(Console.ReadLine());

                if (pilih == 1)
                {
                    Console.WriteLine("Menghitung Luas Persegi");
                    Console.Write("Masukkan sisi : ");
                    s = int.Parse(Console.ReadLine());

                    luas = s * s;

                    Console.WriteLine("Luas persegi dengan sisi " + s + " adalah " + luas);
                    Console.ReadLine();
                }
                else if (pilih == 2)
                {
                    Console.WriteLine("Menghitung Luas Persegi Panjang");
                    Console.Write("Masukkan panjang : ");
                    p = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan lebar : ");
                    l = int.Parse(Console.ReadLine());

                    luas = p * l;

                    Console.WriteLine("Luas persegi dengan panjang " + p + " dan lebar " + p + " adalah " + luas);
                    Console.ReadLine();
                }
            }
            if (pilihan == 2)
            {
                Console.WriteLine("Menghitung keliling");
                Console.WriteLine("1.Keliling Persegi");
                Console.WriteLine("2.Keliling Persegi Panjang");
                Console.WriteLine();

                Console.Write("pilih : ");
                pilih = int.Parse(Console.ReadLine());

                if (pilih == 1)
                {
                    Console.WriteLine("Menghitung Keliling Persegi");
                    Console.Write("Masukkan sisi : ");
                    s = int.Parse(Console.ReadLine());

                    keliling = 4 * s;

                    Console.WriteLine("Keliling persegi dengan sisi " + s + " adalah " + keliling);
                    Console.ReadLine();
                }
                else if (pilih == 2)
                {
                    Console.WriteLine("Menghitung Keliling Persegi Panjang");
                    Console.Write("Masukkan panjang : ");
                    p = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan lebar : ");
                    l = int.Parse(Console.ReadLine());

                    keliling = 2 * (p + l);

                    Console.WriteLine("Keliling persegi dengan panjang " + p + " dan lebar " + l + " adalah " + keliling);
                    Console.ReadLine();
                }
            }
        }
    }
}
