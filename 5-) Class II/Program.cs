using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _5___Class_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tanımlama - Atama

            var liste1 = new List<OgretimElemani>()
            {
                new OgretimElemani(100,"Hüseyin","Sevim",true),
                new OgretimElemani(101,"Büşra","Susak",false),
                new OgretimElemani(102,"Hamza","Dağ",true),
                new OgretimElemani(103,"Mahmut","Abbas",true),
                new OgretimElemani(104,"Leyla","Aruk",false),
                new OgretimElemani(105,"Kezban","Yol",false),
            };

            Console.WriteLine("Liste 1");
            liste1.ForEach(ogr => Console.WriteLine(ogr));

            List<OgretimElemani> liste2 = liste1;
            Console.WriteLine("Liste 2");
            liste2.ForEach(ogr => Console.WriteLine(ogr));

            liste2.Add(new OgretimElemani(106, "Alev", "Han",false)); // Ekleme
            liste1.RemoveAt(0); // Silme index'e göre
        }
    }
}
