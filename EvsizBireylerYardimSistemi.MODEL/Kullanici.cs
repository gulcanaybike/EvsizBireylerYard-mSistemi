using System;

namespace EvsizBireylerYardimSistemi.MODEL
{
    public class Kullanici
    {
        public int id { get; set; }
        public string Tc_No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sifre { get; set; }

        public bool isAdmin {  get; set; }
    }
}
