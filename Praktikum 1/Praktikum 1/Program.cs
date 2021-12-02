using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nl,np,ttl,alamat,no,nr,po;

            Console.WriteLine("BIODATA");
            Console.Write("Nama Lengkap    : ");
            nl = Console.ReadLine();
            Console.Write("Nama Panggilan  : ");
            np = Console.ReadLine();
            Console.Write("TTL             : ");
            ttl = Console.ReadLine();
            Console.Write("Alamat          : ");
            alamat = Console.ReadLine();
            Console.Write("No.HP           : ");
            no = Console.ReadLine();
            Console.Write("Nama Ortu       : ");
            nr = Console.ReadLine();
            Console.Write("Pekerjaan Ortu  : ");
            po = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Assalamualaikum.Let me introduce myself.My name is " +nl + ",but you can call me " +np + ".I was born in " +ttl + ".My parent's name is " +nr + ".Their's job is " +po + ".I'm very glad if you want to invite my house in " +alamat + ".So,don't forgent to call me before with the number " +no + ".Thank you.");
            Console.ReadLine();
        }
    }
}
