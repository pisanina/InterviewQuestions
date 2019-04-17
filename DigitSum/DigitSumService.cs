using System;
using System.Collections.Generic;
using System.Linq;

namespace DigitSum
{
    public class DigitSumService
    {
        public uint MaxSumOfDigits(List<uint> input)
        {
            List<Number> numbers= new List<Number>();

            for(uint i=0; i< input.Count; ++i)
                numbers.Add(new Number(input[(int)i], i));

            return numbers.OrderByDescending(n => n.SumOfDigits)
                .ThenByDescending(n => n.Index).First().Index;
        }
    }
}
