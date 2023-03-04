using System;
class Program
{
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