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
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        public void ConvertsSingleDigits(int number, string romanNumeral)
        {
            ConvertToRoman(number).Should().Equal(romanNumeral);
        }

        public string ConvertToRoman(int number)
        {
            var converters = new Dictionary<int, string>
                                 {
                                     {1, "I"},
                                     {2, "II"},
                                     {3, "III"},
                                     {4, "IV"},
                                     {5, "V"},
                                     {6, "VI"},
                                     {7, "VII"},
                                     {8, "VIII"},
                                     {9, "IX"},
                                     {10, "X"},

                                 };

            return converters[number];
        }

    }
}
