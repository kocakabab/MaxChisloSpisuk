using System;

class Program
{
    static void Main()
    {

        int[] numbers = NumberGenerator.GenerateNumbers(20);
        NumberGenerator.PrintNumbers(numbers);

        int globalMax = ParallelMaxFinder.FindMaxParallel(numbers);

        Console.WriteLine($"\nNai-golqmoto chislo e: {globalMax}");
        Console.WriteLine("\nProekta e zavurshen");
    }
}
