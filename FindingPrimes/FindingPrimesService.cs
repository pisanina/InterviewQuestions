using System;

namespace FindingPrimes
{
    public class FindingPrimesService
    {
        public bool IsItPrime(int number)
        {
            int boundary = (int)Math.Floor(Math.Sqrt(number));

            if (number == 2)
                return true;
            if (number <2 || number % 2 == 0)
                return false;

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
        //I was thinking about saving the ranges and prime numbers 
        //that if the second range is included or overlap the previous one i could use the previous calculations.
        //However, slightly afraid of overengineering, and there is a really great weather outside...!
        //I have already written a really posh algorithm for prime numbers...
        public int NumberOfPrimesInRange(Range r)
        {
            int howManyPrimes = 0;

            for (int i = r.Start; i < r.End; i++)
            {
                if (IsItPrime(i))
                    howManyPrimes++;
            }

            return howManyPrimes;
        }


    }
}
