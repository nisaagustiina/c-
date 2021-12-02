using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warteg
{
    class Program
    {
        static void Main(string[] args)
        {
            int np, pesan, uang, harga, kembalian;
            string nama;
            int mb = 25000, ng = 20000, aj = 15000;
            Console.Write("Input Nama : ");
            nama = Console.ReadLine();

            do
            {
                Console.WriteLine();
                Console.WriteLine("Program Rumah Makan");
                Console.WriteLine();
                Console.WriteLine("Welcome to RM Amanah");
                Console.WriteLine("1.mie baso Rp.25000");
                Console.WriteLine("2.nasgor Rp.20000"); 
                Console.WriteLine("3.all varian jus Rp.15000");
                Console.Write("Input pilihan anda : ");
                np = int.Parse(Console.ReadLine());
                
                if (np == 1)
                {
                    Console.WriteLine();
                    Console.Write("Input jml pesanan : ");
                    pesan = int.Parse(Console.ReadLine());
                    harga = pesan * mb;
                    Console.WriteLine("Total Harga : " + harga);
                    Console.Write("Input jml uang : ");
                    uang = int.Parse(Console.ReadLine());
                    kembalian = uang - harga;
                    Console.Write("Kembali sebesar : " + kembalian);
                    Console.ReadLine();
                }
                if (np == 2)
                {
                    Console.WriteLine();
                    Console.Write("Input jml pesanan : ");
                    pesan = int.Parse(Console.ReadLine());
                    harga = pesan * ng;
                    Console.WriteLine("Total Harga : " + harga);
                    Console.Write("Input jml uang : ");
                    uang = int.Parse(Console.ReadLine());
                    kembalian = uang - harga;
                    Console.Write("Kembali sebesar : " + kembalian);
                    Console.ReadLine();
                }
                if (np == 3)
                {
                    Console.WriteLine();
                    Console.Write("Input jml pesanan : ");
                    pesan = int.Parse(Console.ReadLine());
                    harga = pesan * aj;
                    Console.WriteLine("Total Harga : " + harga);
                    Console.Write("Input jml uang : ");
                    uang = int.Parse(Console.ReadLine());
                    kembalian = uang - harga;
                    Console.Write("Kembali sebesar : " + kembalian);
                    Console.ReadLine();
                }
                if (np == 4) { break; }
            }
            while (np != 9);
             }
    }
}
