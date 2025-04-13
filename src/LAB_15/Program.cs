using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
class LAB_15 
{
    // Task 1: 
    static void PrintNumbers()
    {
        for (int i = 1; i <= 500; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }
    static long CalculateFactorial(int n)
    {
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        Console.WriteLine($"\nFactorial of {n} = {result}");
        return result;
    }
    static void TaskWithParallelInvoke()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        Parallel.Invoke(
            () => PrintNumbers(),
            () => CalculateFactorial(10)
        );
        stopwatch.Stop();
        Console.WriteLine($"\nExecution time: {stopwatch.ElapsedMilliseconds} ms");
    }
    // Task 2: 
    static void RaceConditionExample()
    {
        int counter1 = 0;
        Parallel.For(0, 1000, i =>
        {
            counter1++;
        });
        Console.WriteLine($"Without protection: {counter1} (expected 1000)");
        int counter2 = 0;
        object locker = new object();
        Parallel.For(0, 1000, i =>
        {
            lock (locker)
            {
                counter2++;
            }
        });
        Console.WriteLine($"With lock: {counter2}");
        int counter3 = 0;
        Parallel.For(0, 1000, i =>
        {
            Interlocked.Increment(ref counter3);
        });
        Console.WriteLine($"With Interlocked.Increment: {counter3}");
    }
    static void Main()
    {
        TaskWithParallelInvoke(); // Task 1
        RaceConditionExample(); // Task 2
    }
}
