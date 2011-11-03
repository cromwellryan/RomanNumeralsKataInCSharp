using NUnit.Framework;

namespace RomanNumeralsKata
{
    [TestFixture]
    public class Tests
    {
        ConvertToRoman(1).Should().Equal("I");
    }
}
