using System;

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

                Console.Write("Enter the Array Elements :");
                intArray[i] = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("end");


        }
    }
}
