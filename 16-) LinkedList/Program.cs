using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LinkedList<T> Temelleri
            // Tanımlama
            var sehirler = new LinkedList<string>();

            // Ekleme
            sehirler.AddFirst("Ordu");
            sehirler.AddFirst("Trabzon"); // İlk düğüm
            sehirler.AddLast("İstanbul"); // Son düğüm

            sehirler.AddAfter(sehirler.Find("Ordu"),"Samsun"); // Ordu'yu bul sonra Samsun'u ekle
            sehirler.AddBefore(sehirler.First.Next.Next, "Giresun"); // İlk başa git sonra ve sonra Giresun'u ekle
            sehirler.AddAfter(sehirler.Last.Previous, "Sinop"); // İstanbul öncesine Sinop'u ekle
            sehirler.AddAfter(sehirler.Find("Sinop"), "Zonguldak");

            Console.WriteLine();
            Console.WriteLine("Gidiş Güzergahı");
            Console.WriteLine();
            var eleman = sehirler.First;
            while (eleman != null)
            {
                Console.WriteLine(eleman.Value);
                eleman = eleman.Next;
            }

            Console.WriteLine();
            Console.WriteLine("Dönüş Güzergahı");
            Console.WriteLine();
            var gecici = sehirler.Last;
            while (gecici != null)
            {
                Console.WriteLine(gecici.Value);
                gecici = gecici.Previous;
            }

        }
    }
}
