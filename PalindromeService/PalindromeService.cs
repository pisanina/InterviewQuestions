using System;
using System.Linq;

namespace Palindrome
{
    public class PalindromeService
    {

        public bool IsItPalindrome(string Input)
        {
            if (string.IsNullOrWhiteSpace(Input))
                return false;

            Input = new string(Input.Where(c => Char.IsLetter(c)).ToArray()).ToLower();

            if (Input.Length < 2)
                return false;
            else
            {
                for (int i = 0; i < Input.Length / 2; i++)
                {
                    if (Input[i] != Input[Input.Length - i - 1])
                        return false;
                }

                return true;
            }
        }
    }
}
