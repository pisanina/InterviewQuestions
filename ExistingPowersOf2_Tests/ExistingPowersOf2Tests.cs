using ExistingPowersOf2;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ExistingPowersOf2_Tests
{
    public class ExistingPowersOf2Tests
    {
        private ExistingPowersOf2Service _existingPowersOf2Service;

        [SetUp]
        public void TestSetup()
        {
            _existingPowersOf2Service = new ExistingPowersOf2Service();
        }

        [Test]
        public void AcceptanceCriteriaOne()
        {
            IEnumerable<UInt32> input = new List<UInt32> {1,3,4};
            ICollection<UInt32> expectedOutput = new SortedSet<UInt32> {1,2,4};

            foreach (var item in input)
            {
                _existingPowersOf2Service.Decompose(item);
            }

            Assert.AreEqual(expectedOutput, _existingPowersOf2Service.GetResult());
        }


        [Test]
        public void AcceptanceCriteriaTwo()
        {
            IEnumerable<UInt32> input = new List<UInt32> {3,1,2};
            ICollection<UInt32> expectedOutput = new SortedSet<UInt32> {1,2};

            foreach (var item in input)
            {
                _existingPowersOf2Service.Decompose(item);
            }

            Assert.AreEqual(expectedOutput, _existingPowersOf2Service.GetResult());
        }

        [Test]
        public void OrderAndDuplicatesCase()
        {
            IEnumerable<UInt32> input = new List<UInt32> {14,3};
            ICollection<UInt32> expectedOutput = new SortedSet<UInt32> {1,2,4,8};

            foreach (var item in input)
            {
                _existingPowersOf2Service.Decompose(item);
            }

            Assert.AreEqual(expectedOutput, _existingPowersOf2Service.GetResult());
        }

        [Test]
        public void EmptyInput()
        {
            IEnumerable<UInt32> input = new List<UInt32> {};
            ICollection<UInt32> expectedOutput = new SortedSet<UInt32> {};

            foreach (var item in input)
            {
                _existingPowersOf2Service.Decompose(item);
            }

            Assert.AreEqual(expectedOutput, _existingPowersOf2Service.GetResult());
        }

        [Test]
        public void WithZero()
        {
            IEnumerable<UInt32> input = new List<UInt32> {14,0,3};
            ICollection<UInt32> expectedOutput = new SortedSet<UInt32> {1,2,4,8};

            foreach (var item in input)
            {
                _existingPowersOf2Service.Decompose(item);
            }

            Assert.AreEqual(expectedOutput, _existingPowersOf2Service.GetResult());
        }

    }
}
