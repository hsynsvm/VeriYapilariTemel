using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _22___SortedSet_Küme_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var A = new SortedSet<int>() { 1, 2, 3, 4, };
            // var B = new SortedSet<int>() { 1, 2, 5, 6, };

            var A = new SortedSet<int>(RastgeleSayiUret(10));
            var B = new SortedSet<int>(RastgeleSayiUret(5));

            #region Yazdırma
            Console.WriteLine("A kümesi");
            foreach (int s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();

            Console.WriteLine("B kümesi");
            foreach (int s in B)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();
            #endregion

            // Union - Birleştirme

            //A.UnionWith( B ); // Birleşim
            //A.IntersectWith(B); // Kesişim
            //A.ExceptWith(B); // Sadece A kümesi 
            //A.SymmetricExceptWith(B); // Kesişim dışındaki elemanları yazdırır
            //A.IsSubsetOf(B); // A B'nin alt kümesi mi?

            Console.WriteLine("A ve B kümesinin birleşimi");
            foreach (var s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine("\n Toplam sayisi: {0}",A.Count);

        }
        static List<int> RastgeleSayiUret(int n)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < n;i++)
                list.Add(r.Next(0,10));
                return list;
        }
    }
}
