using System;
using System.Linq;

namespace Permutation
{
    public class PermutationService
    {
        public bool CompareArrays(string[] firstArray, string[] secondArray)
        {
            if (firstArray is null || secondArray is null || firstArray.Length==0 || secondArray.Length==0)
                return false;
            else
            {
                Array.Sort(firstArray);
                Array.Sort(secondArray);

                return firstArray.SequenceEqual(secondArray);
            }
        }
    }
}
