using System;

class Program
{
    static void ReverseArrayPr(int[] arr, int i)
    {
        if (i >= 0)
        {
            if (i != arr.Length - 1)
            {
                Console.Write(", ");
            }
            Console.Write(arr[i]);
            ReverseArrayPr(arr, i - 1);
        }
    }

    static void Main(string[] args)
    {
        int[] arr = {15, 42, 63, 78, 90};
        
        Console.Write("ReverseResult: ");
        ReverseArrayPr(arr, arr.Length - 1);
        Console.WriteLine("");
    }
}