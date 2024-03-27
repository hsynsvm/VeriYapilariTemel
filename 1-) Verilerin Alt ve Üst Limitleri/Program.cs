using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //   Veri Türlerinin Alt ve Üst Limitleri

            // Not : İnteger 8 bit değer tutar
            
            Console.WriteLine(nameof(SByte));
            Console.WriteLine($"Alt limit: {SByte.MinValue,10}");
            Console.WriteLine($"Üst limit: {SByte.MaxValue,10}");
            Console.WriteLine($"Boyut: {sizeof(SByte),12}"); // Hafızada yer tutan boyutu ifade eder

            Console.WriteLine("**********************************");

            Console.WriteLine(nameof(Byte));
            Console.WriteLine($"Alt limit: {Byte.MinValue,10}");
            Console.WriteLine($"Üst limit: {Byte.MaxValue,10}");
            Console.WriteLine($"Boyut: {sizeof(Byte),12}"); // Hafızada yer tutan boyutu ifade eder

            Console.WriteLine("**********************************");

            Console.WriteLine(nameof(Int16)); // İşaretli Int16 ( + ve - değerler var)
            Console.WriteLine($"Alt limit: {Int16.MinValue,10}");
            Console.WriteLine($"Üst limit: {Int16.MaxValue,10}");
            Console.WriteLine($"Boyut: {sizeof(Int16),12}"); // Hafızada yer tutan boyutu ifade eder

            Console.WriteLine("**********************************");

            Console.WriteLine(nameof(UInt16)); // İşaretsiz UInt16 ( + değerler var)
            Console.WriteLine($"Alt limit: {UInt16.MinValue,10}");
            Console.WriteLine($"Üst limit: {UInt16.MaxValue,10}");
            Console.WriteLine($"Boyut: {sizeof(UInt16),12}"); // Hafızada yer tutan boyutu ifade eder

            Console.WriteLine("**********************************");

            Console.WriteLine(nameof(Int32));
            Console.WriteLine($"Alt limit: {Int32.MinValue,10}");
            Console.WriteLine($"Üst limit: {Int32.MaxValue,10}");
            Console.WriteLine($"Boyut: {sizeof(Int32),12}"); // Hafızada yer tutan boyutu ifade eder

            Console.WriteLine("**********************************");

            Console.WriteLine(nameof(Double));
            Console.WriteLine($"Alt limit: {Double.MinValue,10}");
            Console.WriteLine($"Üst limit: {Double.MaxValue,10}");
            Console.WriteLine($"Boyut: {sizeof(Double),12}"); // Hafızada yer tutan boyutu ifade eder
            
            

            
        }
    }
}
