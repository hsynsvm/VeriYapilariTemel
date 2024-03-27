using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tanımlama
            OgretimElemani ogrGor = new OgretimElemani(103, "Hüseyin", "Sevim", true); // Atama 3
            //{
            //    // Atama 2 
            //    SicilNo = 102,
            //    Adi = "Mahmut",
            //    Soyadi = "Abbas",
            //    Cinsiyet = true,
            //};

            // Atama 1
            //ogrGor.SicilNo = 101;
            //ogrGor.Adi = "Ahmet";
            //ogrGor.Soyadi = "Yalçın";
            //ogrGor.Cinsiyet = true;

            Console.WriteLine(ogrGor);
        }
    }
}
