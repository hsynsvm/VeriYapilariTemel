using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___Queue_Kuyruk_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tanımlama
            var karakterKuyrugu = new Queue<char>(); // Generic 
            // Fifo veri yapısı mevcut

            // Ekleme
            karakterKuyrugu.Enqueue('a');
            karakterKuyrugu.Enqueue('e');
            Console.WriteLine($"Eleman sayısı {karakterKuyrugu.Count}");

            // Diziye atma
            var dizi = karakterKuyrugu.ToArray(); // Diziye atma işlemi

            // Kuyruğun başındaki elemanı bulma
            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");
            // Çıkarma
            Console.WriteLine($"Kuyruktan çıkartıldı: {karakterKuyrugu.Dequeue()}");
            Console.WriteLine($"Eleman sayısı {karakterKuyrugu.Count}");
            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");

        }
    }
}
