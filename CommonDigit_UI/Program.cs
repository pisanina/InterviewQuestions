using CommonDigit;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CommonDigit_UI
{
    class Program
    {
        static void Main()
        {
            int numberOfIntegers;
            CommonDigitService commonDigitService = new CommonDigitService();

            Console.WriteLine("How many integers?");
            Int32.TryParse(Console.ReadLine(), out numberOfIntegers);
            if(numberOfIntegers<2 || numberOfIntegers>20)
            {
                Console.WriteLine("Sorry, we accept numbers between 2 and 20");
                Console.Read();
                return;
            }

            Console.WriteLine("Please enter array of integers");
            string listOfInput = Console.ReadLine();
            string[] values = listOfInput.Split(" ");
            if (values.Length != numberOfIntegers)
            {
                Console.WriteLine("Sorry You were supposed to provide" +numberOfIntegers+ "values");
                return;
            }
            var input = listOfInput.Where(c => Char.IsDigit(c)).ToString();
            
            Console.WriteLine(commonDigitService.MostOccuringElement(input));
            Console.Read();
        }
    }
}
