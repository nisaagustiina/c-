using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luas_Lingkaran_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            double luas;

            Console.WriteLine("Program Menghitung Luas Lingkaran");
            Console.Write("Masukan jari-jari : ");
            r = int.Parse(Console.ReadLine());

            luas = 3.14 * r * r;

            Console.WriteLine("Luas lingkaran dengan jari-jari " + r + " adalah " + luas);
            Console.ReadKey();
        }
    }
}
