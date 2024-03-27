using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2___Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Struct Tanımlama ve kullanma

            Ogrenci ogr = new Ogrenci();
            ogr.Numara = 1026;
            ogr.Adi = "Hüseyin";
            ogr.Soyadi = "Sevim";
            ogr.Cinsiyet = true;
            Console.WriteLine($"{ogr.Numara} " + 
                $"{ogr.Adi} {ogr.Soyadi} " +
                $"{ogr.Cinsiyet}");

            // Alternatif kullanım

            Ogrenci ogr2 = new Ogrenci()
            {
                Numara = 1027,
                Adi = "Büşra",
                Soyadi = "Susak",
                Cinsiyet = false
            };
            Console.WriteLine($"{ogr2.Numara} " +
                $"{ogr2.Adi} {ogr2.Soyadi} " +
                $"{ogr2.Cinsiyet}");

            // Alternatif Kullanım 2 (Constructor ve overload)

            Ogrenci ogr3 = new Ogrenci(30, "Mehmet", "Avşar", true);
            Console.WriteLine($"{ogr3.Numara} " +
                $"{ogr3.Adi} {ogr3.Soyadi} " +
                $"{ogr3.Cinsiyet}");

            // Override metodunu kullanarak Bay ve Bayan yazdırma
            Console.WriteLine(ogr);
            Console.WriteLine(ogr2);
            Console.WriteLine(ogr3);


            // Liste hazırlama
            var ogrenciListesi = new List<Ogrenci>()
            {
                new Ogrenci(30, "Mehmet", "Avşar", true),
                new Ogrenci(150, "Azem", "Yücedağ", true)
            };

            foreach (Ogrenci o in ogrenciListesi)
            {
                Console.WriteLine(o);
            }

            ogrenciListesi.ForEach(o=> Console.WriteLine(o)); // Üsttekinin hazır hali

            // İstenilen veriyi bulmak ve ayrı ayrı kopyalamak için ctrl + shift + v tuşlarına beraber basılarak yapıştırılır
        }
    }

}
