using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___Diziler__Array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array | Diziler

            // Tanımlama
            int[] sayilar = new int[] { 5, 3, 8, 10, 2,18,23,44,55,6,34,19 };  // Tek boyutlu dizi yapmak istersek

            var numbers = Array.CreateInstance(typeof(int), sayilar.Length);
            var sayilar2 = new ArrayList(sayilar);

            // 1. kullanım dizi içerisindeki elemanları yazmak için
            //numbers.SetValue(5, 0);
            //numbers.SetValue(3, 1);
            //numbers.SetValue(8, 2);
            //numbers.SetValue(10, 3);
            //numbers.SetValue(2, 4);

            // 2. Kullanım dizi içerisindeki sayıları kopyalamak için
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    numbers.SetValue(sayilar[i], i);
            //}

            // 3. Kullanım Kopyalama işlemi için
            sayilar.CopyTo(numbers, 0);

            Array.Sort(sayilar); // Küçükten büyüğe doğru Sıralama yapmak için kullanılır.
            Array.Sort(numbers);
            sayilar2.Sort(); // Küçükten büyüğe doğru Sıralama yapmak için kullanılır.
            Array.Clear(sayilar, 2, 2); // Dizi içerisindeki silme işlemini yapar
            Console.WriteLine(Array.IndexOf(sayilar, 44)); // 44 sayısı dizi içerisindeki kaçıncı index'te?

            // Dolaşma
            for (int i = 0; i < numbers.Length; i++)
            {
                //Console.WriteLine("Sayılar[{0}] = {1} - numbers[{0}] = {2}", i, sayilar[i],numbers.GetValue(i)); 1.Kullanım
                Console.WriteLine($"sayilar[{i}] = " +
                    $"{sayilar[i],3} - " +
                    $"numbers[{i}] = " +
                    $"{numbers.GetValue(i),3}  "+
                    $"sayilar2[{i}] = " +
                    $"{sayilar2[i],3}");
            }

            

        }
    }
}
