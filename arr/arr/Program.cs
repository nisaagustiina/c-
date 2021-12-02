using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arr
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Program Kelompok");
            Console.WriteLine();

            Console.Write("Nama Kelompook : ");
            Console.ReadLine();
            Console.Write("Input Jumlah Anggota : ");
            a = Convert.ToInt32(Console.ReadLine());
            string[] nama = new string[a];
            string[] alamat = new string[a];
            Console.WriteLine();

            for (b = 0; b < a; b++)
            {
                int c = b + 1;
                Console.WriteLine("Anggota ke " + c);
                Console.Write("Nama : ");
                nama[b] = Console.ReadLine();
                Console.Write("Alamat : ");
                alamat[b] = Console.ReadLine();
            }

            int d;
            do
            {
                Console.Clear();
                Console.Write("Input No Anggota yang Ingin Dicari : ");
                d = Convert.ToInt32(Console.ReadLine());
                d = d - 1;
                if (d <0) { break; }
                Console.WriteLine("Nama : " + nama[d]);
                Console.WriteLine("Alamat : " + alamat[d]);
                Console.ReadLine();
            }
            while (d >= 0);
        }
    }
}
