``` txt
BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1265/22H2/2022Update/SunValley2)
Intel Core i9-9900K CPU 3.60GHz (Coffee Lake), 1 CPU, 16 logical and 8 physical cores
.NET SDK=8.0.100-preview.1.23115.2
  [Host]   : .NET 8.0.0 (8.0.23.11008), X64 RyuJIT AVX2
  .NET 6.0 : .NET 6.0.14 (6.0.1423.7309), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2
  .NET 8.0 : .NET 8.0.0 (8.0.23.11008), X64 RyuJIT AVX2
```

|               Method |      Job |  Runtime |     Categories | SegmentLength |        Mean |     Error |     StdDev | Ratio | RatioSD |
|--------------------- |--------- |--------- |--------------- |-------------- |------------:|----------:|-----------:|------:|--------:|
|        SystemAdvance | .NET 6.0 | .NET 6.0 |        Advance |         -1024 |    1.148 us | 0.0107 us |   1.147 us |  1.00 |    0.00 |
|        CustomAdvance | .NET 6.0 | .NET 6.0 |        Advance |         -1024 |    1.363 us | 0.0157 us |   1.356 us |  1.19 |    0.01 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemAdvance | .NET 6.0 | .NET 6.0 |        Advance |             4 |    4.216 us | 0.0801 us |   4.194 us |  1.00 |    0.00 |
|        CustomAdvance | .NET 6.0 | .NET 6.0 |        Advance |             4 |    3.431 us | 0.0631 us |   3.417 us |  0.81 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemAdvance | .NET 6.0 | .NET 6.0 |        Advance |           128 |    1.300 us | 0.0206 us |   1.301 us |  1.00 |    0.00 |
|        CustomAdvance | .NET 6.0 | .NET 6.0 |        Advance |           128 |    1.481 us | 0.0135 us |   1.480 us |  1.14 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemAdvance | .NET 6.0 | .NET 6.0 |        Advance |          1024 |    1.150 us | 0.0171 us |   1.149 us |  1.00 |    0.00 |
|        CustomAdvance | .NET 6.0 | .NET 6.0 |        Advance |          1024 |    1.357 us | 0.0117 us |   1.355 us |  1.18 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
| SystemAdvancePastAny | .NET 6.0 | .NET 6.0 | AdvancePastAny |         -1024 |   552.85 ns | 10.176 ns |   9.519 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 6.0 | .NET 6.0 | AdvancePastAny |         -1024 |   491.16 ns |  9.523 ns |  11.695 ns |  0.89 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
| SystemAdvancePastAny | .NET 6.0 | .NET 6.0 | AdvancePastAny |             4 | 3,271.24 ns | 41.743 ns |  39.047 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 6.0 | .NET 6.0 | AdvancePastAny |             4 | 3,041.88 ns | 35.820 ns |  33.506 ns |  0.93 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
| SystemAdvancePastAny | .NET 6.0 | .NET 6.0 | AdvancePastAny |           128 |   836.74 ns | 16.583 ns |  15.511 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 6.0 | .NET 6.0 | AdvancePastAny |           128 |   646.96 ns | 11.025 ns |  10.313 ns |  0.77 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
| SystemAdvancePastAny | .NET 6.0 | .NET 6.0 | AdvancePastAny |          1024 |   541.98 ns |  6.899 ns |   6.116 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 6.0 | .NET 6.0 | AdvancePastAny |          1024 |   482.04 ns |  8.686 ns |   8.125 ns |  0.89 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
|       SystemPosition | .NET 6.0 | .NET 6.0 |       Position |         -1024 | 1,206.02 ns | 23.725 ns |  26.370 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 6.0 | .NET 6.0 |       Position |         -1024 |   366.50 ns |  7.134 ns |  10.232 ns |  0.31 |    0.01 |
|                      |          |          |                |               |             |           |            |       |         |
|       SystemPosition | .NET 6.0 | .NET 6.0 |       Position |             4 | 2,978.86 ns | 19.441 ns |  18.185 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 6.0 | .NET 6.0 |       Position |             4 |   490.45 ns |  0.910 ns |   0.760 ns |  0.16 |    0.00 |
|                      |          |          |                |               |             |           |            |       |         |
|       SystemPosition | .NET 6.0 | .NET 6.0 |       Position |           128 | 2,904.62 ns | 34.240 ns |  30.353 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 6.0 | .NET 6.0 |       Position |           128 |   458.79 ns |  7.812 ns |   6.925 ns |  0.16 |    0.00 |
|                      |          |          |                |               |             |           |            |       |         |
|       SystemPosition | .NET 6.0 | .NET 6.0 |       Position |          1024 | 1,174.63 ns |  8.030 ns |   7.119 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 6.0 | .NET 6.0 |       Position |          1024 |   453.84 ns |  3.327 ns |   3.112 ns |  0.39 |    0.00 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryPeek | .NET 6.0 | .NET 6.0 |        TryPeek |         -1024 |   744.37 ns |  5.769 ns |   5.114 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 6.0 | .NET 6.0 |        TryPeek |         -1024 |   633.54 ns |  8.084 ns |   7.561 ns |  0.85 |    0.01 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryPeek | .NET 6.0 | .NET 6.0 |        TryPeek |             4 |   743.34 ns |  8.797 ns |   7.346 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 6.0 | .NET 6.0 |        TryPeek |             4 |   646.94 ns | 12.953 ns |  18.577 ns |  0.88 |    0.03 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryPeek | .NET 6.0 | .NET 6.0 |        TryPeek |           128 |   747.71 ns | 12.951 ns |  12.114 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 6.0 | .NET 6.0 |        TryPeek |           128 |   636.12 ns | 12.348 ns |  11.550 ns |  0.85 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryPeek | .NET 6.0 | .NET 6.0 |        TryPeek |          1024 |   731.16 ns |  4.199 ns |   3.928 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 6.0 | .NET 6.0 |        TryPeek |          1024 |   616.01 ns |  0.792 ns |   0.618 ns |  0.84 |    0.00 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryRead | .NET 6.0 | .NET 6.0 |        TryRead |         -1024 | 1,562.38 ns |  6.278 ns |   5.243 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 6.0 | .NET 6.0 |        TryRead |         -1024 | 1,342.84 ns |  1.445 ns |   1.281 ns |  0.86 |    0.00 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryRead | .NET 6.0 | .NET 6.0 |        TryRead |             4 | 3,980.50 ns | 61.784 ns |  57.792 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 6.0 | .NET 6.0 |        TryRead |             4 | 2,834.91 ns | 14.719 ns |  12.291 ns |  0.71 |    0.01 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryRead | .NET 6.0 | .NET 6.0 |        TryRead |           128 | 1,719.42 ns | 33.563 ns |  38.651 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 6.0 | .NET 6.0 |        TryRead |           128 | 1,479.84 ns |  7.696 ns |   6.822 ns |  0.85 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryRead | .NET 6.0 | .NET 6.0 |        TryRead |          1024 | 1,562.17 ns |  7.593 ns |   6.731 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 6.0 | .NET 6.0 |        TryRead |          1024 | 1,341.58 ns |  1.561 ns |   1.219 ns |  0.86 |    0.00 |
|                      |          |          |                |               |             |           |            |       |         |
|      SystemTryReadTo | .NET 6.0 | .NET 6.0 |      TryReadTo |         -1024 |   290.15 ns |  4.439 ns |   4.152 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 6.0 | .NET 6.0 |      TryReadTo |         -1024 |   263.15 ns |  0.749 ns |   0.585 ns |  0.91 |    0.01 |
|                      |          |          |                |               |             |           |            |       |         |
|      SystemTryReadTo | .NET 6.0 | .NET 6.0 |      TryReadTo |             4 | 3,233.55 ns | 24.345 ns |  20.329 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 6.0 | .NET 6.0 |      TryReadTo |             4 | 2,989.38 ns | 38.242 ns |  39.272 ns |  0.93 |    0.01 |
|                      |          |          |                |               |             |           |            |       |         |
|      SystemTryReadTo | .NET 6.0 | .NET 6.0 |      TryReadTo |           128 |   383.30 ns |  7.589 ns |   7.793 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 6.0 | .NET 6.0 |      TryReadTo |           128 |   334.67 ns |  4.586 ns |   3.830 ns |  0.87 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
|      SystemTryReadTo | .NET 6.0 | .NET 6.0 |      TryReadTo |          1024 |   265.24 ns |  3.725 ns |   3.484 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 6.0 | .NET 6.0 |      TryReadTo |          1024 |   294.39 ns |  5.064 ns |   4.974 ns |  1.11 |    0.03 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemAdvance | .NET 6.0 | .NET 6.0 |        Advance |          1024 |    1.150 us | 0.0171 us |   1.149 us |  1.00 |    0.00 |
|        CustomAdvance | .NET 6.0 | .NET 6.0 |        Advance |          1024 |    1.357 us | 0.0117 us |   1.355 us |  1.18 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemAdvance | .NET 7.0 | .NET 7.0 |        Advance |         -1024 |    1.158 us | 0.0214 us |   1.162 us |  1.00 |    0.00 |
|        CustomAdvance | .NET 7.0 | .NET 7.0 |        Advance |         -1024 |    1.229 us | 0.0139 us |   1.225 us |  1.06 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemAdvance | .NET 7.0 | .NET 7.0 |        Advance |             4 |    3.922 us | 0.0673 us |   3.908 us |  1.00 |    0.00 |
|        CustomAdvance | .NET 7.0 | .NET 7.0 |        Advance |             4 |    3.030 us | 0.0524 us |   3.018 us |  0.77 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemAdvance | .NET 7.0 | .NET 7.0 |        Advance |           128 |    1.507 us | 0.0182 us |   1.505 us |  1.00 |    0.00 |
|        CustomAdvance | .NET 7.0 | .NET 7.0 |        Advance |           128 |    1.151 us | 0.0218 us |   1.133 us |  0.78 |    0.03 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemAdvance | .NET 7.0 | .NET 7.0 |        Advance |          1024 |    1.172 us | 0.0218 us |   1.163 us |  1.00 |    0.00 |
|        CustomAdvance | .NET 7.0 | .NET 7.0 |        Advance |          1024 |    1.140 us | 0.0221 us |   1.139 us |  0.97 |    0.04 |
|                      |          |          |                |               |             |           |            |       |         |
| SystemAdvancePastAny | .NET 7.0 | .NET 7.0 | AdvancePastAny |         -1024 |   862.42 ns | 17.110 ns |  32.136 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 7.0 | .NET 7.0 | AdvancePastAny |         -1024 |   928.85 ns |  9.950 ns |   8.309 ns |  1.09 |    0.05 |
|                      |          |          |                |               |             |           |            |       |         |
| SystemAdvancePastAny | .NET 7.0 | .NET 7.0 | AdvancePastAny |             4 | 3,473.60 ns | 48.677 ns |  45.533 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 7.0 | .NET 7.0 | AdvancePastAny |             4 | 2,970.50 ns | 40.920 ns |  38.276 ns |  0.86 |    0.01 |
|                      |          |          |                |               |             |           |            |       |         |
| SystemAdvancePastAny | .NET 7.0 | .NET 7.0 | AdvancePastAny |           128 |   882.79 ns | 13.582 ns |  21.932 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 7.0 | .NET 7.0 | AdvancePastAny |           128 | 1,038.76 ns | 20.344 ns |  19.981 ns |  1.18 |    0.04 |
|                      |          |          |                |               |             |           |            |       |         |
| SystemAdvancePastAny | .NET 7.0 | .NET 7.0 | AdvancePastAny |          1024 |   777.15 ns | 14.996 ns |  13.293 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 7.0 | .NET 7.0 | AdvancePastAny |          1024 |   915.26 ns | 10.451 ns |   9.264 ns |  1.18 |    0.03 |
|                      |          |          |                |               |             |           |            |       |         |
|       SystemPosition | .NET 7.0 | .NET 7.0 |       Position |         -1024 | 1,064.98 ns |  8.800 ns |   7.348 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 7.0 | .NET 7.0 |       Position |         -1024 |   294.31 ns |  4.227 ns |   3.954 ns |  0.28 |    0.00 |
|                      |          |          |                |               |             |           |            |       |         |
|       SystemPosition | .NET 7.0 | .NET 7.0 |       Position |             4 | 2,938.00 ns | 16.304 ns |  14.453 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 7.0 | .NET 7.0 |       Position |             4 |   320.54 ns |  1.733 ns |   1.447 ns |  0.11 |    0.00 |
|                      |          |          |                |               |             |           |            |       |         |
|       SystemPosition | .NET 7.0 | .NET 7.0 |       Position |           128 | 2,457.86 ns | 23.237 ns |  21.736 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 7.0 | .NET 7.0 |       Position |           128 |   291.03 ns |  2.969 ns |   2.632 ns |  0.12 |    0.00 |
|                      |          |          |                |               |             |           |            |       |         |
|       SystemPosition | .NET 7.0 | .NET 7.0 |       Position |          1024 | 1,076.13 ns | 15.774 ns |  14.755 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 7.0 | .NET 7.0 |       Position |          1024 |   289.30 ns |  0.883 ns |   0.783 ns |  0.27 |    0.00 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryPeek | .NET 7.0 | .NET 7.0 |        TryPeek |         -1024 |   682.26 ns |  7.043 ns |   6.243 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 7.0 | .NET 7.0 |        TryPeek |         -1024 |   904.33 ns |  7.189 ns |   6.725 ns |  1.33 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryPeek | .NET 7.0 | .NET 7.0 |        TryPeek |             4 |   694.92 ns | 13.460 ns |  14.402 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 7.0 | .NET 7.0 |        TryPeek |             4 |   907.40 ns | 12.752 ns |  11.928 ns |  1.30 |    0.03 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryPeek | .NET 7.0 | .NET 7.0 |        TryPeek |           128 |   684.61 ns |  8.489 ns |   7.941 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 7.0 | .NET 7.0 |        TryPeek |           128 |   899.38 ns | 10.848 ns |   9.617 ns |  1.32 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryPeek | .NET 7.0 | .NET 7.0 |        TryPeek |          1024 |   673.62 ns |  2.386 ns |   2.232 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 7.0 | .NET 7.0 |        TryPeek |          1024 |   894.66 ns |  3.812 ns |   3.566 ns |  1.33 |    0.01 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryRead | .NET 7.0 | .NET 7.0 |        TryRead |         -1024 | 1,552.72 ns |  2.209 ns |   1.958 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 7.0 | .NET 7.0 |        TryRead |         -1024 | 1,136.84 ns |  6.822 ns |   6.047 ns |  0.73 |    0.00 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryRead | .NET 7.0 | .NET 7.0 |        TryRead |             4 | 3,940.47 ns | 29.446 ns |  27.544 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 7.0 | .NET 7.0 |        TryRead |             4 | 2,464.97 ns | 20.002 ns |  16.702 ns |  0.63 |    0.01 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryRead | .NET 7.0 | .NET 7.0 |        TryRead |           128 | 1,680.41 ns | 10.345 ns |   9.171 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 7.0 | .NET 7.0 |        TryRead |           128 | 1,248.40 ns |  6.563 ns |   5.818 ns |  0.74 |    0.01 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryRead | .NET 7.0 | .NET 7.0 |        TryRead |          1024 | 1,561.57 ns |  9.340 ns |   7.800 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 7.0 | .NET 7.0 |        TryRead |          1024 | 1,128.56 ns |  5.116 ns |   4.535 ns |  0.72 |    0.00 |
|                      |          |          |                |               |             |           |            |       |         |
|      SystemTryReadTo | .NET 7.0 | .NET 7.0 |      TryReadTo |         -1024 |   105.53 ns |  0.724 ns |   0.642 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 7.0 | .NET 7.0 |      TryReadTo |         -1024 |    95.17 ns |  1.905 ns |   1.956 ns |  0.90 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
|      SystemTryReadTo | .NET 7.0 | .NET 7.0 |      TryReadTo |             4 | 3,263.36 ns | 43.251 ns |  40.457 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 7.0 | .NET 7.0 |      TryReadTo |             4 | 2,752.51 ns | 54.318 ns |  62.552 ns |  0.85 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
|      SystemTryReadTo | .NET 7.0 | .NET 7.0 |      TryReadTo |           128 |   177.88 ns |  2.285 ns |   2.026 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 7.0 | .NET 7.0 |      TryReadTo |           128 |   159.48 ns |  2.895 ns |   2.417 ns |  0.90 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
|      SystemTryReadTo | .NET 7.0 | .NET 7.0 |      TryReadTo |          1024 |   108.54 ns |  1.449 ns |   1.355 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 7.0 | .NET 7.0 |      TryReadTo |          1024 |   103.87 ns |  1.167 ns |   1.091 ns |  0.96 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemAdvance | .NET 8.0 | .NET 8.0 |        Advance |         -1024 |    1.146 us | 0.0186 us |  0.0165 us |  1.00 |    0.00 |
|        CustomAdvance | .NET 8.0 | .NET 8.0 |        Advance |         -1024 |    1.347 us | 0.0191 us |  0.0196 us |  1.18 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemAdvance | .NET 8.0 | .NET 8.0 |        Advance |             4 |    3.681 us | 0.0446 us |  0.0395 us |  1.00 |    0.00 |
|        CustomAdvance | .NET 8.0 | .NET 8.0 |        Advance |             4 |    3.206 us | 0.0616 us |  0.0757 us |  0.87 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemAdvance | .NET 8.0 | .NET 8.0 |        Advance |           128 |    1.281 us | 0.0164 us |  0.0154 us |  1.00 |    0.00 |
|        CustomAdvance | .NET 8.0 | .NET 8.0 |        Advance |           128 |    1.433 us | 0.0132 us |  0.0124 us |  1.12 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemAdvance | .NET 8.0 | .NET 8.0 |        Advance |          1024 |    1.170 us | 0.0230 us |  0.0265 us |  1.00 |    0.00 |
|        CustomAdvance | .NET 8.0 | .NET 8.0 |        Advance |          1024 |    1.353 us | 0.0270 us |  0.0252 us |  1.16 |    0.03 |
|                      |          |          |                |               |             |           |            |       |         |
| SystemAdvancePastAny | .NET 8.0 | .NET 8.0 | AdvancePastAny |         -1024 |   923.02 ns | 16.895 ns |  15.803 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 8.0 | .NET 8.0 | AdvancePastAny |         -1024 |   483.57 ns |  9.582 ns |  10.650 ns |  0.53 |    0.01 |
|                      |          |          |                |               |             |           |            |       |         |
| SystemAdvancePastAny | .NET 8.0 | .NET 8.0 | AdvancePastAny |             4 | 3,252.70 ns | 45.092 ns |  39.973 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 8.0 | .NET 8.0 | AdvancePastAny |             4 | 2,930.17 ns | 55.844 ns |  57.348 ns |  0.90 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
| SystemAdvancePastAny | .NET 8.0 | .NET 8.0 | AdvancePastAny |           128 | 1,032.00 ns |  8.626 ns |   6.735 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 8.0 | .NET 8.0 | AdvancePastAny |           128 |   636.44 ns |  7.899 ns |   7.388 ns |  0.62 |    0.01 |
|                      |          |          |                |               |             |           |            |       |         |
| SystemAdvancePastAny | .NET 8.0 | .NET 8.0 | AdvancePastAny |          1024 |   912.27 ns | 10.287 ns |   9.623 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 8.0 | .NET 8.0 | AdvancePastAny |          1024 |   472.82 ns |  5.715 ns |   5.067 ns |  0.52 |    0.01 |
|                      |          |          |                |               |             |           |            |       |         |
|       SystemPosition | .NET 8.0 | .NET 8.0 |       Position |         -1024 | 1,028.48 ns | 19.348 ns |  17.151 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 8.0 | .NET 8.0 |       Position |         -1024 |   295.30 ns |  5.307 ns |   4.705 ns |  0.29 |    0.00 |
|                      |          |          |                |               |             |           |            |       |         |
|       SystemPosition | .NET 8.0 | .NET 8.0 |       Position |             4 | 2,572.16 ns | 26.545 ns |  24.831 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 8.0 | .NET 8.0 |       Position |             4 |   325.16 ns |  4.540 ns |   3.791 ns |  0.13 |    0.00 |
|                      |          |          |                |               |             |           |            |       |         |
|       SystemPosition | .NET 8.0 | .NET 8.0 |       Position |           128 | 2,457.29 ns | 23.744 ns |  22.211 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 8.0 | .NET 8.0 |       Position |           128 |   291.12 ns |  2.086 ns |   1.849 ns |  0.12 |    0.00 |
|                      |          |          |                |               |             |           |            |       |         |
|       SystemPosition | .NET 8.0 | .NET 8.0 |       Position |          1024 | 1,018.63 ns | 13.894 ns |  12.997 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 8.0 | .NET 8.0 |       Position |          1024 |   291.49 ns |  3.079 ns |   2.730 ns |  0.29 |    0.00 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryPeek | .NET 8.0 | .NET 8.0 |        TryPeek |         -1024 |   684.69 ns | 10.249 ns |   9.086 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 8.0 | .NET 8.0 |        TryPeek |         -1024 |   573.80 ns |  8.359 ns |   7.410 ns |  0.84 |    0.01 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryPeek | .NET 8.0 | .NET 8.0 |        TryPeek |             4 |   689.26 ns | 10.338 ns |   9.670 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 8.0 | .NET 8.0 |        TryPeek |             4 |   580.86 ns | 11.491 ns |  14.112 ns |  0.85 |    0.03 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryPeek | .NET 8.0 | .NET 8.0 |        TryPeek |           128 |   674.67 ns |  2.539 ns |   2.120 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 8.0 | .NET 8.0 |        TryPeek |           128 |   561.20 ns |  1.292 ns |   1.145 ns |  0.83 |    0.00 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryPeek | .NET 8.0 | .NET 8.0 |        TryPeek |          1024 |   672.19 ns |  1.381 ns |   1.224 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 8.0 | .NET 8.0 |        TryPeek |          1024 |   562.15 ns |  2.108 ns |   1.972 ns |  0.84 |    0.00 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryRead | .NET 8.0 | .NET 8.0 |        TryRead |         -1024 | 1,335.66 ns |  6.252 ns |   5.543 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 8.0 | .NET 8.0 |        TryRead |         -1024 | 1,132.33 ns |  7.819 ns |   7.314 ns |  0.85 |    0.01 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryRead | .NET 8.0 | .NET 8.0 |        TryRead |             4 | 3,534.36 ns | 69.488 ns |  95.116 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 8.0 | .NET 8.0 |        TryRead |             4 | 2,434.61 ns | 41.495 ns |  38.815 ns |  0.68 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryRead | .NET 8.0 | .NET 8.0 |        TryRead |           128 | 1,457.33 ns |  8.429 ns |   6.581 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 8.0 | .NET 8.0 |        TryRead |           128 | 1,250.14 ns |  5.078 ns |   4.750 ns |  0.86 |    0.01 |
|                      |          |          |                |               |             |           |            |       |         |
|        SystemTryRead | .NET 8.0 | .NET 8.0 |        TryRead |          1024 | 1,352.53 ns | 19.338 ns |  16.148 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 8.0 | .NET 8.0 |        TryRead |          1024 | 1,124.97 ns |  1.408 ns |   1.317 ns |  0.83 |    0.01 |
|                      |          |          |                |               |             |           |            |       |         |
|      SystemTryReadTo | .NET 8.0 | .NET 8.0 |      TryReadTo |         -1024 |   106.28 ns |  2.103 ns |   1.967 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 8.0 | .NET 8.0 |      TryReadTo |         -1024 |   103.69 ns |  0.315 ns |   0.279 ns |  0.97 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
|      SystemTryReadTo | .NET 8.0 | .NET 8.0 |      TryReadTo |             4 | 2,807.37 ns | 25.488 ns |  21.283 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 8.0 | .NET 8.0 |      TryReadTo |             4 | 2,613.23 ns | 33.564 ns |  28.027 ns |  0.93 |    0.01 |
|                      |          |          |                |               |             |           |            |       |         |
|      SystemTryReadTo | .NET 8.0 | .NET 8.0 |      TryReadTo |           128 |   171.37 ns |  2.707 ns |   2.532 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 8.0 | .NET 8.0 |      TryReadTo |           128 |   156.91 ns |  2.492 ns |   2.209 ns |  0.92 |    0.02 |
|                      |          |          |                |               |             |           |            |       |         |
|      SystemTryReadTo | .NET 8.0 | .NET 8.0 |      TryReadTo |          1024 |    95.01 ns |  0.929 ns |   0.725 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 8.0 | .NET 8.0 |      TryReadTo |          1024 |    91.21 ns |  0.952 ns |   0.844 ns |  0.96 |    0.01 |