using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___List
{
    public class Sehir : IComparable<Sehir>
    {
        public int PlakaNo { get; set; }
        public string SehirAdı { get; set; }
        public Sehir(int plakaNo, string sehirAdı)
        {
            PlakaNo = plakaNo;
            SehirAdı = sehirAdı;
        }
        // Override
        public override string ToString()
        {
            return $"{PlakaNo,-5} {SehirAdı,-15}";
        }

        public int CompareTo(Sehir other)
        {
            if(this.PlakaNo<other.PlakaNo)
            {
                return -1;
            }
            else if (this.PlakaNo == other.PlakaNo)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // List tanımlama
            var sayilar = new List<int>() 
            {
                53,40,14,2,3,12,15
            };
            sayilar.Sort(); // Sıralama yaptırma
            sayilar.ForEach(s => Console.WriteLine(s));

            // Şehir Listesi
            var sehirler = new List<Sehir>()
            {
                new Sehir(6,"Ankara"),
                new Sehir(34,"İstanbul"),
                new Sehir(55,"Samsun"),
                new Sehir(23,"Elazığ"),
                new Sehir(44,"Malatya"),
            };
            Console.WriteLine(" Şehirler");
            sayilar.Sort();
            sehirler.ForEach(s => Console.WriteLine(s));


        }
    }
}
