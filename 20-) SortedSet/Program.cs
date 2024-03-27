using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20___SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SortedSet - Sıralanmış Düzen
            // Tanımlama
            var list = new SortedSet<string>();

            // Ekleme
            if (list.Add("Mehmet"))
            {
                Console.WriteLine("Mehmet eklendi");
            }
            else
            {
                Console.WriteLine("Ekleme başarısız");
            }
            Console.WriteLine("{0}",list.Add("Ahmet") == true ? "Ahmet eklendi" : "Ekleme başarısız");

            list.Add("Sule");
            list.Add("Neslihan");
            list.Add("Fahrettin");
            list.Add("Fatih");


            // Listeden eleman kaldırma
            list.Remove("Sule");
            list.RemoveWhere(deger => deger.Contains("A")); // A içeren kayıtları sil.
            list.RemoveWhere(deger => deger.StartsWith("M")); 

            Console.WriteLine("\n İsimler Listesi");
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Eleman sayisi: {0}",list.Count);

        }    
    }
}
