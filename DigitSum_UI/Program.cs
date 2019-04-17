using DigitSum;
using System;
using System.Collections.Generic;

namespace DigitSum_UI
{
    class Program
    {
        static void Main()
        {
            int numberOfIntegers;
            List<int> input = new List<int>();
            DigitSumService _digitSumService = new DigitSumService();

            Console.WriteLine("How many integers?");
            Int32.TryParse(Console.ReadLine(), out numberOfIntegers);
            if (numberOfIntegers <= 0)
            {
                Console.WriteLine("Sorry , we accept only positive numbers");
                Console.Read();
                return;
            }

            Console.WriteLine("Please enter array of integers");
            string listOfInput = Console.ReadLine();
            string[] values = listOfInput.Split(" ");
            if (values.Length != numberOfIntegers)
            {
                Console.WriteLine("Sorry You were supposed to provide" + numberOfIntegers + "values");
                return;
            }

            for (int i = 0; i < values.Length; i++)
            {
                input.Add(int.Parse(values[i]));
            }

            Console.WriteLine(_digitSumService.MaxSumOfDigits(input));
            Console.Read();
        }
    }
}
