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
            List<int> input = new List<int>{2,4,3};
            int actualResult =_digitSumService.MaxSumOfDigits(input);
            Assert.AreEqual(1, actualResult);
        }


        [Test]
        public void AcceptanceCriteriaCase2()
        {
            List<int> input = new List<int>{20,21,19};
            int actualResult =_digitSumService.MaxSumOfDigits(input);
            Assert.AreEqual(2, actualResult);
        }

        [Test]
        public void IfMoreThanOneReturnTheGreatest()
        {
            List<int> input = new List<int>{21,12};
            int actualResult =_digitSumService.MaxSumOfDigits(input);
            Assert.AreEqual(1, actualResult);
        }

    }
}
