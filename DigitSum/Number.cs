using System;
using System.Collections.Generic;
using System.Text;

namespace DigitSum
{
    public class Number
    {
        public uint Input{ get; private set;}
        public uint Index { get; private set; }
        public uint SumOfDigits { get; private set; }

        public Number(uint input, uint index)
        {
            Input = input;
            Index = index;
            SumOfDigits = CalculateSumOfDigits();
        }

        private uint CalculateSumOfDigits()
        {
            uint dec, sum  = 0;
            while (Input > 0)
            {
                dec = Input % 10;
                sum += dec;
                Input /= 10;
            }
            return sum;
        }
    }
}
