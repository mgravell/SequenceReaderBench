With the `[MethodImpl(MethodImplOptions.NoInlining)]` on `AdvanceToNextSpan`:

|        Method |      Job |  Runtime | SegmentLength |     Mean |     Error |    StdDev | Ratio | RatioSD |
|-------------- |--------- |--------- |-------------- |---------:|----------:|----------:|------:|--------:|
| SystemAdvance | .NET 6.0 | .NET 6.0 |         -1024 | 1.149 us | 0.0117 us | 0.0098 us |  1.00 |    0.00 |
| CustomAdvance | .NET 6.0 | .NET 6.0 |         -1024 | 1.159 us | 0.0135 us | 0.0127 us |  1.01 |    0.01 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 6.0 | .NET 6.0 |             4 | 4.126 us | 0.0438 us | 0.0366 us |  1.00 |    0.00 |
| CustomAdvance | .NET 6.0 | .NET 6.0 |             4 | 3.631 us | 0.0603 us | 0.0564 us |  0.88 |    0.01 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 6.0 | .NET 6.0 |           128 | 1.280 us | 0.0109 us | 0.0091 us |  1.00 |    0.00 |
| CustomAdvance | .NET 6.0 | .NET 6.0 |           128 | 1.269 us | 0.0124 us | 0.0110 us |  0.99 |    0.01 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 6.0 | .NET 6.0 |          1024 | 1.141 us | 0.0106 us | 0.0094 us |  1.00 |    0.00 |
| CustomAdvance | .NET 6.0 | .NET 6.0 |          1024 | 1.153 us | 0.0123 us | 0.0116 us |  1.01 |    0.01 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 7.0 | .NET 7.0 |         -1024 | 1.143 us | 0.0148 us | 0.0138 us |  1.00 |    0.00 |
| CustomAdvance | .NET 7.0 | .NET 7.0 |         -1024 | 1.159 us | 0.0174 us | 0.0163 us |  1.01 |    0.02 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 7.0 | .NET 7.0 |             4 | 3.905 us | 0.0488 us | 0.0433 us |  1.00 |    0.00 |
| CustomAdvance | .NET 7.0 | .NET 7.0 |             4 | 3.140 us | 0.0377 us | 0.0353 us |  0.80 |    0.01 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 7.0 | .NET 7.0 |           128 | 1.525 us | 0.0212 us | 0.0198 us |  1.00 |    0.00 |
| CustomAdvance | .NET 7.0 | .NET 7.0 |           128 | 1.116 us | 0.0206 us | 0.0183 us |  0.73 |    0.02 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 7.0 | .NET 7.0 |          1024 | 1.151 us | 0.0171 us | 0.0143 us |  1.00 |    0.00 |
| CustomAdvance | .NET 7.0 | .NET 7.0 |          1024 | 1.036 us | 0.0082 us | 0.0073 us |  0.90 |    0.01 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 8.0 | .NET 8.0 |         -1024 | 1.135 us | 0.0082 us | 0.0073 us |  1.00 |    0.00 |
| CustomAdvance | .NET 8.0 | .NET 8.0 |         -1024 | 1.192 us | 0.0055 us | 0.0052 us |  1.05 |    0.01 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 8.0 | .NET 8.0 |             4 | 3.668 us | 0.0341 us | 0.0302 us |  1.00 |    0.00 |
| CustomAdvance | .NET 8.0 | .NET 8.0 |             4 | 3.394 us | 0.0562 us | 0.0498 us |  0.93 |    0.02 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 8.0 | .NET 8.0 |           128 | 1.289 us | 0.0131 us | 0.0116 us |  1.00 |    0.00 |
| CustomAdvance | .NET 8.0 | .NET 8.0 |           128 | 1.270 us | 0.0134 us | 0.0125 us |  0.99 |    0.02 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 8.0 | .NET 8.0 |          1024 | 1.136 us | 0.0061 us | 0.0051 us |  1.00 |    0.00 |
| CustomAdvance | .NET 8.0 | .NET 8.0 |          1024 | 1.274 us | 0.0241 us | 0.0214 us |  1.12 |    0.02 |

