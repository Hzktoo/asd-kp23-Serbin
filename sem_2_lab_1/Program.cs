using System;
class Program
{
    static bool testElemWhichWillSort()
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
    static bool testMySort()
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
        int N = 0;
        int n = N / 2;
        int[] arr = GenerateRandomArray(N);
        PrintArray(arr);
        PrintColoredArray(arr);
        int[] arr2 = ElemWhichWillSort(arr, n);
        PrintSortedArray(arr2);
        PrintUnsortedArray(arr);
    }
    static int[] GenerateRandomArray(int N)
    {
        int[] arr = new int[N];
        return arr;
    }
    static void PrintArray(int[] arr)
    {
        Console.WriteLine(arr);
    }
    static void PrintColoredArray(int[] arr)
    {
        Console.WriteLine(arr);
    }
    static int[] ElemWhichWillSort(int[] arr, int n)
    {
        int[] arr2 = arr;
        return arr2;
    }
    static void PrintSortedArray(int[] arr)
    {
        arr = MySort(arr);
        Console.WriteLine(arr);
    }
    static void PrintUnsortedArray(int[] arr)
    {
        Console.WriteLine(arr);
    }
    static int[] MySort(int[] arr)
    {
        return arr;
    }
    static void Exchanelem(ref int arr1, ref int arr2)
    {
        var temp = arr1;
        arr1 = arr2;
        arr2 = temp;
    }
}