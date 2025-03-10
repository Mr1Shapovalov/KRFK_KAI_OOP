using System;
namespace LAB_9
{
    class Program
    {
        static void BubbleSort(int[] arr, out int swapCount)
        {
            int n = arr.Length;
            swapCount = 0;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1]) 
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        swapped = true;
                        swapCount++; 
                    }
                }
                if (!swapped) break; 
            }
        }
        static void Main()
        {
            int[] numbers = { 8, 5, 2, 9, 1, 5, 6 };
            int swapCount;
            BubbleSort(numbers, out swapCount);
            Console.WriteLine($"Number of swaps: {swapCount}");
            Console.WriteLine("After sorting: " + string.Join(", ", numbers));
        }
    }
}

