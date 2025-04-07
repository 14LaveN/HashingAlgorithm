```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3194)
AMD Ryzen 5 3600, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.100-rc.1.24452.12
  [Host]     : .NET 9.0.0 (9.0.24.43107), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 9.0.0 (9.0.24.43107), X64 RyuJIT AVX2


```
| Method                  | Mean      | Error     | StdDev    |
|------------------------ |----------:|----------:|----------:|
| AdvancedHasherBenchmark |  37.64 ns |  0.777 ns |  0.895 ns |
| Md5Benchmark            | 632.21 ns | 12.716 ns | 24.802 ns |
| Crc64Benchmark          |  38.79 ns |  0.811 ns |  0.902 ns |
