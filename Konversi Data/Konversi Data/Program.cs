using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konversi_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            int p;
            float b, B, Kb, KB, Mb, MB;

            Console.WriteLine("PROGRAM KONVERSI DATA");
            Console.WriteLine("Satuan data : ");
            Console.WriteLine("1. Bit");
            Console.WriteLine("2. Byte");
            Console.WriteLine("3. KiloBit");
            Console.WriteLine("4. KiloByte");
            Console.WriteLine("5. MegaBit");
            Console.WriteLine("6. MegaByte");
            Console.WriteLine();

            Console.Write("Pilih satuan : ");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (p == 1)
            {
                Console.WriteLine("Program koversi bit");
                Console.Write("Masukkan bilangan : ");
                b = float.Parse(Console.ReadLine());

                B = b * 8;
                Console.WriteLine(b + " Bit Adalah " + B + " Byte");
                Kb = b / 1024;
                Console.WriteLine(b + " Bit Adalah " + Kb + " KiloBit ");
                KB = B / 1024;
                Console.WriteLine(b + " Bit Adalah " + KB + " KiloByte ");
                Mb = b / 1024;
                Console.WriteLine(b + " Bit Adalah " + Mb + " MegaBit ");
                MB = B / 1024;
                Console.WriteLine(b + " Bit Adalah " + Kb + " MegaByte ");
            }
            if (p == 2)
            {
                Console.WriteLine("Program koversi byte");
                Console.Write("Masukkan bilangan : ");
                B = float.Parse(Console.ReadLine());

                b = B / 8;
                Console.WriteLine(B + " Byte Adalah " + b + " Bit");
                Kb = b / 1024;
                Console.WriteLine(B + " Byte Adalah " + Kb + " KiloBit ");
                KB = B / 1024;
                Console.WriteLine(B + " Byte Adalah " + KB + " KiloByte ");
                Mb = b / 1024;
                Console.WriteLine(B + " Byte Adalah " + Mb + " MegaBit ");
                MB = B / 1024;
                Console.WriteLine(B + " Byte Adalah " + Kb + " MegaByte ");
            }
            if (p == 3)
            {
                Console.WriteLine("Program koversi Kilobit");
                Console.Write("Masukkan bilangan : ");
                Kb = float.Parse(Console.ReadLine());

                b = Kb * 1024;
                Console.WriteLine(Kb + "  KiloBit Adalah " + b + " Bit ");
                B = b * 8;
                Console.WriteLine(Kb + " KiloBit Adalah " + B + " Byte ");
                KB = B / 1024;
                Console.WriteLine(Kb + " KiloBit Adalah " + KB + " KiloByte ");
                Mb = b / 1024;
                Console.WriteLine(Kb + " KiloBit Adalah " + Mb + " MegaBit ");
                MB = B / 1024;
                Console.WriteLine(Kb + " KiloBit Adalah " + Kb + " MegaByte ");
            }
            if (p == 4)
            {
                Console.WriteLine("Program koversi Kilobyte");
                Console.Write("Masukkan bilangan : ");
                KB = float.Parse(Console.ReadLine());

                b = KB * 1024 / 8;
                Console.WriteLine(KB + " KiloByte Adalah " + b + " Bit ");
                B = b * 8;
                Console.WriteLine(KB + " KiloByte Adalah " + B + " Byte ");
                Kb = KB / 1024;
                Console.WriteLine(KB + " KiloByte Adalah " + Kb + " KiloBit ");
                Mb = Kb / 1024;
                Console.WriteLine(KB + " KiloByte Adalah " + Mb + " MegaBit ");
                MB = KB / 1024;
                Console.WriteLine(KB + " KiloByte Adalah " + MB + " MegaByte ");
            }
            if (p == 5)
            {
                Console.WriteLine("Program koversi Megabit");
                Console.Write("Masukkan bilangan : ");
                Mb = float.Parse(Console.ReadLine());

                b = Mb * 1024 * 1024;
                Console.WriteLine(Mb + " MegaBit Adalah " + b + " Bit ");
                B = b * 8;
                Console.WriteLine(Mb + " MegaBit Adalah " + B + " Byte ");
                Kb = b / 1024;
                Console.WriteLine(Mb + " MegaBit Adalah " + Kb + " KiloBit ");
                KB = B / 1024;
                Console.WriteLine(Mb + " MegaBit Adalah " + KB + " KiloByte ");
                MB = KB / 1024;
                Console.WriteLine(Mb + " MegaBit Adalah " + MB + " MegaByte ");
            }
            if (p == 6)
            {
                Console.WriteLine("Program koversi Megabyte");
                Console.Write("Masukkan bilangan ");
                MB = float.Parse(Console.ReadLine());

                b = MB * 1024 * 1024 / 8;
                Console.WriteLine(MB + " MegaByte Adalah " + b + " Bit ");
                B = b * 8;
                Console.WriteLine(MB + " MegaByte Adalah " + B + " Byte ");
                Kb = b / 1024;
                Console.WriteLine(MB + " MegaByte Adalah " + Kb + " KiloBit ");
                KB = B / 1024;
                Console.WriteLine(MB + " MegaByte Adalah " + MB + " KiloByte ");
                Mb = KB / 1024;
                Console.WriteLine(MB + " MegaByte Adalah " + Mb + " MegaBit ");
            }
            else
            {

            }
            Console.ReadKey();
        }
    }
}
