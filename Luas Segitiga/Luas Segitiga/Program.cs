using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luas_Segitiga
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, t, luas;

            Console.WriteLine("Program Menghitung Luas Segitiga");
            Console.Write("Masukkan alas : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Masukan tinggi : ");
            t = int.Parse(Console.ReadLine());

            luas = a * t / 2;

            Console.WriteLine("Luas segitiga dengan alas " + a + " dan tinggi " + t + " adalah " + luas);
            Console.ReadKey();
        }
    }
}
