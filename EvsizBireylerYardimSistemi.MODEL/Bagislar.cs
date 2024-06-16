using System;
using System.Collections.Generic;
using System.Text;

namespace EvsizBireylerYardimSistemi.MODEL
{
    public class Bagislar
    {
        public int id { get; set; }
        public int ihtiyacId { get; set; }
        public string bagisciAdi { get; set; }
        public int bagisciAdet { get; set; }
    }
}
