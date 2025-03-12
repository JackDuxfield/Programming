```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5555/22H2/2022Update)
AMD Ryzen 9 5900HX with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  Job-NGDDCO : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2

IterationCount=10  

```
| Method           | Mean            | Error         | StdDev        | Median          | Gen0   | Allocated |
|----------------- |----------------:|--------------:|--------------:|----------------:|-------:|----------:|
| Do               |       0.0096 ns |     0.0200 ns |     0.0133 ns |       0.0026 ns |      - |         - |
| ArraySort        | 319,936.1133 ns | 1,603.3018 ns | 1,060.4849 ns | 320,000.0977 ns | 4.3945 |   40024 B |
| ListSort         | 320,729.6729 ns | 2,071.7756 ns | 1,370.3513 ns | 320,712.7930 ns | 4.3945 |   40056 B |
| TestLinearSearch | 116,409.8462 ns | 3,105.0026 ns | 2,053.7670 ns | 115,956.7261 ns |      - |      32 B |
