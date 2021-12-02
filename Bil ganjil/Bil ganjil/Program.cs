using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_ganjil
{
    class Program
    {
        static void Main(string[] args)
        {
            int bil, a, b, c;
            a = 1;
            b = 0;
            c = 0;

            Console.WriteLine("PROGRAM BILANGAN GANJIL");
            Console.Write("Masukkan bilangan : ");
            bil = int.Parse(Console.ReadLine());
            while ( a <= bil )
            {
                Console.Write(a);
                a = a + 2;
                c = c + a;
                b++;
                Console.WriteLine();
            }
            Console.WriteLine("Jumlah bilangan ganjil dari " + bil + " adalah " + b);
            Console.WriteLine("Jumlah bilangan ganjil tersebut bila dijumlahkan adalah " + c);
            Console.ReadKey();
        }
    }
}
