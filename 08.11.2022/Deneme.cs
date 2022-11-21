using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._11._2022
{
    internal static class Deneme
    {
        public static int KareAl(this int sayi)
        {
            return sayi * sayi;
        }
        public static int KupAl(this int sayi)
        {
            return sayi * sayi * sayi;
        }
        public static int IkiyeBol(this int sayi)
        {
            return sayi / 2;
        }
        public static int IstenilnSayiyaBol(this int sayi, int bol)
        {
            return sayi / bol;
        }
        public static string TersCevir(this string str)
        {
            string strYeni = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                strYeni += str[i];
            }
            return strYeni;
        }
    }
}
