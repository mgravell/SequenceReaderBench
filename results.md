``` txt
BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1265/22H2/2022Update/SunValley2)
Intel Core i9-9900K CPU 3.60GHz (Coffee Lake), 1 CPU, 16 logical and 8 physical cores
.NET SDK=8.0.100-preview.1.23115.2
  [Host]   : .NET 8.0.0 (8.0.23.11008), X64 RyuJIT AVX2
  .NET 6.0 : .NET 6.0.14 (6.0.1423.7309), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2
  .NET 8.0 : .NET 8.0.0 (8.0.23.11008), X64 RyuJIT AVX2
```

|               Method |      Job |  Runtime |     Categories | SegmentLength |        Mean |     Error |     StdDev |      Median | Ratio | RatioSD |
|--------------------- |--------- |--------- |--------------- |-------------- |------------:|----------:|-----------:|------------:|------:|--------:|
|        SystemAdvance | .NET 6.0 | .NET 6.0 |        Advance |         -1024 | 1,129.88 ns |  6.785 ns |   5.666 ns | 1,128.45 ns |  1.00 |    0.00 |
|        CustomAdvance | .NET 6.0 | .NET 6.0 |        Advance |         -1024 | 1,149.92 ns | 14.830 ns |  12.384 ns | 1,145.08 ns |  1.02 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemAdvance | .NET 6.0 | .NET 6.0 |        Advance |             4 | 4,094.49 ns | 27.500 ns |  22.964 ns | 4,089.53 ns |  1.00 |    0.00 |
|        CustomAdvance | .NET 6.0 | .NET 6.0 |        Advance |             4 | 3,712.48 ns | 67.401 ns |  89.978 ns | 3,713.49 ns |  0.90 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemAdvance | .NET 6.0 | .NET 6.0 |        Advance |           128 | 1,283.41 ns | 17.942 ns |  15.905 ns | 1,278.84 ns |  1.00 |    0.00 |
|        CustomAdvance | .NET 6.0 | .NET 6.0 |        Advance |           128 | 1,279.93 ns | 17.003 ns |  15.905 ns | 1,277.81 ns |  1.00 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemAdvance | .NET 6.0 | .NET 6.0 |        Advance |          1024 | 1,152.30 ns | 16.687 ns |  15.609 ns | 1,149.11 ns |  1.00 |    0.00 |
|        CustomAdvance | .NET 6.0 | .NET 6.0 |        Advance |          1024 | 1,184.17 ns | 22.603 ns |  25.123 ns | 1,173.69 ns |  1.03 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
| SystemAdvancePastAny | .NET 6.0 | .NET 6.0 | AdvancePastAny |         -1024 |   697.47 ns |  8.987 ns |   7.966 ns |   693.84 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 6.0 | .NET 6.0 | AdvancePastAny |         -1024 |   486.15 ns |  5.758 ns |   5.105 ns |   485.53 ns |  0.70 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
| SystemAdvancePastAny | .NET 6.0 | .NET 6.0 | AdvancePastAny |             4 | 3,342.24 ns | 36.813 ns |  32.634 ns | 3,342.20 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 6.0 | .NET 6.0 | AdvancePastAny |             4 | 2,910.45 ns | 28.978 ns |  27.106 ns | 2,901.58 ns |  0.87 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
| SystemAdvancePastAny | .NET 6.0 | .NET 6.0 | AdvancePastAny |           128 |   663.68 ns | 11.785 ns |  11.024 ns |   660.04 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 6.0 | .NET 6.0 | AdvancePastAny |           128 |   637.10 ns | 11.144 ns |  10.425 ns |   635.15 ns |  0.96 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
| SystemAdvancePastAny | .NET 6.0 | .NET 6.0 | AdvancePastAny |          1024 |   722.00 ns | 14.124 ns |  16.814 ns |   722.22 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 6.0 | .NET 6.0 | AdvancePastAny |          1024 |   498.18 ns |  9.728 ns |   9.554 ns |   499.75 ns |  0.69 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
|       SystemPosition | .NET 6.0 | .NET 6.0 |       Position |         -1024 | 1,193.55 ns | 14.497 ns |  12.851 ns | 1,192.75 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 6.0 | .NET 6.0 |       Position |         -1024 |   298.82 ns |  4.711 ns |   4.406 ns |   299.26 ns |  0.25 |    0.00 |
|                      |          |          |                |               |             |           |            |             |       |         |
|       SystemPosition | .NET 6.0 | .NET 6.0 |       Position |             4 | 3,228.38 ns | 36.671 ns |  34.303 ns | 3,219.70 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 6.0 | .NET 6.0 |       Position |             4 |   331.84 ns |  4.239 ns |   3.965 ns |   330.47 ns |  0.10 |    0.00 |
|                      |          |          |                |               |             |           |            |             |       |         |
|       SystemPosition | .NET 6.0 | .NET 6.0 |       Position |           128 | 3,166.89 ns | 44.394 ns |  41.526 ns | 3,147.55 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 6.0 | .NET 6.0 |       Position |           128 |   296.03 ns |  3.626 ns |   3.214 ns |   295.69 ns |  0.09 |    0.00 |
|                      |          |          |                |               |             |           |            |             |       |         |
|       SystemPosition | .NET 6.0 | .NET 6.0 |       Position |          1024 | 1,209.65 ns | 16.152 ns |  14.318 ns | 1,208.16 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 6.0 | .NET 6.0 |       Position |          1024 |   296.87 ns |  2.672 ns |   2.369 ns |   296.44 ns |  0.25 |    0.00 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryPeek | .NET 6.0 | .NET 6.0 |        TryPeek |         -1024 |   762.15 ns |  9.877 ns |   8.756 ns |   761.07 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 6.0 | .NET 6.0 |        TryPeek |         -1024 |   646.79 ns | 12.166 ns |  13.522 ns |   645.92 ns |  0.84 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryPeek | .NET 6.0 | .NET 6.0 |        TryPeek |             4 |   762.61 ns | 10.748 ns |  10.053 ns |   763.38 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 6.0 | .NET 6.0 |        TryPeek |             4 |   631.45 ns |  6.938 ns |   6.489 ns |   631.91 ns |  0.83 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryPeek | .NET 6.0 | .NET 6.0 |        TryPeek |           128 |   748.61 ns |  8.253 ns |   7.720 ns |   750.24 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 6.0 | .NET 6.0 |        TryPeek |           128 |   642.44 ns |  8.318 ns |   7.374 ns |   642.41 ns |  0.86 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryPeek | .NET 6.0 | .NET 6.0 |        TryPeek |          1024 |   746.72 ns |  8.528 ns |   7.560 ns |   746.50 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 6.0 | .NET 6.0 |        TryPeek |          1024 |   646.75 ns | 12.154 ns |  12.481 ns |   644.37 ns |  0.87 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryRead | .NET 6.0 | .NET 6.0 |        TryRead |         -1024 | 1,546.08 ns | 22.560 ns |  19.998 ns | 1,545.62 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 6.0 | .NET 6.0 |        TryRead |         -1024 | 1,348.10 ns |  3.392 ns |   3.007 ns | 1,347.28 ns |  0.87 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryRead | .NET 6.0 | .NET 6.0 |        TryRead |             4 | 4,049.90 ns | 75.615 ns |  74.265 ns | 4,020.29 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 6.0 | .NET 6.0 |        TryRead |             4 | 2,628.98 ns | 39.715 ns |  40.785 ns | 2,618.38 ns |  0.65 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryRead | .NET 6.0 | .NET 6.0 |        TryRead |           128 | 1,518.13 ns | 22.127 ns |  20.698 ns | 1,513.66 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 6.0 | .NET 6.0 |        TryRead |           128 | 1,463.24 ns |  5.387 ns |   5.039 ns | 1,463.14 ns |  0.96 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryRead | .NET 6.0 | .NET 6.0 |        TryRead |          1024 | 1,601.59 ns | 19.822 ns |  18.542 ns | 1,595.01 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 6.0 | .NET 6.0 |        TryRead |          1024 | 1,346.79 ns |  7.896 ns |   7.385 ns | 1,346.19 ns |  0.84 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|      SystemTryReadTo | .NET 6.0 | .NET 6.0 |      TryReadTo |         -1024 |   289.07 ns |  1.742 ns |   1.630 ns |   289.41 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 6.0 | .NET 6.0 |      TryReadTo |         -1024 |   265.83 ns |  1.761 ns |   1.471 ns |   265.71 ns |  0.92 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|      SystemTryReadTo | .NET 6.0 | .NET 6.0 |      TryReadTo |             4 | 3,190.03 ns | 30.483 ns |  27.022 ns | 3,183.56 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 6.0 | .NET 6.0 |      TryReadTo |             4 | 2,796.34 ns | 53.524 ns |  50.066 ns | 2,799.94 ns |  0.88 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
|      SystemTryReadTo | .NET 6.0 | .NET 6.0 |      TryReadTo |           128 |   357.08 ns |  2.296 ns |   2.035 ns |   356.87 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 6.0 | .NET 6.0 |      TryReadTo |           128 |   360.47 ns |  1.477 ns |   1.234 ns |   360.60 ns |  1.01 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|      SystemTryReadTo | .NET 6.0 | .NET 6.0 |      TryReadTo |          1024 |   263.50 ns |  2.082 ns |   1.846 ns |   263.27 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 6.0 | .NET 6.0 |      TryReadTo |          1024 |   265.05 ns |  2.328 ns |   2.064 ns |   264.54 ns |  1.01 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemAdvance | .NET 7.0 | .NET 7.0 |        Advance |         -1024 | 1,127.67 ns |  8.113 ns |   7.588 ns | 1,125.91 ns |  1.00 |    0.00 |
|        CustomAdvance | .NET 7.0 | .NET 7.0 |        Advance |         -1024 | 1,156.25 ns | 13.132 ns |  10.966 ns | 1,156.73 ns |  1.02 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemAdvance | .NET 7.0 | .NET 7.0 |        Advance |             4 | 4,052.04 ns | 70.899 ns |  89.664 ns | 4,028.83 ns |  1.00 |    0.00 |
|        CustomAdvance | .NET 7.0 | .NET 7.0 |        Advance |             4 | 3,412.24 ns | 60.076 ns |  56.195 ns | 3,382.70 ns |  0.84 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemAdvance | .NET 7.0 | .NET 7.0 |        Advance |           128 | 1,308.83 ns | 15.905 ns |  14.877 ns | 1,309.15 ns |  1.00 |    0.00 |
|        CustomAdvance | .NET 7.0 | .NET 7.0 |        Advance |           128 | 1,094.06 ns | 21.274 ns |  24.499 ns | 1,088.82 ns |  0.84 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemAdvance | .NET 7.0 | .NET 7.0 |        Advance |          1024 | 1,383.16 ns | 24.000 ns |  21.276 ns | 1,378.79 ns |  1.00 |    0.00 |
|        CustomAdvance | .NET 7.0 | .NET 7.0 |        Advance |          1024 | 1,050.63 ns | 18.108 ns |  16.938 ns | 1,048.62 ns |  0.76 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
| SystemAdvancePastAny | .NET 7.0 | .NET 7.0 | AdvancePastAny |         -1024 |   780.41 ns | 10.550 ns |   9.869 ns |   779.67 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 7.0 | .NET 7.0 | AdvancePastAny |         -1024 |   935.19 ns | 15.429 ns |  13.678 ns |   931.66 ns |  1.20 |    0.03 |
|                      |          |          |                |               |             |           |            |             |       |         |
| SystemAdvancePastAny | .NET 7.0 | .NET 7.0 | AdvancePastAny |             4 | 3,506.61 ns | 41.907 ns |  37.149 ns | 3,494.10 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 7.0 | .NET 7.0 | AdvancePastAny |             4 | 3,034.87 ns | 57.281 ns |  53.581 ns | 3,011.78 ns |  0.86 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
| SystemAdvancePastAny | .NET 7.0 | .NET 7.0 | AdvancePastAny |           128 |   874.81 ns | 16.649 ns |  14.759 ns |   876.18 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 7.0 | .NET 7.0 | AdvancePastAny |           128 | 1,055.48 ns | 20.373 ns |  21.799 ns | 1,052.58 ns |  1.20 |    0.04 |
|                      |          |          |                |               |             |           |            |             |       |         |
| SystemAdvancePastAny | .NET 7.0 | .NET 7.0 | AdvancePastAny |          1024 |   769.49 ns | 12.199 ns |  10.814 ns |   769.62 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 7.0 | .NET 7.0 | AdvancePastAny |          1024 |   936.74 ns | 14.112 ns |  12.510 ns |   936.45 ns |  1.22 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
|       SystemPosition | .NET 7.0 | .NET 7.0 |       Position |         -1024 | 1,083.67 ns | 15.855 ns |  14.055 ns | 1,082.66 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 7.0 | .NET 7.0 |       Position |         -1024 |   296.28 ns |  2.805 ns |   2.342 ns |   295.94 ns |  0.27 |    0.00 |
|                      |          |          |                |               |             |           |            |             |       |         |
|       SystemPosition | .NET 7.0 | .NET 7.0 |       Position |             4 | 2,985.12 ns | 34.453 ns |  32.227 ns | 2,977.51 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 7.0 | .NET 7.0 |       Position |             4 |   330.57 ns |  4.979 ns |   4.658 ns |   331.09 ns |  0.11 |    0.00 |
|                      |          |          |                |               |             |           |            |             |       |         |
|       SystemPosition | .NET 7.0 | .NET 7.0 |       Position |           128 | 2,490.77 ns | 28.397 ns |  25.174 ns | 2,490.11 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 7.0 | .NET 7.0 |       Position |           128 |   298.10 ns |  4.921 ns |   4.603 ns |   297.72 ns |  0.12 |    0.00 |
|                      |          |          |                |               |             |           |            |             |       |         |
|       SystemPosition | .NET 7.0 | .NET 7.0 |       Position |          1024 | 1,105.08 ns | 21.673 ns |  26.617 ns | 1,099.55 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 7.0 | .NET 7.0 |       Position |          1024 |   300.98 ns |  5.401 ns |   5.052 ns |   301.44 ns |  0.27 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryPeek | .NET 7.0 | .NET 7.0 |        TryPeek |         -1024 |   691.29 ns |  8.087 ns |   7.565 ns |   689.38 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 7.0 | .NET 7.0 |        TryPeek |         -1024 |   914.24 ns | 11.597 ns |  10.281 ns |   911.05 ns |  1.32 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryPeek | .NET 7.0 | .NET 7.0 |        TryPeek |             4 |   690.02 ns |  8.501 ns |   7.536 ns |   690.20 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 7.0 | .NET 7.0 |        TryPeek |             4 |   918.66 ns | 16.100 ns |  15.060 ns |   914.26 ns |  1.33 |    0.03 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryPeek | .NET 7.0 | .NET 7.0 |        TryPeek |           128 |   696.47 ns | 10.532 ns |   9.852 ns |   699.88 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 7.0 | .NET 7.0 |        TryPeek |           128 |   917.33 ns | 12.482 ns |  11.065 ns |   918.65 ns |  1.32 |    0.03 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryPeek | .NET 7.0 | .NET 7.0 |        TryPeek |          1024 |   690.70 ns |  8.560 ns |   7.589 ns |   689.91 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 7.0 | .NET 7.0 |        TryPeek |          1024 |   915.36 ns | 14.320 ns |  11.958 ns |   918.66 ns |  1.33 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryRead | .NET 7.0 | .NET 7.0 |        TryRead |         -1024 | 1,583.88 ns | 15.790 ns |  14.770 ns | 1,585.08 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 7.0 | .NET 7.0 |        TryRead |         -1024 | 1,133.60 ns |  4.117 ns |   3.851 ns | 1,132.44 ns |  0.72 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryRead | .NET 7.0 | .NET 7.0 |        TryRead |             4 | 4,008.42 ns | 36.551 ns |  30.521 ns | 4,003.95 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 7.0 | .NET 7.0 |        TryRead |             4 | 2,597.60 ns | 22.840 ns |  20.247 ns | 2,598.81 ns |  0.65 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryRead | .NET 7.0 | .NET 7.0 |        TryRead |           128 | 1,719.93 ns | 20.659 ns |  18.314 ns | 1,715.53 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 7.0 | .NET 7.0 |        TryRead |           128 | 1,261.88 ns |  2.454 ns |   2.049 ns | 1,261.22 ns |  0.73 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryRead | .NET 7.0 | .NET 7.0 |        TryRead |          1024 | 1,579.26 ns | 14.002 ns |  13.097 ns | 1,576.11 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 7.0 | .NET 7.0 |        TryRead |          1024 | 1,130.38 ns |  5.182 ns |   4.045 ns | 1,129.82 ns |  0.72 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|      SystemTryReadTo | .NET 7.0 | .NET 7.0 |      TryReadTo |         -1024 |   106.88 ns |  0.666 ns |   0.591 ns |   106.79 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 7.0 | .NET 7.0 |      TryReadTo |         -1024 |   106.64 ns |  0.922 ns |   0.863 ns |   106.34 ns |  1.00 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|      SystemTryReadTo | .NET 7.0 | .NET 7.0 |      TryReadTo |             4 | 3,263.69 ns | 35.190 ns |  27.474 ns | 3,264.05 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 7.0 | .NET 7.0 |      TryReadTo |             4 | 2,776.49 ns | 41.352 ns |  38.680 ns | 2,773.14 ns |  0.85 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|      SystemTryReadTo | .NET 7.0 | .NET 7.0 |      TryReadTo |           128 |   177.36 ns |  2.514 ns |   2.352 ns |   176.58 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 7.0 | .NET 7.0 |      TryReadTo |           128 |   158.81 ns |  2.050 ns |   1.712 ns |   158.54 ns |  0.89 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|      SystemTryReadTo | .NET 7.0 | .NET 7.0 |      TryReadTo |          1024 |   107.64 ns |  0.607 ns |   0.538 ns |   107.58 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 7.0 | .NET 7.0 |      TryReadTo |          1024 |   104.24 ns |  1.170 ns |   1.037 ns |   103.86 ns |  0.97 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemAdvance | .NET 8.0 | .NET 8.0 |        Advance |         -1024 | 1,168.07 ns | 22.066 ns |  40.901 ns | 1,148.61 ns |  1.00 |    0.00 |
|        CustomAdvance | .NET 8.0 | .NET 8.0 |        Advance |         -1024 | 1,191.13 ns | 23.380 ns |  25.017 ns | 1,185.43 ns |  1.01 |    0.04 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemAdvance | .NET 8.0 | .NET 8.0 |        Advance |             4 | 3,678.21 ns | 40.771 ns |  36.142 ns | 3,682.87 ns |  1.00 |    0.00 |
|        CustomAdvance | .NET 8.0 | .NET 8.0 |        Advance |             4 | 3,444.09 ns | 68.845 ns | 103.043 ns | 3,422.81 ns |  0.94 |    0.04 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemAdvance | .NET 8.0 | .NET 8.0 |        Advance |           128 | 1,312.17 ns | 24.406 ns |  23.970 ns | 1,315.68 ns |  1.00 |    0.00 |
|        CustomAdvance | .NET 8.0 | .NET 8.0 |        Advance |           128 | 1,282.36 ns | 21.419 ns |  20.036 ns | 1,274.92 ns |  0.98 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemAdvance | .NET 8.0 | .NET 8.0 |        Advance |          1024 | 1,181.49 ns | 22.636 ns |  22.231 ns | 1,181.85 ns |  1.00 |    0.00 |
|        CustomAdvance | .NET 8.0 | .NET 8.0 |        Advance |          1024 | 1,272.42 ns | 17.486 ns |  14.602 ns | 1,276.10 ns |  1.08 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
| SystemAdvancePastAny | .NET 8.0 | .NET 8.0 | AdvancePastAny |         -1024 |   936.02 ns | 14.608 ns |  13.664 ns |   933.66 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 8.0 | .NET 8.0 | AdvancePastAny |         -1024 |   483.00 ns |  8.148 ns |   7.622 ns |   480.88 ns |  0.52 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
| SystemAdvancePastAny | .NET 8.0 | .NET 8.0 | AdvancePastAny |             4 | 3,453.54 ns | 39.785 ns |  35.269 ns | 3,452.25 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 8.0 | .NET 8.0 | AdvancePastAny |             4 | 2,861.16 ns | 30.872 ns |  25.779 ns | 2,860.76 ns |  0.83 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
| SystemAdvancePastAny | .NET 8.0 | .NET 8.0 | AdvancePastAny |           128 |   966.54 ns | 17.317 ns |  16.198 ns |   967.02 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 8.0 | .NET 8.0 | AdvancePastAny |           128 |   659.86 ns | 13.122 ns |  16.595 ns |   656.69 ns |  0.67 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
| SystemAdvancePastAny | .NET 8.0 | .NET 8.0 | AdvancePastAny |          1024 |   943.51 ns | 18.669 ns |  26.774 ns |   942.61 ns |  1.00 |    0.00 |
| CustomAdvancePastAny | .NET 8.0 | .NET 8.0 | AdvancePastAny |          1024 |   481.56 ns |  9.227 ns |   9.475 ns |   478.27 ns |  0.51 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
|       SystemPosition | .NET 8.0 | .NET 8.0 |       Position |         -1024 | 1,025.88 ns | 13.894 ns |  12.316 ns | 1,025.61 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 8.0 | .NET 8.0 |       Position |         -1024 |   297.15 ns |  5.822 ns |   5.446 ns |   297.10 ns |  0.29 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|       SystemPosition | .NET 8.0 | .NET 8.0 |       Position |             4 | 2,318.51 ns | 43.706 ns |  42.926 ns | 2,312.41 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 8.0 | .NET 8.0 |       Position |             4 |   333.68 ns |  5.821 ns |   5.445 ns |   333.36 ns |  0.14 |    0.00 |
|                      |          |          |                |               |             |           |            |             |       |         |
|       SystemPosition | .NET 8.0 | .NET 8.0 |       Position |           128 | 2,559.04 ns | 49.338 ns |  62.397 ns | 2,561.22 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 8.0 | .NET 8.0 |       Position |           128 |   301.13 ns |  3.690 ns |   3.271 ns |   300.76 ns |  0.12 |    0.00 |
|                      |          |          |                |               |             |           |            |             |       |         |
|       SystemPosition | .NET 8.0 | .NET 8.0 |       Position |          1024 | 1,029.05 ns | 11.641 ns |  10.320 ns | 1,026.26 ns |  1.00 |    0.00 |
|       CustomPosition | .NET 8.0 | .NET 8.0 |       Position |          1024 |   298.59 ns |  3.548 ns |   3.319 ns |   298.73 ns |  0.29 |    0.00 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryPeek | .NET 8.0 | .NET 8.0 |        TryPeek |         -1024 |   687.71 ns |  6.373 ns |   5.322 ns |   689.43 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 8.0 | .NET 8.0 |        TryPeek |         -1024 |   574.76 ns |  5.466 ns |   4.845 ns |   575.24 ns |  0.84 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryPeek | .NET 8.0 | .NET 8.0 |        TryPeek |             4 |   687.83 ns |  3.641 ns |   3.040 ns |   688.21 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 8.0 | .NET 8.0 |        TryPeek |             4 |   577.90 ns |  5.268 ns |   4.928 ns |   576.12 ns |  0.84 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryPeek | .NET 8.0 | .NET 8.0 |        TryPeek |           128 |   695.64 ns | 11.350 ns |  10.061 ns |   692.31 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 8.0 | .NET 8.0 |        TryPeek |           128 |   579.12 ns |  5.074 ns |   4.498 ns |   578.51 ns |  0.83 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryPeek | .NET 8.0 | .NET 8.0 |        TryPeek |          1024 |   701.00 ns | 11.822 ns |  10.480 ns |   702.95 ns |  1.00 |    0.00 |
|        CustomTryPeek | .NET 8.0 | .NET 8.0 |        TryPeek |          1024 |   575.22 ns |  7.049 ns |   6.594 ns |   575.70 ns |  0.82 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryRead | .NET 8.0 | .NET 8.0 |        TryRead |         -1024 | 1,365.25 ns | 14.104 ns |  13.192 ns | 1,365.07 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 8.0 | .NET 8.0 |        TryRead |         -1024 | 1,141.62 ns |  5.849 ns |   5.471 ns | 1,140.21 ns |  0.84 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryRead | .NET 8.0 | .NET 8.0 |        TryRead |             4 | 3,425.60 ns | 22.879 ns |  20.282 ns | 3,420.84 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 8.0 | .NET 8.0 |        TryRead |             4 | 2,645.33 ns | 34.670 ns |  32.430 ns | 2,639.26 ns |  0.77 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryRead | .NET 8.0 | .NET 8.0 |        TryRead |           128 | 1,486.26 ns | 11.538 ns |   9.635 ns | 1,483.11 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 8.0 | .NET 8.0 |        TryRead |           128 | 1,271.63 ns |  9.442 ns |   8.832 ns | 1,268.88 ns |  0.85 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|        SystemTryRead | .NET 8.0 | .NET 8.0 |        TryRead |          1024 | 1,368.11 ns | 17.375 ns |  15.402 ns | 1,363.26 ns |  1.00 |    0.00 |
|        CustomTryRead | .NET 8.0 | .NET 8.0 |        TryRead |          1024 | 1,135.37 ns |  4.389 ns |   3.665 ns | 1,135.06 ns |  0.83 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|      SystemTryReadTo | .NET 8.0 | .NET 8.0 |      TryReadTo |         -1024 |   105.06 ns |  0.733 ns |   0.650 ns |   104.98 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 8.0 | .NET 8.0 |      TryReadTo |         -1024 |   105.18 ns |  0.684 ns |   0.606 ns |   105.02 ns |  1.00 |    0.01 |
|                      |          |          |                |               |             |           |            |             |       |         |
|      SystemTryReadTo | .NET 8.0 | .NET 8.0 |      TryReadTo |             4 | 2,901.12 ns | 46.316 ns |  41.058 ns | 2,884.43 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 8.0 | .NET 8.0 |      TryReadTo |             4 | 2,808.88 ns | 23.028 ns |  20.414 ns | 2,800.34 ns |  0.97 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
|      SystemTryReadTo | .NET 8.0 | .NET 8.0 |      TryReadTo |           128 |   167.09 ns |  2.216 ns |   1.964 ns |   166.18 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 8.0 | .NET 8.0 |      TryReadTo |           128 |   161.73 ns |  2.414 ns |   2.258 ns |   160.83 ns |  0.97 |    0.02 |
|                      |          |          |                |               |             |           |            |             |       |         |
|      SystemTryReadTo | .NET 8.0 | .NET 8.0 |      TryReadTo |          1024 |    94.23 ns |  0.519 ns |   0.460 ns |    94.24 ns |  1.00 |    0.00 |
|      CustomTryReadTo | .NET 8.0 | .NET 8.0 |      TryReadTo |          1024 |   104.31 ns |  0.439 ns |   0.342 ns |   104.19 ns |  1.11 |    0.01 |