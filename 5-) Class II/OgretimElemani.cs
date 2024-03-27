namespace _5___Class_II
{
    public class OgretimElemani
    {
        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }

        public OgretimElemani()
        {

        }

        public OgretimElemani(int sicilNo, string adi, string soyadi, bool cinsiyet)
        {
            SicilNo = sicilNo;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }
        public override string ToString()
        {
            return $"{SicilNo,-4}" +
                $"{Adi,-3}" +
                $"{Soyadi,8}" +
                string.Format("{0,10}", Cinsiyet == true ? "Bay" : "Bayan");
        }
    }
}