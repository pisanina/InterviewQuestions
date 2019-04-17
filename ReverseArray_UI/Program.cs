using ReverseArray;
using System;

namespace ReverseArray_UI
{
    class Program
    {
        static void Main()
        {
            int length;
            string[] array;
            ReverseService reverseService = new ReverseService();

            while (true)
            {
                Console.WriteLine("Please enter length of array");
                Int32.TryParse(Console.ReadLine(), out length);
                if (length > 0) break;
            }

            while (true)
            {
                Console.WriteLine("Please enter the array - separate elements using spaces");

                array = Console.ReadLine().Split(" ");
                //There was no requirement about the type of elements. 
                //Hence, the assumption that empty elements are ok.
                if (array.Length != length)
                {
                    Console.WriteLine("The provided length in not equal to the given array");
                }
                else break;
            }

            reverseService.Reverse(array);

            //String.Join will not perform the best from memory performance point of view. 
            //It could be just a loop with Console.Write for better memory performance. 
            //However, with String.Join the readability is better.
            Console.WriteLine(String.Join(" ", array));

            Console.Read();
        }
    }
}
