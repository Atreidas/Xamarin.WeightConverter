using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.WeightConverter
{
    public class Converter
    {
        private static double result = 0;
        private static readonly int round = 2;
        public static string ToPounds(string kilos)
        {
            if (!Double.TryParse(kilos, out result))
                return "0";

            if (result == 0) return "0";

            return Math.Round(result * 2.2046, round).ToString();
        }
        public static string ToKilos(string pounds)
        {
            if (!Double.TryParse(pounds, out result))
                return "0";

            if (result == 0) return "0";

            return Math.Round(result * 0.453592, round).ToString();
        }
    }
}
