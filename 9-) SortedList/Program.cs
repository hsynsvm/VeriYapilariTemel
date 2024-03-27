using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SortedList - Temeller
            var list = new SortedList()
            {
                // Ekleme yolu 2
                { 1,"Bir"},
                { 2,"İki"},
                { 3,"Üç"},
                { 4,"Dört"},
                { 8,"Sekiz"},
                { 5,"Beş"},
                { 6,"Altı"},
            };

            // Ekleme yolu 1
            //list.Add(1, "Bir");
            //list.Add(2, "İki");

            // Dolaşma
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine("Listedeki eleman sayısı: {0}",list.Count);
            Console.WriteLine("Listedeki kapasite: {0}", list.Capacity);
            list.TrimToSize(); // Kapasiteyi litedeki eleman sayısına göre set etme işlemi
            Console.WriteLine("Listedeki kapasite: {0}", list.Capacity);

            // Erişme
            // Key 
            Console.WriteLine(list[4]);
            // Index
            Console.WriteLine(list.GetByIndex(0));
            // Get -> Key
            Console.WriteLine(list.GetKey(0));
            // Liste sonu eleman değeri getirme
            Console.WriteLine(list.GetByIndex(list.Count-1));
            // Liste sonu key değeri getirme
            Console.WriteLine(list.GetKey(list.Count - 1));

            // Anahtarları alma
            var anahtarlar = list.Keys;
            Console.WriteLine("\n Anahtarlar: ");
            foreach (var key in anahtarlar)
            {
                Console.WriteLine(key);
            }
            // Değerleri alma
            var degerler = list.Values;
            Console.WriteLine("\n Değerler: ");
            foreach (var value in degerler)
            {
                Console.WriteLine(value);
            }

            // Listedeki eleman yada key var mı yok mu KONTROL oluşturma ve Listedeki elemanı güncelleme
            Console.WriteLine("\n Güncelleme");
            if (list.ContainsKey(1))
            {
                list[1] = "One";
            }
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

        }
    }
}
