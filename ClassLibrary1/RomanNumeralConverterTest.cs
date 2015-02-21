using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{

    using NUnit.Framework;

    [TestFixture]
    class RomanNumeralConverterTest
    {

        [Test]
        public void ConvertArabicToRoman()
        {
            AssertRoman("", 0);
            AssertRoman("I", 1);
            AssertRoman("II", 2);
            AssertRoman("III", 3);
            AssertRoman("IV", 4);
            AssertRoman("V", 5);
            AssertRoman("VI", 6);
            AssertRoman("VII", 7);
            AssertRoman("VIII", 8);
            AssertRoman("IX", 9);
            AssertRoman("X", 10);
            AssertRoman("XI", 11);
            AssertRoman("XL", 40);
            AssertRoman("L", 50);
            AssertRoman("XC", 90);
            AssertRoman("C", 100);
            AssertRoman("CD", 400);
            AssertRoman("D", 500);
            AssertRoman("CM", 900);
            AssertRoman("M", 1000);


        }

        private static void AssertRoman(String roman, int arabic)
        {
            Assert.AreEqual(roman, new RomanNumeralConverter().Convert(arabic));
        }

    }
}
