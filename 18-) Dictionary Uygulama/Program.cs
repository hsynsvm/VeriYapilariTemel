using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___Dictionary_Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tanımlama
            var personelListesi = new Dictionary<int, Personel>() 
            {
                {110,new Personel("Mehmet","Sonsoz",7500) },
                {120,new Personel("Ahmet","Can",9000) },

            };

            personelListesi.Add(100,new Personel("Zeynep","Coşkun",5000));

            foreach (var p in personelListesi)
            {
                Console.WriteLine(p);
            }
        }
    }
}
