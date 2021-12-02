using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pengulangan
{
    class Program
    {
        static void Main(string[] args)
        {
            int lari;
            lari = 0;
            while (lari <= 10)
            {
                Console.WriteLine(" keliling ke " + lari);
                lari++;
            }
            Console.ReadKey();
        }
    }
}
