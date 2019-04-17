using DigitSum;
using System;
using System.Collections.Generic;

namespace DigitSum_UI
{
    class Program
    {
        static void Main()
        {
            uint numberOfIntegers;
            List<uint> input = new List<uint>();
            DigitSumService _digitSumService = new DigitSumService();

            Console.WriteLine("How many integers?");
            if (!UInt32.TryParse(Console.ReadLine(), out numberOfIntegers))
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
            CheckElementsAreIntegers(values);

            for (int i = 0; i < values.Length; i++)
            {
                if (UInt32.TryParse(values[i], out uint number))
                {
                    input.Add(number);
                }
                else
                {
                    Console.WriteLine("Sorry You were supposed to provide integers");
                    Console.Read();
                    return;
                }
            }

            Console.WriteLine(_digitSumService.MaxSumOfDigits(input));
            Console.Read();
        }

        static void CheckElementsAreIntegers(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (!UInt32.TryParse(array[i], out uint number) && number>0)
                {
                    Console.WriteLine("Sorry You were supposed to provide positive integers");
                    Console.Read();
                    Environment.Exit(0);
                }
            }
        }


    }
}
