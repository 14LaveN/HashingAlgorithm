using BenchmarkDotNet.Running;

namespace HashingAlgorithm;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter text to hash:");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Hash: Error");
            return;
        }

        ulong hash = AdvancedHasher.ComputeHash(input);
        Console.WriteLine($"Hash: {hash}");
        
        BenchmarkRunner.Run<HasherBenchmarks>();

        Console.ReadKey();
    }   
}
    