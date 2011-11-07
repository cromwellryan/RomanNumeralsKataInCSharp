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
        [TestCase(10, "X")]
        [TestCase(20, "X")]
        public void ConvertsSingleDigits(int number, string romanNumeral)
        {
            ConvertToRoman(number).Should().Equal(romanNumeral);
        }

        public string ConvertToRoman(int number)
        {
            var result = "";

            if (number == 10) {return "X";}
            if (number == 5) return "V";
            if (number == 4) return "IV";

            while (number > 0)
            {
                result += "I";
                number -= 1;
            }

            return result;
        }

    }
}
