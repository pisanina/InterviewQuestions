using System;
using System.Collections.Generic;
using FindingPrimes;

namespace FindingPrimes_UI
{
    class Program
    {
        static void Main()
        {
            int cases = 0;
            List<Range> ranges = new List<Range>();

            FindingPrimesService _findingPrimes = new FindingPrimesService();

            Console.WriteLine("How many test cases?");
            Int32.TryParse(Console.ReadLine(), out cases);

            for (int i = 0; i < cases; i++)
            {

                Console.WriteLine("Plese enter start and end of range");
                string[] values = Console.ReadLine().Split(" ");
                if (values.Length != 2)
                {
                    Console.WriteLine("Sorry You were supposed to provide two values");
                    return;
                }

                Range range = new Range(
                    int.Parse(values[0]),
                    int.Parse(values[1])
                );
                if (!range.IsValid())
                {
                    Console.WriteLine("Sorry start must be smaller or equal to end");
                    return;
                }
                ranges.Add(range);
            }

            foreach (var r in ranges)
            {
               int howManyPrimes = _findingPrimes.NumberOfPrimesInRange(r);
               Console.WriteLine(howManyPrimes);
            }

        }
    }
}