Without the `[MethodImpl(MethodImplOptions.NoInlining)]` on `AdvanceToNextSpan`:

|        Method |      Job |  Runtime | SegmentLength |     Mean |     Error |    StdDev | Ratio | RatioSD |
|-------------- |--------- |--------- |-------------- |---------:|----------:|----------:|------:|--------:|
| SystemAdvance | .NET 6.0 | .NET 6.0 |         -1024 | 1.152 us | 0.0205 us | 0.0182 us |  1.00 |    0.00 |
| CustomAdvance | .NET 6.0 | .NET 6.0 |         -1024 | 1.368 us | 0.0097 us | 0.0076 us |  1.19 |    0.02 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 6.0 | .NET 6.0 |             4 | 4.112 us | 0.0240 us | 0.0188 us |  1.00 |    0.00 |
| CustomAdvance | .NET 6.0 | .NET 6.0 |             4 | 3.461 us | 0.0342 us | 0.0320 us |  0.84 |    0.01 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 6.0 | .NET 6.0 |           128 | 1.279 us | 0.0118 us | 0.0110 us |  1.00 |    0.00 |
| CustomAdvance | .NET 6.0 | .NET 6.0 |           128 | 1.477 us | 0.0230 us | 0.0204 us |  1.15 |    0.02 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 6.0 | .NET 6.0 |          1024 | 1.156 us | 0.0199 us | 0.0186 us |  1.00 |    0.00 |
| CustomAdvance | .NET 6.0 | .NET 6.0 |          1024 | 1.346 us | 0.0078 us | 0.0073 us |  1.17 |    0.02 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 7.0 | .NET 7.0 |         -1024 | 1.147 us | 0.0117 us | 0.0098 us |  1.00 |    0.00 |
| CustomAdvance | .NET 7.0 | .NET 7.0 |         -1024 | 1.226 us | 0.0108 us | 0.0096 us |  1.07 |    0.01 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 7.0 | .NET 7.0 |             4 | 3.898 us | 0.0523 us | 0.0436 us |  1.00 |    0.00 |
| CustomAdvance | .NET 7.0 | .NET 7.0 |             4 | 3.193 us | 0.0174 us | 0.0136 us |  0.82 |    0.01 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 7.0 | .NET 7.0 |           128 | 1.528 us | 0.0262 us | 0.0232 us |  1.00 |    0.00 |
| CustomAdvance | .NET 7.0 | .NET 7.0 |           128 | 1.193 us | 0.0215 us | 0.0248 us |  0.78 |    0.02 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 7.0 | .NET 7.0 |          1024 | 1.139 us | 0.0094 us | 0.0084 us |  1.00 |    0.00 |
| CustomAdvance | .NET 7.0 | .NET 7.0 |          1024 | 1.147 us | 0.0229 us | 0.0263 us |  1.01 |    0.02 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 8.0 | .NET 8.0 |         -1024 | 1.154 us | 0.0199 us | 0.0166 us |  1.00 |    0.00 |
| CustomAdvance | .NET 8.0 | .NET 8.0 |         -1024 | 1.345 us | 0.0171 us | 0.0143 us |  1.17 |    0.02 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 8.0 | .NET 8.0 |             4 | 3.714 us | 0.0457 us | 0.0427 us |  1.00 |    0.00 |
| CustomAdvance | .NET 8.0 | .NET 8.0 |             4 | 2.983 us | 0.0576 us | 0.0539 us |  0.80 |    0.01 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 8.0 | .NET 8.0 |           128 | 1.283 us | 0.0144 us | 0.0128 us |  1.00 |    0.00 |
| CustomAdvance | .NET 8.0 | .NET 8.0 |           128 | 1.448 us | 0.0174 us | 0.0154 us |  1.13 |    0.02 |
|               |          |          |               |          |           |           |       |         |
| SystemAdvance | .NET 8.0 | .NET 8.0 |          1024 | 1.169 us | 0.0192 us | 0.0180 us |  1.00 |    0.00 |
| CustomAdvance | .NET 8.0 | .NET 8.0 |          1024 | 1.338 us | 0.0114 us | 0.0101 us |  1.14 |    0.02 |
