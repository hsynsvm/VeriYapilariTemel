using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23___HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HashSet
            // Tanımlama
            var sesliHarf = new HashSet<char>() 
            {
                'e','ı','i','u','ü','o','ö','b'
            };

            // Ekleme
            sesliHarf.Add('a');
            
            // Listeden çıkarma
            sesliHarf.Remove('b');
            KoleksiyonYazdir(sesliHarf);

            var alfabe = new List<char>();
            for (int i = 97; i < 123; i++)
                alfabe.Add((char)i);
            KoleksiyonYazdir(alfabe);


            //sesliHarf.ExceptWith(alfabe); //Sadece Türkçe'de kullanılan sesli harfler
            //sesliHarf.UnionWith(alfabe); // Birleştirme
            //sesliHarf.IntersectWith(alfabe); // Kesişim
            sesliHarf.SymmetricExceptWith(alfabe); // Keşişim dışında kalan ifadeler
            
            KoleksiyonYazdir(sesliHarf); // Metot ile yazdırma işlemi
            
        }
        static void KoleksiyonYazdir(IEnumerable koleksiyon)
        {
            Console.WriteLine();
            int i = 0;
            foreach (char k in koleksiyon)
            {
                Console.Write($"{k,5}");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("\nEleman sayısı: {0}",i);
        }
    }
}
