using System;

class Program
{
    static void Main()
    {
        Console.Write("input M: ");
        int M = int.Parse(Console.ReadLine()!);

        Console.Write("input N: ");
        int N = int.Parse(Console.ReadLine()!);

        Console.WriteLine("natural numbers:");
        Console.Write('\"' + PrintNumbers(M, N) + '\"');
    }

    static string PrintNumbers(int first, int final)
    {
        string numbers = first.ToString();

        if (first != final)
        {
            numbers += ", " + PrintNumbers(first + 1, final);
        }

        return numbers;
    }
}