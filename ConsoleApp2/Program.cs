using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMenghitungBangunRuang
{
    /// <summary>
    /// Kubus
    /// </summary>
    /// <remarks>Class kubus dapat menghitung volume kubus</remarks>
    public class Kubus
    {
        /// <summary>
        /// Menghitung Volume Kubus
        /// </summary>
        /// <param name="s">sisi</param>
        /// <returns>Volume Kubus</returns>
        public double sisi;

        public void sisiKubus()
        {
            Console.Write("Masukkan sisi = ");
            sisi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan sisi = ");
            sisi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan sisi = ");
            sisi = Convert.ToDouble(Console.ReadLine());
        }

        public double VolumeKubus(double s)
        {
            return s * s * s;
        }

        public void tampilKubus()
        {
            Console.WriteLine("Volume Kubus = " + this.VolumeKubus(sisi));
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Balok
    /// </summary>
    /// <remarks>Menghitung volume balok</remarks>

    public class Balok
    {
        /// <summary>
        /// Menghhitung volume Balok
        /// </summary>
        /// <param name="p">Panjang</param>
        /// <param name="l">Lebar</param>
        /// <param name="t">Tinggi</param>
        /// <returns>Volume Balok</returns>
 
        public double panjang, lebar, tinggi;
        public void sisiBalok()
        {
            Console.Write("Masukkan panjang = ");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan lebar = ");
            lebar = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan tinggi = ");
            tinggi = Convert.ToDouble(Console.ReadLine());
        }

        public double VolumeBalok(double p, double l, double t)
        {
            return p * l * t;
        }

        public void tampilBalok()
        {
            Console.WriteLine("Volume Balok = " + this.VolumeBalok(panjang, lebar, tinggi));
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Prisma Segitiga
    /// </summary>
    /// <remarks>Menghitung volume prisma segitiga</remarks>

    public class PrismaSegitiga
    {
        /// <summary>
        /// Menghitung volume balok
        /// </summary>
        /// <param name="la">luas alas</param>
        /// <param name="t">tinggi</param>
        /// <returns>Volume prisma segitiga</returns>
        public double luasAlas, tinggi;
        public void sisiPrismaSegitiga()
        {
            Console.Write("Masukkan luas alas = ");
            luasAlas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan tinggi = ");
            tinggi = Convert.ToDouble(Console.ReadLine());
        }
        public double VolumePrismaSegitiga(double la, double t)
        {
            return la * t;
        }

        public void tampilPrismaSegitiga()
        {
            Console.WriteLine("Volume Prisma Segitiga = " + this.VolumePrismaSegitiga(luasAlas, tinggi)); 
            Console.ReadKey();
        }
    }

    /// <summary>
    /// main class
    /// </summary>
    /// <remarks>class hitung volume dapat memilih bangun ruang yang ingin dihitung</remarks>
    class HitungVolume
    {
        /// <summary>
        /// pilihan bangun ruang
        /// </summary>
        

        static void Main(string[] args)
        {
            Kubus K = new Kubus();
            Balok B = new Balok();
            PrismaSegitiga PS3 = new PrismaSegitiga();

            int pilih;
            bool lanjut = true;
            while (lanjut)
            {
                Console.WriteLine("Pilihan Bangun Ruang");
                Console.WriteLine("--------------------");
                Console.WriteLine("1. Volume Kubus");
                Console.WriteLine("2. Volume Balok");
                Console.WriteLine("3. Volume Prisma Segitiga");
                Console.WriteLine("4. Keluar");
                Console.Write("Pilihan (1/2/3/4) : ");
                pilih = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch (pilih)
                {
                    case 1:
                        K.sisiKubus(); K.tampilKubus();
                        break;
                    case 2:
                        B.sisiBalok(); B.tampilBalok();
                        break;
                    case 3:
                        PS3.sisiPrismaSegitiga(); PS3.tampilPrismaSegitiga();
                        break;
                    case 4:
                        lanjut = false;
                        break;

                    default:
                        Console.WriteLine("Pilihan salah !"); Console.ReadKey();
                        break;
                }
            }
        }
    }
}    

