using System;
using System.Linq;

namespace Palindrome
{
    class Program
    {
        static void Main()
        {
            string toCheck;
            PalindromeService palindromeService = new PalindromeService();
            Console.WriteLine("Please enter the string to check to be a palindrome");

            toCheck = Console.ReadLine();//no enters in the middle of palindrome.

            if (palindromeService.IsItPalindrome(toCheck))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

            Console.Read();
        }
    }
}
