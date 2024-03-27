using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Hashtable_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hashtable Uygulaması

            // Başlık okuma
            Console.WriteLine("Başlık Giriniz: ");
            string baslik = Console.ReadLine();

            // Küçültme
            baslik = baslik.ToLower(); 

            // Hashtable
            var karakterSeti = new Hashtable()
            {
                {'ç','c'},
                {'ı','i'},
                {'ö','o'},
                {'ü','u'},
                {' ','-'},
                {'\'','-'},
                {'ğ','g'},
                {'.','-'},
                {'?','-'},
            };
            foreach (DictionaryEntry item in karakterSeti)
            {
                baslik = baslik.Replace((char)item.Key, (char)item.Value);
            }
            // Ekrana yazdırma
            Console.WriteLine("Akıllı URL: "+ baslik);

            // Anahtarlar tekil olmak zorundadır.


        }
    }
}
