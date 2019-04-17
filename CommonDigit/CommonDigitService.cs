using System;
using System.Collections.Generic;
using System.Linq;

namespace CommonDigit
{
    public class CommonDigitService
    {
        public int MostOccuringElement(string input)
        {
            if(string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Invalid input, cannot be null or whitespace");
            }
            Dictionary<int, int> digits = new Dictionary<int, int>();
            for (int i = 0; i < 10; i++)
            {
                digits.Add(i,0);
            }

            for (int i = 0; i < input.Length; i++)
            {
                digits[input[i] - '0']++;
            }

            int maxValue = digits.Values.Max();
            List<int> mostOccurents = digits.Where(d => d.Value == maxValue).Select(d => d.Key).ToList();
            return mostOccurents.Max();
        }
    }
}
