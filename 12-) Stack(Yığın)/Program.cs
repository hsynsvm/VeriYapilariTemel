using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Stack_Yığın_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var karakterYigini = new Stack<char>();
            for (int i = 65; i <= 90; i++)
            {
                karakterYigini.Push((char)i);
                Console.WriteLine($"{karakterYigini.Peek()} yığına eklendi");
                Console.WriteLine($"Yığındaki eleman sayısı : {karakterYigini.Count}");
            }

            // Yığındaki ifadeleri diziye aktarma
            var dizi = karakterYigini.ToArray();

            // Yığından çıkartma
            Console.WriteLine("Yığından Çıkartma İşlemi için bir tuşa basınız");
            Console.ReadKey();
            while (karakterYigini.Count>0)
            {
                Console.WriteLine($"{karakterYigini.Pop()} yığından çıkarıldı");
                Console.WriteLine($"Yığındaki eleman sayısı : {karakterYigini.Count}");
            }
        }

        private static void YıgınOrnegi()
        {
            // Tanımlama
            var karakterYigini = new Stack<char>();

            // Ekleme
            karakterYigini.Push('A');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('B');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('C');
            Console.WriteLine(karakterYigini.Peek());

            // Çıkarma
            Console.WriteLine(karakterYigini.Pop() + " yığından çıkartıldı ");
            Console.WriteLine(karakterYigini.Pop() + " yığından çıkartıldı ");
            Console.WriteLine(karakterYigini.Pop() + " yığından çıkartıldı ");
        }
    }
}
