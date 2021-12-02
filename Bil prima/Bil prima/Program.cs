using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_prima
{
    class Program
    {
        static void Main(string[] args)
        {
            int bil, ulang, sisa, jml=0;
            string ket;
            Console.Write("Masukan bil : ");
            bil = int.Parse(Console.ReadLine());

            for (ulang = 1; ulang <= bil; ulang++)
            {
                sisa = bil % ulang;
                if (sisa == 0)
                    jml = jml + 1;
                else
                    jml = jml + 0;
            }
            if (jml > 2)
                ket = " bukan bil prima ";
            else
                 ket = " bil prima ";
            Console.WriteLine("Bil yg diinput : " + ket);
            Console.ReadLine();
        }
    }
}
