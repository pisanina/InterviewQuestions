using NUnit.Framework;
using ReverseArray;
using System;
using System.Collections.Generic;

namespace ReverseArray_Tests
{
    public class ReverseTests
    {
        private ReverseService _reverseService;

        [SetUp]
        public void TestSetup()
        {
            _reverseService = new ReverseService();
        }

        [Test]
        public void ReverseOddInt()
        {
            List<int> array = new List<int>{ 1,2,3};

            _reverseService.Reverse(array);

            Assert.AreEqual(3, array[0]);
            Assert.AreEqual(2, array[1]);
            Assert.AreEqual(1, array[2]);
           
        }

        [Test]
        public void ReverseEvenInt()
        {
            List<int> array = new List<int>{ 1,2,3,4};

            _reverseService.Reverse(array);

            Assert.AreEqual(4, array[0]);
            Assert.AreEqual(3, array[1]);
            Assert.AreEqual(2, array[2]);
            Assert.AreEqual(1, array[3]);
        }


        [Test]
        public void ReverseString()
        {
            List<string> array = new List<string>{ "one","two","three","four"};

            _reverseService.Reverse(array);


            Assert.AreEqual("four", array[0]);
            Assert.AreEqual("three", array[1]);
            Assert.AreEqual("two", array[2]);
            Assert.AreEqual("one", array[3]);
        }


        [Test]
        public void EmptyArray()
        {
            List<string> array = new List<string>{};

            _reverseService.Reverse(array);

            Assert.AreEqual(0, array.Count);
        }


        [Test]
        public void Null()
        {
            List<string> array = null;

            _reverseService.Reverse(array);

            Assert.Null(array);
        }
    }
}
