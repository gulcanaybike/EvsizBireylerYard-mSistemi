using System;
using System.Collections.Generic;
using System.Text;

namespace EvsizBireylerYardimSistemi.MODEL
{
    public class Ihtiyaclar
    {
        public int id { get; set; }
        public string Adi { get; set; }

        public int Adet { get; set; }
        public string TeminDurumu { get; set; }
    }
}
