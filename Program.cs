namespace HashingAlgorithm;


public class Program
{
    public static void Main(string[] args)
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

        Console.ReadKey();
    }   
}
    