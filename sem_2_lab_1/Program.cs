using System;
class Program
{
    static bool TestElemWhichWillSort()
    {
        int n = 5;
        int[] testgrid1 = { 9, 12, 3, 5, 4, 7, 11, 18, 1, 8 };
        int[] result1 = { 3, 4, 1 };
        int[] testgrid2 = { 1, 5, 23, 12, 9, 3, 6, 10, 63, 17 };
        int[] result2 = { 1, 3 };
        int[] testgrid3 = { 56, 62, 15, 8, 23, 18, 42, 2, 91, 30 };
        int[] result3 = {2};
        if (result1 != ElemWhichWillSort(testgrid1, n) || result2 != ElemWhichWillSort(testgrid2, n) || result3 != ElemWhichWillSort(testgrid3, n))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    static bool TestMySort()
    {
        int[] testgrid1 = { 9, 12, 3, 5, 4, 7, 11, 18, 1, 8 };
        int[] result1 = { 18, 12, 11, 9, 8, 7, 5, 4, 3, 1 };
        int[] testgrid2 = { 1, 5, 23, 12, 9, 3, 6, 10, 63, 17 };
        int[] result2 = { 63, 23, 17, 12, 10, 9, 6, 5, 3, 1 };
        int[] testgrid3 = { 56, 62, 15, 8, 23, 18, 42, 2, 91, 30 };
        int[] result3 = { 91, 62, 56, 42, 30, 23, 18, 15, 8, 2 };
        if (result1 != MySort(testgrid1) || result2 != MySort(testgrid2) || result3 != MySort(testgrid3))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of array:");
        int N = int.Parse(Console.ReadLine());
        if (N <= 0)
        {
            Console.WriteLine("Please, enter a positive size");
            return;
        }
        int n = N / 2;
        int[] arr = GenerateRandomArray(N);
        Console.WriteLine("Generated array:");
        PrintArray(arr);
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Colored array:");
        PrintColoredArray(arr);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Sorted array:");
        int[] arr2 = ElemWhichWillSort(arr, n);
        PrintSortedArray(arr2);
        PrintUnsortedArray(arr);
    }
    static int[] GenerateRandomArray(int N)
    {
        int[] arr = new int[N];
        Random random = new Random();
        for (int i = 0; i < N; i++)
        {
            arr[i] = random.Next(0, N);
        }
        return arr;
    }
    static void PrintArray(int[] arr)
    {
        int N = arr.Length;
        for (int i = 0; i < N; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    static void PrintColoredArray(int[] arr)
    {
        int N = arr.Length;
        int n = arr.Length / 2;
        for (int i = 0; i < N; i++)
        {
            if (arr[i] >= n)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write(arr[i] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
    static int[] ElemWhichWillSort(int[] arr, int n)
    {
        int count = 0;
        int N = arr.Length;
        for (int i = 0; i < N; i++)
        {
            if (arr[i] < n)
            {
                count++;
            }
        }
        int[] arr2 = new int[count];
        int index = 0;
        for (int i = 0; i < N; i++)
        {
            if (arr[i] < n)
            {
                arr2[index] = arr[i];
                index++;
            }
        }
        return arr2;
    }
    static void PrintSortedArray(int[] arr)
    {
        arr = MySort(arr);
        int N = arr.Length;
        for (int i = 0; i < N; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
    static void PrintUnsortedArray(int[] arr)
    {
        int N = arr.Length;
        int n = N / 2;
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] >= n)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(arr[i] + " ");
            }
            Console.ResetColor();
        }
        Console.WriteLine();
    }
    static int[] MySort(int[] arr)
    {
        int N = arr.Length;
        bool wasExchange = false;
        for (int i = 0; i < N / 2; i++)
        {
            for (int j = i; j < N - i - 1; j++)
            {
                if (arr[j] < arr[j + 1])
                {
                    Exchanelem(ref arr[j], ref arr[j + 1]);
                    wasExchange = true;
                }
            }
            for (int j = N - 2 - i; j > i; j--)
            {
                if (arr[j - 1] < arr[j])
                {
                    Exchanelem(ref arr[j - 1], ref arr[j]);
                    wasExchange = true;
                }
            }
            if (!wasExchange)
            {
                break;
            }
        }
        return arr;
    }
    static void Exchanelem(ref int arr1, ref int arr2)
    {
        int temp = arr1;
        arr1 = arr2;
        arr2 = temp;
    }
}