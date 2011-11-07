using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Should.Fluent;

namespace RomanNumeralsKata
{
    [TestFixture]
    public class Tests
    {

        [Test]
        [TestCase(0, "")]
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(14, "XIV")]
        [TestCase(20, "XX")]
        [TestCase(29, "XXIX")]
        [TestCase(40, "XL")]
        [TestCase(41, "XLI")]
        [TestCase(44, "XLIV")]
        [TestCase(50, "L")]
        [TestCase(51, "LI")]
        [TestCase(90, "XC")]
        [TestCase(96, "XCVI")]
        [TestCase(100, "C")]
        [TestCase(300, "CCC")]
        [TestCase(400, "CD")]
        [TestCase(450, "LD")]
        [TestCase(500, "D")]
        [TestCase(900, "CM")]
        [TestCase(1000, "M")]
        [TestCase(1987, "MCMLXXXVII")]
        [TestCase(2000, "MM")]
        [TestCase(2400, "MMCD")]
        [TestCase(2600, "MMDC")]
        [TestCase(3999, "MMMCMXCIX")]
        [TestCase(3000, "MMM")]
        public void ConvertsSingleDigits(int number, string romanNumeral)
        {
            ConvertToRoman(number).Should().Equal(romanNumeral);
        }

        public string ConvertToRoman(int number)
        {
            var result = "";
            var map = new Dictionary<int, string>
                          {
                              {3000, "MMM"},
                              {1000, "M"},
                              {900, "CM"},
                              {500, "D"},
                              {450, "LD"},
                              {400, "CD"},
                              {100, "C"},
                              {90, "XC"},
                              {50, "L"},
                              {40, "XL"},
                              {10, "X"},
                              {9, "IX"},
                              {5, "V"},
                              {4, "IV"},
                              {1, "I"},
                          };

            foreach (var pair in map)
            {
                var arabic = pair.Key;
                var numeral = pair.Value;

                while (number >= arabic)
                {
                    result += numeral;
                    number -= arabic;
                }
            }
            

            return result;
        }

    }
}
