```

BenchmarkDotNet v0.13.10, macOS Sonoma 14.1 (23B74) [Darwin 23.1.0]
Apple M2, 1 CPU, 8 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), Arm64 RyuJIT AdvSIMD
  .NET 6.0 : .NET 6.0.18 (6.0.1823.26907), Arm64 RyuJIT AdvSIMD
  .NET 7.0 : .NET 7.0.7 (7.0.723.27404), Arm64 RyuJIT AdvSIMD
  .NET 8.0 : .NET 8.0.0 (8.0.23.53103), Arm64 RyuJIT AdvSIMD


```
| Method  | Job      | Runtime  | Mean       | Error   | StdDev  | Ratio | Allocated | Alloc Ratio |
|-------- |--------- |--------- |-----------:|--------:|--------:|------:|----------:|------------:|
| ComSpan | .NET 6.0 | .NET 6.0 |   891.5 ns | 6.22 ns | 5.82 ns |  1.03 |         - |          NA |
| ComSpan | .NET 7.0 | .NET 7.0 |   728.6 ns | 1.17 ns | 1.04 ns |  0.84 |         - |          NA |
| ComSpan | .NET 8.0 | .NET 8.0 |   865.4 ns | 0.25 ns | 0.23 ns |  1.00 |         - |          NA |
|         |          |          |            |         |         |       |           |             |
| SemSpan | .NET 6.0 | .NET 6.0 | 1,096.0 ns | 0.44 ns | 0.41 ns |  1.31 |         - |          NA |
| SemSpan | .NET 7.0 | .NET 7.0 |   837.6 ns | 0.52 ns | 0.43 ns |  1.00 |         - |          NA |
| SemSpan | .NET 8.0 | .NET 8.0 |   837.8 ns | 0.47 ns | 0.44 ns |  1.00 |         - |          NA |
