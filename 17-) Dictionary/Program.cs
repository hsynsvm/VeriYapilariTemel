using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary - Sözlük
            // Tanımlama
            var telefonKodlari = new Dictionary<int, string>()
            {
                {332,"Konya" },
                {424,"Elazığ" },
                {466,"Art" },
            };

            // Ekleme
            telefonKodlari.Add(322, "Adana");
            telefonKodlari.Add(212, "İstanbul");
            telefonKodlari.Add(215, "Mardin");

            // Erişme
            telefonKodlari[466] = "Artvin";

            // ContainsKey
            if (!telefonKodlari.ContainsKey(312))
            {
                Console.WriteLine("\aAnkaranın kod ifadesi tanımlı değil!");
                telefonKodlari.Add(312, "Ankara");
                Console.WriteLine("Yeni kod eklendi");
            }
            // ContainsValue
            if (!telefonKodlari.ContainsValue("Malatya"))
            {
                Console.WriteLine("\aMalatyanın kod ifadesi tanımlı değil!");
                telefonKodlari.Add(313, "Malatya");
                Console.WriteLine("Yeni kod eklendi");
            }
            // Çıkarma
            telefonKodlari.Remove(322);
            Console.WriteLine("Adana çıkartıldı");
            foreach (var s in telefonKodlari)
            {
                Console.WriteLine(s);
            }

        }
    }
}
