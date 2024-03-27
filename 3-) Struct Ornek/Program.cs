using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Ornek
{
    public struct Nokta
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"{X},{Y}";
        }

        public Nokta(int x,int y) // Default constructor ctor + tab tuşu ile aktif hale gelir. Struct yapısında kullanılmaz.
        {
            X = x ;
            Y = y ;
        }

        // Yapımıza yeni üye -> Metot
        public void SetOrigin()
        {
            X = 0 ;
            Y = 0 ;
        }
        public void Degistir()
        {
            var gecici = this.X;
            X = Y;
            Y = gecici;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var n1 = new Nokta(3,4);
            Console.WriteLine($"n1: {n1}");
            n1.Degistir();
            Console.WriteLine($"n1: {n1}");

            var n2 = n1;
            Console.WriteLine($"n2: {n2}");

            Console.WriteLine("*****************");
            n2.X = -1 * n2.X;
            Console.WriteLine($"n1: {n1}");
            Console.WriteLine($"n2: {n2}");

        }
    }
}
