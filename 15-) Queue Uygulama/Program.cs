using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___Queue_Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sesliHarfler = new List<char>()
            {
                'a','e','ı','i','u','ü','o','ö'
            };

            ConsoleKeyInfo secim; // Kullanıcının hangi tuşa bastığını gösterir
            var kuyruk = new Queue<char>();

            foreach (char k in sesliHarfler)
            {
                Console.WriteLine();
                Console.WriteLine($"{k,-5} kuyruğa eklensin mi? [e/h]");
                secim = Console.ReadKey();
                Console.WriteLine();
                if (secim.Key == ConsoleKey.E)
                {
                    kuyruk.Enqueue(k);
                    Console.WriteLine($"\n{k,-5} kuyruğa eklendi");
                    Console.WriteLine($"Kuyruktaki eleman sayısı: {kuyruk.Count}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Kuyruktan elamanların kaldırılması için Esc tuşuna basınız");
            secim = Console.ReadKey();
            if (secim.Key == ConsoleKey.Escape)
            {
                Console.WriteLine();
                while (kuyruk.Count > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{kuyruk.Peek(),5} kuyruktan çıkartılıyor");
                    Console.WriteLine($"{kuyruk.Dequeue(),5} kuyruktan çıkartdı");
                    Console.WriteLine($"Kuyruktaki eleman sayısı: {kuyruk.Count}");
                }
                Console.WriteLine("\n Kuyruktan çıkarma işlemi tamamlandı");
            }
            Console.WriteLine("\nProgram bitti");
            Console.ReadKey();
        }
    }
}
