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

            Console.WriteLine("Please enter the second array - separate elements using spaces");
            secondArray = Console.ReadLine().Split(" ");

           if(_permutationService.CompareArrays(firstArray, secondArray))
                Console.WriteLine("YES");
           else
                Console.WriteLine("NO");

            Console.Read();
        }

    }
}
