using System;
using System.Linq;

namespace Sorting
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Enter the size of the collection : ");
            string input = null;
            int length = 0;
            while ((input = Console.ReadLine()) != null)
            {
                try
                {
                    length = int.Parse(input);
                    if (length < 0)
                    {
                        Console.Write("Enter the size of the collection : ");
                        continue;
                    }
                }
                catch
                {
                    Console.Write("Enter the size of the collection : ");
                    continue;
                }
                break;
            }
            int[] arr;
            if (ReadInput(out arr, length) == false)
            {
                return;
            }



            BubbleSort(arr);
            PrintResult(arr, "BubbleSort");


            BubbleSortRecursive(arr, length);
            PrintResult(arr, "BubbleSortRecursive");
        }

        static void PrintResult(int[] arr, string algoName)
        {
            System.Console.WriteLine($"=> {algoName} <=");
            Array.ForEach(arr, x => System.Console.Write($"{x} "));
            System.Console.WriteLine("\n");
        }

        static bool ReadInput(out int[] arr, int length)
        {
            arr = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {

                Console.Write($"Enter element({i + 1}): ");
                try
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                catch
                {
                    System.Console.WriteLine("Invalid input, please try again!");
                    return false;
                }
            }
            return true;
        }



        static void BubbleSort(int[] arr)
        {
            // Bubble sort
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap
                        swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        static void BubbleSortRecursive(int[] arr, int n)
        {
            // Base case
            if (n == 1)
                return;

            for (int i = 0; i < n - 1; i++)
                if (arr[i] < arr[i + 1])
                    swap(ref arr[i], ref arr[i + 1]);

            BubbleSortRecursive(arr, n - 1);
        }
        static void swap(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }

    }
}
