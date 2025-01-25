using System.IO.Hashing;
using System.Security.Cryptography;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace HashingAlgorithm;

public class HasherBenchmarks
{
    private const string Input = "This is a sample input for benchmarking.";
    private static readonly byte[] InputBytes = Encoding.UTF8.GetBytes(Input);

    [Benchmark]
    public ulong AdvancedHasherBenchmark()
    {
        return AdvancedHasher.ComputeHash(Input);
    }

    [Benchmark]
    public string Md5Benchmark()
    {
        using var md5 = MD5.Create();
        var hash = md5.ComputeHash(InputBytes);
        return Convert.ToHexString(hash);
    }
    
    [Benchmark]
    public string Crc64Benchmark()
    {
        var hash = Crc64.Hash(InputBytes);
        return Convert.ToHexString(hash);
    }
}