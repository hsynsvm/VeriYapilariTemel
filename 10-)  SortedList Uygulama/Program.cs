using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10____SortedList_Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kitapIcerigi = new SortedList();
            kitapIcerigi.Add(1, "Önsöz");
            kitapIcerigi.Add(50, "Değişkenler");
            kitapIcerigi.Add(40, "Operatörler");
            kitapIcerigi.Add(60, "Döngüler");
            kitapIcerigi.Add(45, "İlişkisel Operatörler");

            Console.WriteLine("İçindekiler");
            Console.WriteLine(new string('-',25));
            Console.WriteLine($"{"Konular",-33} {"Sayfalar",4}");
            foreach (DictionaryEntry item in kitapIcerigi)
            {
                Console.WriteLine($" {item.Value,-33} {item.Key,4}");
            }
        }
    }
}
