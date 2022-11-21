using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal static class Sinif
    {
        public static double Ondalık(this double ondalık)
        {
            return ondalık;
        }
        public static string Ifade(this string ifade, int kez)
        {
            string str = "";
            for (int i = 0; i < kez; i++)
            {
                str += str + "";
            }
            return str;
        }
        public static bool TrueFalse(this bool tf)
        {
            return !tf;
        }
        public static void Oylesine(this IEnumerable islem)
        {
        }
    }
}