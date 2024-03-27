namespace _2___Struct
{
    public struct Ogrenci
    {
        public Ogrenci(int numara, string adi, string soyadi, bool cinsiyet) // Constructor - Yapılandırıcı Metot // bool cinsiyet=true şeklinde de yapılabilir
        {
            Numara = numara;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        public int Numara { get; set; } // Property - Özellik  Kısayol: prop + tab
        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public bool Cinsiyet { get; set; }


        // Override - Geçersiz kılmak

        public override string ToString()
        {
            return $"{Numara} " +
                $"{Adi} " +
                $"{Soyadi} " +
                string.Format("{0,5}", Cinsiyet == true ? "Bay" : "Bayan");
        }

    }

}
