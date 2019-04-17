using DigitSum;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DigitSum_Tests
{
    public class DigitSumTests
    {

        private DigitSumService _digitSumService;

        [SetUp]
        public void SetupTests()
        {
            _digitSumService = new DigitSumService();
        }

        [Test]
        public void AcceptanceCriteriaCase1()
        {
            List<uint> input = new List<uint>{2,4,3};
            uint actualResult =_digitSumService.MaxSumOfDigits(input);
            Assert.AreEqual(1, actualResult);
        }


        [Test]
        public void AcceptanceCriteriaCase2()
        {
            List<uint> input = new List<uint>{20,21,19};
            uint actualResult =_digitSumService.MaxSumOfDigits(input);
            Assert.AreEqual(2, actualResult);
        }

        [Test]
        public void IfMoreThanOneReturnTheGreatest()
        {
            List<uint> input = new List<uint>{21,12};
            uint actualResult =_digitSumService.MaxSumOfDigits(input);
            Assert.AreEqual(1, actualResult);
        }

    }
}
