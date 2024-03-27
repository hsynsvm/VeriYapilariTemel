using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Class
{
    public class OgretimElemani
    {
        // Property - Özellik
        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }

        // Default ctor
        public OgretimElemani()
        {
            
        }

        // OverLoading
        public OgretimElemani(int sicilno, string adi, string soyadi, bool cinsiyet)
        {
            SicilNo = sicilno;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }


        public override string ToString()
        {
            return $"{SicilNo,-5}" +
                $"{Adi,-5}" +
                $"{Soyadi,8}" +
                string.Format("{0,5}", Cinsiyet == true ? "Bay" : "Bayan");
        }
    }
}
