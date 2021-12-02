using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Barang_2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int pegawai, ke, jumlah, pil;
            string id, password;

            Console.WriteLine("----Program Penghitung Stok Barang----");
            Console.WriteLine("===============================================");

            Console.Write("masukan jumlah pegawai : ");
            pegawai = int.Parse(Console.ReadLine());
            Console.WriteLine("========================");

            string[,] Stok = new string[pegawai, 2];
            int[,] barang = new int[pegawai, 3];

            for (jumlah = 0; jumlah < pegawai; jumlah++) ;

            {
                ke = jumlah ;
                Console.WriteLine("Pegawai ke- " + ke);

                for (int i = 0; i <= 1; i++)
                {
                    Console.Write("Masukan Id : ");
                    Stok[jumlah, 0] = String.Intern(Console.ReadLine());
                    Console.Write("Masukan password : ");
                    Stok[jumlah, i] = String.Intern(Console.ReadLine());

                    Console.Write("masukan stok awal barang untuk pegawai " + ke);
                    Console.Write("jumlah smartphone : ");
                    barang[jumlah, 0] = int.Parse(Console.ReadLine());
                    Console.Write("jumlah laptop : ");
                    barang[jumlah, 1] = int.Parse(Console.ReadLine());
                    Console.Write("jumlah pc : ");
                    barang[jumlah, 2] = int.Parse(Console.ReadLine());
                    Console.WriteLine("====================================");
                }
            }
            Console.WriteLine();

            do
            {
                int a = 1;

                Console.Clear();
                do
                {
                    Console.WriteLine("WELKOM");
                    Console.Write("Masukan id : ");
                    id = string.Intern(Console.ReadLine());
                    Console.Write("Masukan password : ");
                    password = string.Intern(Console.ReadLine());

                    for (jumlah = 0; jumlah < pegawai; jumlah++)
                    {

                        if (id == Stok[jumlah, 0])

                        {

                            if (password == Stok[jumlah, 1])
                            {
                                a += 1;
                            }
                        }

                    }
                    if (a == 1)
                    {
                        Console.WriteLine("id atau password yang anda masukan salah");
                        Console.WriteLine("Silahkan ketik enter untuk kembali lagi");
                        Console.ReadLine();
                    }
                }
                while (a == 2);
                {

                    Console.WriteLine("=========================");
                    Console.WriteLine("======================================================");
                    Console.WriteLine("1.Datang Barang");
                    Console.WriteLine("2.Keluar Barang");
                    Console.WriteLine("3.Total Stok");
                    Console.WriteLine("4.Keluar");
                    Console.WriteLine("======================================================");
                    Console.Write("Masukan Pilihan :");
                    pil = Convert.ToInt16(Console.ReadLine());

                    if (pil == 1)
                    {
                        int a1, a2, a3;
                        Console.Write("Masukan jumlah barang datang : ");
                        Console.Write("SmartPhone : ");
                        a1 = Convert.ToInt16(Console.ReadLine());
                        Console.Write(" Laptop : ");
                        a2 = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Laptop : ");
                        a3 = Convert.ToInt16(Console.ReadLine());

                        barang[jumlah, 0] = barang[jumlah, 0] + a1;
                        barang[jumlah, 1] = barang[jumlah, 1] + a2;
                        barang[jumlah, 2] = barang[jumlah, 2] + a3;

                    }
                    if (pil == 2)
                    {
                        int b1, b2, b3;
                        Console.Write("keluar jumlah barang datang : ");
                        Console.Write("SmartPhone : ");
                        b1 = Convert.ToInt16(Console.ReadLine());
                        Console.Write(" Laptop : ");
                        b2 = Convert.ToInt16(Console.ReadLine());
                        Console.Write("PC : ");
                        b3 = Convert.ToInt16(Console.ReadLine());

                        barang[jumlah, 0] = barang[jumlah, 0] - b1;
                        barang[jumlah, 1] = barang[jumlah, 1] - b2;
                        barang[jumlah, 2] = barang[jumlah, 2] - b3;
                    }
                    if (pil == 3)
                    {
                        Console.WriteLine("Total Stok Barang");
                        Console.Write("Smartphone : " + barang[jumlah, 0]);
                        Console.Write("Laptop : " + barang[jumlah, 1]);
                        Console.Write("PC : " + barang[jumlah, 2]);
                    }
                    if (pil == 9) { break; }
                } while (pil != 4) ;
            } while (pil != 9);

        }


    }



}
