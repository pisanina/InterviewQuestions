using CommonDigit;
using NUnit.Framework;
using System;

namespace CommonDigit_Tests
{
    public class CommonDigitTests
    {

        private CommonDigitService _commonDigitService;

        [SetUp]
        public void SetupTests()
        {
           _commonDigitService = new CommonDigitService();
        }

        [TestCase("10120213", 1)]
        [TestCase("1112225", 2)]
        public void Test(string input, int expectedResult)
        {
           int actualResult = _commonDigitService.MostOccuringElement(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void InvalidInput(string input)
        {
            Assert.Throws<ArgumentException>(() => _commonDigitService.MostOccuringElement(input));
        }

    }
}
