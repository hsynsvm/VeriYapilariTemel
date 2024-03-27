using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HASHTABLE
            // Tanımlama
            var sehirler = new Hashtable();

            // Ekleme
            sehirler.Add(6, "Ankara"); // 6 = Key - Ankara = Value
            sehirler.Add(34, "İstanbul");
            sehirler.Add(55, "Samsun");
            sehirler.Add(23, "Elazığ");

            // Dolaşma
            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key,-5} " +
                    $"- {item.Value,-15}");
            }

            // Sadece anahtar alma
            Console.WriteLine("\nAnahtarlar - Keys");
            var anahtarlar = sehirler.Keys;
            foreach (var key in anahtarlar)
            {
                Console.WriteLine(key);
            }
            // Sadece değerleri alma
            Console.WriteLine("\nDeğerler - Values");
            ICollection degerler = sehirler.Values;
            foreach (var value in degerler)
            {
                Console.WriteLine(value);
            }
            // Elemana Erişme
            Console.WriteLine("\n55 numaralı şehir = "+sehirler[55]);

            // Eleman silme
            Console.WriteLine("\n Elazığ Silinmiştir");
            sehirler.Remove(23);
            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key,-5} " +
                    $"- {item.Value,-15}");
            }
        }
    }
}
