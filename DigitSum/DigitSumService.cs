using System;
using System.Collections.Generic;

namespace DigitSum
{
    public class DigitSumService
    {

        public int SumOfDigits(int number)
        {
            int dec, sum  = 0;
            while (number > 0)
            {
                dec = number % 10;
                sum += dec;
                number = number / 10;
            }
            return sum;
        }

        public int MaxSumOfDigits(List<int> input)
        {
            int maxSum = 0;
            int itemSum = 0;
            int indexOfMaxValue = 0;

            for (int i = 0; i < input.Count; i++)
            {
                itemSum = SumOfDigits(input[i]);
                if (itemSum >= maxSum)
                { 
                    maxSum = itemSum;
                    indexOfMaxValue = i;
                }
            }
            return indexOfMaxValue;

        }
    }
}
