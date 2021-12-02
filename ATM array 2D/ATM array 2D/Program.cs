using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_array_2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, r;
            Console.WriteLine();
            Console.Write("Masukan jumlah nasabah : ");
            i = int.Parse(Console.ReadLine());
            int[,] nisa = new int[i, 2];
            Console.ReadLine();

            for (int agt = 0; agt < i; agt++)
            {
                r = agt + 1;
                Console.WriteLine("Nasabah ke " + r);
                Console.Write("Masukan pin : ");
                nisa[agt, 0] = int.Parse(Console.ReadLine());
                for (int s = 1; s <= 1; s++)
                {
                    Console.Write("Masukan saldo : ");
                    nisa[agt, s] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            int a, e, saldo = 0;

            do
            {
                int msr = 1;
                do
                {
                    Console.Clear();
                    Console.WriteLine("WELCOME TO ATM BERKAH");
                    Console.WriteLine(".....................");
                    Console.Write("Masikan pin anda : ");
                    a = int.Parse(Console.ReadLine());

                    for (int rfn = 0; rfn < i; rfn++)
                    {
                        if (a == nisa[rfn, 0])
                        {
                            msr += 1;
                            saldo = rfn;
                            break;
                        }
                    }
                    if (msr == 1)
                    {
                        Console.WriteLine("Pin salah");
                        Console.ReadLine();
                    }
                } while (msr != 2);

                do
                {
                    int q, pil;
                    Console.WriteLine("............WELCOME TO ATM BERKAH..........");
                    Console.WriteLine("1.Cek jumlah saldo");
                    Console.WriteLine("2.Tarik tunai");
                    Console.WriteLine("3.Transfer");
                    Console.WriteLine("4.Keluar");
                    Console.Write("Masukan pilihan anda : ");
                    e = int.Parse(Console.ReadLine());

                    if (e == 1)
                    {
                        Console.WriteLine("----------Cek Saldo----------");
                        Console.WriteLine();
                        Console.WriteLine("Saldo anda salah : " + nisa[saldo, 1]);
                        Console.WriteLine("------------------------------");
                        Console.ReadLine();
                    }
                    else if (e == 2)
                    {
                        Console.WriteLine("----------Tarik tunai-----------");
                        Console.Write("Masukan jumlah yang ingin di tarik : ");
                        q = int.Parse(Console.ReadLine());

                        if (q <= 50000)
                        {
                            Console.WriteLine("Saldo dibawah batas minimum");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Apakah anda yakin ingin menarik tunai sebesar " + q);
                            Console.WriteLine("1.YA");
                            Console.WriteLine("2.TIDAK");
                            Console.Write("Pilihan anda : ");
                            pil = int.Parse(Console.ReadLine());

                            if (pil == 1)
                            {
                                if (q > nisa[saldo, 1])
                                {
                                    Console.WriteLine("Saldo anda kurang");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Tarik tunai berhasil!");
                                    nisa[saldo, 1] = nisa[saldo, 1] - q;
                                    Console.WriteLine("Sisa saldo anda Rp : " + nisa[saldo, 1]);
                                    Console.ReadLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("..........");
                                Console.WriteLine("Tarik tunai di batalkan");
                                Console.WriteLine("..........");
                                Console.ReadLine();
                            }
                        }

                    }
                    else if (e == 3)
                    {
                        int tsf;
                        Console.WriteLine("TRANSFER");
                        Console.Write("Masukan pin yang dituju : ");
                        tsf = int.Parse(Console.ReadLine());
                        Console.Write("Masukan jumlah yang ingin anda transfer : ");
                        q = int.Parse(Console.ReadLine());
                        if (q >= 50000)
                        {
                            Console.WriteLine("Apakah anda yakin ingin transfer sebesar " + q);
                            Console.WriteLine("1.YA");
                            Console.WriteLine("2.TIDAK");
                            Console.Write("Pilihan anda : ");
                            pil = int.Parse(Console.ReadLine());
                            if (pil == 1)
                            {
                                if (q > nisa[saldo, 1])
                                {
                                    Console.WriteLine("Transfer berhasil!");
                                    nisa[saldo, 1] = nisa[saldo, 1] - q;
                                    Console.WriteLine("Sisa saldo anda Rp : " + nisa[saldo, 1]);
                                    Console.ReadLine();
                                }
                            }
                            else if (pil == 2)
                            {
                                Console.WriteLine("..........");
                                Console.WriteLine("Transfer di batalkan");
                                Console.WriteLine("..........");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Pilihan anda salah");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Transfer gagal deposit kurang");
                            Console.ReadLine();
                        }
                    }
                    else if (e == 3)
                    {
                        break;
                    }
                } while (e != 4);
            } while (e != 9);
        }
    }
}
