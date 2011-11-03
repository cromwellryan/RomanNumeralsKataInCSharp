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
        public void ShouldConvertSingleDigits(int number, string romanNumeral)
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

                                 };

            return converters[number];
        }

    }
}
