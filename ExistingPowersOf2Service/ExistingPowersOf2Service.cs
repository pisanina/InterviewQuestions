using System;
using System.Collections.Generic;

namespace ExistingPowersOf2
{
    public class ExistingPowersOf2Service
    {
        ICollection<UInt32> _result;

        public ExistingPowersOf2Service()
        {
            _result = new SortedSet<UInt32>();
        }

        public void Decompose(UInt32 number)
        {
            UInt32 i =1;
            while (i <= number)
            {
                if ((i & number) > 0 && !_result.Contains(i))
                    _result.Add(i);

                i <<= 1;
            }
        }

        public ICollection<UInt32> GetResult()
        {
            return _result;
        }
    }
}
