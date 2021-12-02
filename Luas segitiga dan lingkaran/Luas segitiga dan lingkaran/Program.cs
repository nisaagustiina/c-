using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luas_segitiga_dan_lingkaran
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, t, r, pilihan;
            double luas;

            Console.WriteLine("Program hitung hitungan");
            Console.WriteLine("1.Luas Segitiga");
            Console.WriteLine("2.Luas Lingkaran");
            Console.WriteLine();

            Console.Write("Masukkan pilihan anda : ");
            pilihan = int.Parse(Console.ReadLine());
            if (pilihan == 1)
            {
                Console.WriteLine("Program Menghitung Luas Segitiga");
                Console.Write("Masukkan alas : ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Masukkan tinggi : ");
                t = int.Parse(Console.ReadLine());

                luas = a * t / 2;

                Console.WriteLine("Luas segitiga dengan alas " + a + " dan tinggi " + t + " adalah " + luas);
                Console.ReadKey();
            }
            else if (pilihan == 2)
            {
                Console.WriteLine("Program Menghitung Luas Lingkaran");
                Console.Write("Masukkan jari-jari : ");
                r = int.Parse(Console.ReadLine());

                luas = 3.14 * r * r;

                Console.WriteLine("Luas lingkaran dengan jari-jari " + r + " adalah " + luas);
                Console.ReadKey();
            }
        }
    }
}
