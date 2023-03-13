using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_1
{
    /// <summary>
    /// Program ini digunakan untuk melakukan pengecekan bilangan ganjil dan genap
    /// </summary>
    class Program
    {
        // Deklarasi variabel dengan tipe data double
        double angka;

        // Membuat method cekbilangan()
        public void cekbilangan()
        {
            // Menampilkan string "Masukkan jumlah bilangan yang akan dicari genap dan ganjilnya:"
            Console.Write("Masukkan jumlah bilangan yang akan dicari genap dan ganjilnya: ");

            // Membaca input user dan mengubah tipe datanya menjadi double 
            angka = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("===========================================");
            Console.WriteLine("Hasil Pencarian Bilangan ganjil dan Genap");
            Console.WriteLine("===========================================");
            Console.WriteLine("");

            // Membuat perulangan "for" dimulai dengan value dari i=0, sampai dengan i <= input dari user
            for (int i = 1; i <= angka; i++)
            {
                // Membuat decision making untuk menentukan modulus
                if (i % 2 == 0)
                {
                    Console.Write("\nBilangan {0} adalah merupakan bilangan genap", i);
                }
                else
                {
                    Console.Write("\nBilangan {0} adalah merupakan bilangan ganjil", i);
                }
            }
        }
        static void Main(string[] args)
        {
            // Deklarasi variabel "jawaban" dengan tipe data string
            string jawaban;

            // Deklarasi variabel "ulang" dengan tipe data int
            int ulang;

            // Membuat objek baru dari class program
            Program p = new Program();

            // Memanggil method cekbilangan() dari class program
            p.cekbilangan();

            Console.WriteLine("\n");
            Console.WriteLine("Apakah ingin mencoba mencari bilangan ganjil dan genap lagi?");

            // Memberikan value untuk variabel "jawaban" dari input user
            jawaban = Console.ReadLine();

            // Membuat kondisi apakah input user berupa karakter 'y' atau 'Y'
            if (jawaban.Equals("y") || jawaban.Equals("Y"))
            {
                Console.WriteLine("Berapa kali anda ingin mengulang pencarian bilangan genap?");

                // Membaca  input user dan mnegubah tipe datanya menjadi int
                ulang = Convert.ToInt32(Console.ReadLine());

                // Membuat perulangan untuk mengulang mencari bilangan genap sebanyak yang diinput user
                while (ulang > 0)
                {
                    // Memanggil method cekbilangan() dari class program
                    p.cekbilangan();
                    Console.WriteLine("\n");
                    // Decrement 1
                    ulang--;
                }
                Console.ReadKey();
            }
        }
    }
}