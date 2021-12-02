using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPRAK.PEMDAS.XRPL2NISA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama : Nisa Agustina Maesaroh");
            Console.ReadLine();
            int a, b;
            Console.WriteLine("Bil mana yang lebih besar ");
            do
            {
            Console.Write("Input bil a : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input bil b : ");
            b = int.Parse(Console.ReadLine());

                if (a < b)
                {
                    Console.WriteLine("Bil a lebih kecil dari b");
                    Console.ReadLine();
                }
                if(b == 99)
                { break; }
                else
                {
                    Console.Write("Bil b lebih besar dari a");
                    Console.ReadLine();
                }
            }
            while (b != 99);
            Console.ReadKey();

        }
    }
}
