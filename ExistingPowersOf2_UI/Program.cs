using ExistingPowersOf2;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExistingPowersOf2_UI
{
    class Program
    {
        static void Main()
        {
         
            UInt32 variable;
            ExistingPowersOf2Service existingPowersOf2Service = new ExistingPowersOf2Service();

            Console.WriteLine("Please insert variables seperated by enters.");
            Console.WriteLine("To see the results type anything except number.");
            while (true)
            {
                if(UInt32.TryParse(Console.ReadLine(), out variable))
                {
                    existingPowersOf2Service.Decompose(variable);
                }
                else
                    break;
            }
            PrintResult(existingPowersOf2Service.GetResult());

        }

        static void PrintResult(ICollection<UInt32> result)
        {
            if(result.Count==0)
                Console.WriteLine("NA");

            Console.WriteLine(String.Join(", ", result));
            Console.Read();
        }
    }
}
