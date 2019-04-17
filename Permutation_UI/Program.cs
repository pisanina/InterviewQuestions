using Permutation;
using System;
using System.Linq;

namespace Permutation_UI
{
    class Program
    {
        static void Main()
        {
            string[] firstArray;
            string[] secondArray;
            PermutationService _permutationService = new PermutationService();

            Console.WriteLine("Please enter the first array - separate elements using spaces");
            firstArray = Console.ReadLine().Split(" ");
            CheckArrayLength(firstArray);
            CheckElementsAreIntegers(firstArray);

            Console.WriteLine("Please enter the second array - separate elements using spaces");
            secondArray = Console.ReadLine().Split(" ");
            CheckArrayLength(secondArray);
            CheckElementsAreIntegers(secondArray);

            if (_permutationService.CompareArrays(firstArray, secondArray))
                Console.WriteLine("YES");
           else
                Console.WriteLine("NO");

            Console.Read();
        }

        static void CheckArrayLength(string[] array)
        {
            if (array.Length != 11)
            {
                Console.WriteLine("Array must have eleven elements");
                Console.Read();
                Environment.Exit(0);
            }
        }

        static void CheckElementsAreIntegers(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (!Int32.TryParse(array[i], out int number))
                {
                    Console.WriteLine("Sorry You were supposed to provide integers");
                    Console.Read();
                    Environment.Exit(0);
                }
            }
        }
    }
}
