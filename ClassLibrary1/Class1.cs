using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanNumeralConverter
    {
        internal String Convert(int arabic)
        {
            String roman = "";
            if (arabic == 0) return roman;
            var highestRoman = RomanNumeralLookup().Where(kvp => arabic >= kvp.Key).First();
            return roman + highestRoman.Value + Convert(arabic - highestRoman.Key);
        }

        private static Dictionary<int, string> RomanNumeralLookup()
        {
            var dic = new Dictionary<int, String>();
            dic.Add(1000, "M");
            dic.Add(900, "CM");
            dic.Add(500, "D");
            dic.Add(400, "CD");
            dic.Add(100, "C");
            dic.Add(90, "XC");
            dic.Add(50, "L");
            dic.Add(40, "XL");
            dic.Add(10, "X");
            dic.Add(9, "IX");
            dic.Add(5, "V");
            dic.Add(4, "IV");
            dic.Add(1, "I");
            return dic;
        }

    }
}
