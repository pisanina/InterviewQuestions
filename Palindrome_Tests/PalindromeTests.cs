using NUnit.Framework;
using Palindrome;
using System;

namespace Palindrome_Tests
{
    public class PalindromeTests
    {

        private PalindromeService _palindromeService;

        [SetUp]
        public void TestSetup()
        {
            _palindromeService = new PalindromeService();
        }

        [TestCase("Anna")]//even
        [TestCase("Anona")]//odd
        [TestCase("abut-1-tuba")]//no letters
        [TestCase("Abut-1-tuba")]//case-sensitivity
        [TestCase("%abba,")]
        [TestCase("ann a")]
        public void SimplePalindromes(string toCheck)
        {

           bool result = _palindromeService.IsItPalindrome(toCheck);

           Assert.IsTrue(result);
 
        }

        [TestCase("@allula ")]
        [TestCase("11a11")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("a")]
        [TestCase(null)]
    
        public void RemoveNotLetters(string toCheck)
        {
            bool result = _palindromeService.IsItPalindrome(toCheck);

            Assert.IsFalse(result);
        }
    }
}
