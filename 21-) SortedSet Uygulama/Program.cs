using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _21___SortedSet_Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sayilar = new List<int>();
            var r = new Random();

            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
               sayilar.Add(r.Next(5,15));
                Console.Write($"{sayilar[i],-3}");
            }
            Console.WriteLine();

            // Listedeki benzersiz elemanları bulmak
            var benzersizSayiListesi = new SortedSet<int>(sayilar);
            Console.WriteLine();
            Console.WriteLine("\nBenzersiz sayıların listesi:\n");
            foreach (int sayi in benzersizSayiListesi)
            {
                Console.Write($"{sayi,-3}");
            }
            Console.WriteLine("Benzersiz {0} sayı var",benzersizSayiListesi.Count);
        }
    }
}
