using System;
using System.Linq;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Set up of the collection

            Console.Write("Enter the size of the collection : ");
            string input = null;
            int length = 0;
            while ((input = Console.ReadLine()) != null)
            {
                try
                {
                    length = int.Parse(input);
                }
                catch
                {
                    continue;
                }
                break;
            }

            int[] intArray = new int[length];

            for (int i = 0; i < intArray.Length; i++)
            {

                Console.Write($"Enter the n:{i+1} element :");
                intArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = 0; j < intArray.Length - i - 1; j++)
                {
                    Console.WriteLine($"{intArray[j]} > {intArray[j+1]}");
                    if (intArray[j] > intArray[j + 1])
                    {
                        // swap
                        int temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                    }
                }
            }

            Array.ForEach(intArray, x => System.Console.Write($"{x} "));




        }


    }
}
