```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2894)
AMD Ryzen 5 3600, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.100-rc.1.24452.12
  [Host]     : .NET 9.0.0 (9.0.24.43107), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 9.0.0 (9.0.24.43107), X64 RyuJIT AVX2


```
| Method                  | Mean      | Error    | StdDev   |
|------------------------ |----------:|---------:|---------:|
| AdvancedHasherBenchmark |  35.95 ns | 0.196 ns | 0.153 ns |
| Md5Benchmark            | 591.82 ns | 9.221 ns | 8.625 ns |
| Crc64Benchmark          |  38.11 ns | 0.810 ns | 0.995 ns |
