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
        public void ConvertsSingleDigits(int number, string romanNumeral)
        {
            ConvertToRoman(number).Should().Equal(romanNumeral);
        }

        public string ConvertToRoman(int number)
        {
            var result = "";
            var map = new Dictionary<int, string>
                          {
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
