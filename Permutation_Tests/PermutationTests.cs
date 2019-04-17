using NUnit.Framework;
using Permutation;
using System;

namespace Permutation_Tests
{
    public class PermutationTests
    {
        private PermutationService _permutationService;

        [SetUp]
        public void TestSetup()
        {
            _permutationService = new PermutationService();
        }

        [Test]
        public void NotValidArray()
        {
            string[] firstArray = null;
            string[] secondArray= { };

            bool result = _permutationService.CompareArrays(firstArray, secondArray);

            Assert.IsFalse(result);
        }

        [Test]
        public void Equal()
        {
            string[] firstArray = { "1", "2", "5", "3", "7", "0", "7", "3", "5", "2", "1" };
            string[] secondArray = {"7", "3", "1", "2", "5", "0", "5", "2", "1", "3", "7"};

            bool result = _permutationService.CompareArrays(firstArray, secondArray);

            Assert.IsTrue(result);
        }

        [Test]
        public void Different()
        {
            string[] firstArray = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11" };
            string[] secondArray = {"6", "5", "4", "3", "2", "0", "11", "10", "9", "8", "7"};

            bool result = _permutationService.CompareArrays(firstArray, secondArray);

            Assert.IsFalse(result);
        }

    }
    
}
