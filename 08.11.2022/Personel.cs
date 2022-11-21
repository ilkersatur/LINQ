using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._11._2022
{
    internal class Personel
    {
    }
    internal class Kitap
    {
        public int KitapID { get; set; }
        public string KitapAd { get; set; }
        public string Kategori { get; set; }
        public double Fiyat { get; set; }
        public override string ToString()
        {
            return $"{KitapAd}, {KitapID}, {Kategori}, {Fiyat}";
        }
    }
}