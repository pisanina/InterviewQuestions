using FindingPrimes;
using NUnit.Framework;
using System;

namespace FindingPrimes_Tests
{
    public class FindingPrimesTests
    {

        private FindingPrimesService _findingPrimesServices;

        [SetUp]
        public void SetupTests()
        {
            _findingPrimesServices = new FindingPrimesService();

        }

        [TestCase(1, 1, 0)]
        [TestCase(1, 10, 4)]
        [TestCase(10, 20, 4)]
        [TestCase(100, 200, 21)]
        [TestCase(2, 7, 4)]

        public void CaseOne(int start, int end, int expectedResult)
        {
           int actualResult = _findingPrimesServices.NumberOfPrimesInRange(new Range(start,end));
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
