using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm_lieur_pisan
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine();
            Console.Write("Masukkan jumlah nasabah : ");
            x = int.Parse(Console.ReadLine());
            int[,] wulan = new int[x, 2];
            Console.ReadLine();

            for (int marga = 0; marga < x; marga++)
            {
                y = marga + 1;
                Console.WriteLine("nasabah ke " + y);
                Console.Write("Masukkan pin : ");
                wulan[marga, 0] = int.Parse(Console.ReadLine());
                for (int w = 1; w <= 1; w++)
                {
                    Console.Write("Masukan saldo : ");
                    wulan[marga, w] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            int a, u, saldo = 0;


            do
            {
                int retha = 1;
                do
                {
                    Console.Clear();
                    Console.WriteLine("<>WELCOME TO ATM BRI<>");
                    Console.Write("Masukkan pin anda : ");
                    a = int.Parse(Console.ReadLine());

                    for (int beke = 0; beke <= x; beke++)
                    {
                        if (a == wulan[beke, 0])
                        {
                            retha += 1;
                            saldo = beke;
                            break;
                        }
                    }
                    if (retha == 1)
                    {
                        Console.WriteLine("PIN SALAH");
                        Console.ReadLine();
                    }
                } while (retha != 2);

                do
                {

                    int b, pil;
                    Console.WriteLine("***************WELCOME TO ATM BRI************");
                    Console.WriteLine("1.Cek jumlah saldo");
                    Console.WriteLine("2.Tarik Tunai");
                    Console.WriteLine("3.Transfer");
                    Console.WriteLine("4.Quit");
                    Console.WriteLine("*****************************");

                    
                    Console.Write("Masukkan pilihan anda : ");
                    u = int.Parse(Console.ReadLine());

                    if (u == 1)
                    {
                        Console.WriteLine("<<<<<<<<<Cek Saldo<<<<<<<<<<<<");
                        Console.WriteLine();
                        Console.WriteLine("Saldo anda adalah : " + wulan[saldo, 1]);
                        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>.");
                        Console.ReadLine();
                    }
                    else if (u == 2)
                    {
                        Console.WriteLine("<><><><><><>Tarik Tunai<><><><><><><>");
                        Console.Write("Masukkan jumlah uang yang ingin ditarik : ");
                        b = int.Parse(Console.ReadLine());

                        if (b <= 50000)
                        {
                            Console.WriteLine("Saldo dibawah batas minimum");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Apa anda sudah yakin akan menarik tunai sebesar " + b);
                            Console.WriteLine("1.Ya");
                            Console.WriteLine("2.Tidak");
                            Console.Write("Pilihan anda : ");
                            pil = int.Parse(Console.ReadLine());

                            if (pil == 1)
                            {
                                if (b > wulan[saldo, 1])
                                {
                                    Console.WriteLine("Saldo anda kurang");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Tarik tunai berhasil!");
                                    wulan[saldo, 1] = wulan[saldo, 1] - b;
                                    Console.WriteLine("Sisa saldo anda Rp : " + wulan[saldo, 1]);
                                    Console.ReadLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("********");
                                Console.WriteLine("Tarik Tunai Dibatalkan");
                                Console.WriteLine("********");
                                Console.ReadLine();
                            }
                        }

                    }
                    else if (u == 3)
                    {
                        int trans;
                        Console.WriteLine("TRANSFER");
                        Console.Write("Masukkan pin yang dituju : ");
                        trans = int.Parse(Console.ReadLine());
                        Console.Write("Masukan jumlah yang ingin anda transfer : ");
                        b = int.Parse(Console.ReadLine());
                        if (b >= 50000)
                        {
                            Console.WriteLine("Apa anda sudah yakin akan transfer sebesar " + b);
                            Console.WriteLine("1.Ya");
                            Console.WriteLine("2.Tidak");
                            Console.Write("Pilihan anda : ");
                            pil = int.Parse(Console.ReadLine());
                            if (pil == 1)
                            {
                                if (b > wulan[saldo, 1])
                                {
                                    Console.WriteLine("Saldo anda kurang");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Transfer berhasil!");
                                    wulan[saldo, 1] = wulan[saldo, 1] - b;
                                    Console.WriteLine("Sisa saldo anda Rp : " + wulan[saldo, 1]);
                                    Console.ReadLine();
                                }
                            }
                            else if (pil == 2)
                            {
                                Console.WriteLine("********");
                                Console.WriteLine("Transfer Dibatalkan");
                                Console.WriteLine("********");
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
                    else if (u == 9)
                    {
                        break;
                    }
                } while (u != 4);
            } while (u != 9);
        }
    }
}



  
        
    

