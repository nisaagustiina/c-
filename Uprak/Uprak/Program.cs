using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uprak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama : Nisa Agustina M");
            Console.ReadLine();

            int a, pil, jml, total;
            Console.Write("Input data : ");
            a = int.Parse(Console.ReadLine());
            int[] b = new int[a];

            for (int c = 0; c < a; c++)
            {
                int q = c + 1;
                Console.WriteLine("Data ke " + q);
                b[c] = int.Parse(Console.ReadLine());
            }
                Console.Clear();
                Console.WriteLine("Operasi Aritmetika");
                Console.WriteLine("1.Tambah |+|");
                Console.WriteLine("2.Kurang |-|");
                Console.WriteLine("3.Kali |*|");
                Console.WriteLine("4.Bagi |/|");
                Console.WriteLine();
                Console.Write("Input pil : ");
                pil = int.Parse(Console.ReadLine());
                Console.Write("Berapa data yang ingin di hitung : ");
                jml = int.Parse(Console.ReadLine());
                Console.WriteLine("Input data mana saja : ");
                int[] n = new int[jml];
                for (int j = 0; j < jml; j++)
                {
                    n[j] = int.Parse(Console.ReadLine());
                    n[j] = n[j] - 1;
                }
                total = b[n[0]];

                if (pil == 1)
                {
                    for (int tambah = 1; tambah < jml; tambah++)
                    {
                        total = total + b[n[tambah]];
                    }
                }
                if (pil == 2)
                {
                    for (int kurang = 1; kurang < jml; kurang++)
                    {
                        total = total - b[n[kurang]];
                    }
                }
                if (pil == 3)
                {
                    for (int kali = 1; kali < jml; kali++)
                    {
                        total = total * b[n[kali]];
                    }
                }
                if (pil == 4)
                {
                    for (int bagi = 1; bagi < jml; bagi++)
                    {
                        total = total / b[n[bagi]];
                    }
                }
                Console.WriteLine("total = " + total);
                Console.ReadLine();
        }
    }
}
