using System;
using System.Linq;
using System.Threading.Tasks;

public class ParallelMaxFinder
{
    public static int FindMaxParallel(int[] numbers)
    {
        int maxThreads = Environment.ProcessorCount;
        int[] localMax = new int[maxThreads];

        for (int i = 0; i < maxThreads; i++)
            localMax[i] = int.MinValue;

        int chunkSize = (int)Math.Ceiling(numbers.Length / (double)maxThreads);

        Parallel.For(0, maxThreads, i =>
        {
            int start = i * chunkSize;
            int end = Math.Min(start + chunkSize, numbers.Length);

            for (int j = start; j < end; j++)
            {
                if (numbers[j] > localMax[i])
                    localMax[i] = numbers[j];
            }
        });

        return localMax.Max();
    }
}