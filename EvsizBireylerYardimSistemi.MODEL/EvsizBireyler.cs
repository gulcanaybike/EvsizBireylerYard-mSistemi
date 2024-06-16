using System;
using System.Collections.Generic;
using System.Text;

namespace EvsizBireylerYardimSistemi.MODEL
{
    public class EvsizBireyler
    {
        public int id { get; set; }
        public string Tc_No { get; set; }
        public string Adi { get; set; }
        public int Yas { get; set; }
        public char Cinsiyet { get; set; }
        public string Bolge { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string GelirDurumu { get; set; }
    }
}
