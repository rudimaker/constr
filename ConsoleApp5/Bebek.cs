using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Bebek
    {

        public DateTime DogumTarihi { get; private set; }
        public string Ad { get; private set; }
        public string Soyad { get; private set; }


        public Bebek()
        {
            DogumTarihi = DateTime.Now;
            Console.WriteLine("ıngaaaaaa");
        }


        public Bebek(string ad, string soyad)
        {

            DogumTarihi = DateTime.Now;
            Ad = ad;
            Soyad = soyad;

            Console.WriteLine("ıngaaaaa");

        }

        public void BilgileriYazdir()
        {
            Console.WriteLine($"Bebeğin adı {Ad} Bebeğin Soyadı {Soyad} ve Doğum Tarihi {DogumTarihi} ");
        }




    }

}
