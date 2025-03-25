using System;
using System.Linq;

public class NumberGenerator
{
    public static int[] GenerateNumbers(int size, int min = 1, int max = 1000)
    {
        Random rand = new Random();
        return Enumerable.Range(0, size).Select(_ => rand.Next(min, max)).ToArray();
    }

    public static void PrintNumbers(int[] numbers)
    {
        Console.WriteLine("\nGeneriran spisuk:");
        Console.WriteLine(string.Join(", ", numbers));
    }
}