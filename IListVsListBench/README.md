```
// * Summary *

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22631.1835)
11th Gen Intel Core i9-11950H 2.60GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


| Method |     Mean |    Error |   StdDev | Ratio | RatioSD |
|------- |---------:|---------:|---------:|------:|--------:|
|   List | 16.98 us | 0.328 us | 0.337 us |  1.00 |    0.00 |
|  IFace | 18.99 us | 0.198 us | 0.186 us |  1.12 |    0.03 |

// * Hints *
Outliers
  Bench.List: Default -> 1 outlier  was  removed (18.03 us)
```