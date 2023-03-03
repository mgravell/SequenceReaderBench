using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace SequenceReaderBenchmarks;

/* The original purpose of this suite was to invesigate performance
 * tweaks possible in SequenceReader<T>; however, it seems to show
 * some weird JIT? PGO? tiered JIT? regressions in some key paths,
 * where it works well in net6, but less well in net7/net8
 */

static class Program {
    static void Main(string[] args) {
        unsafe {
#pragma warning disable CS8500
            Console.WriteLine("System size: " + sizeof(System.Buffers.SequenceReader<int>));
            Console.WriteLine("Custom size: " + sizeof(System.Buffers2.SequenceReader<int>));
#pragma warning restore CS8500
        }
        // perform validations
        var obj = new SequenceReaderBenchmark();

        obj.SegmentLength = 4;
        obj.Init();

        obj.SegmentLength = 1024;
        obj.Init();
         
        obj.SegmentLength = -1024;
        obj.Init();

        // bench
#if RELEASE
        BenchmarkDotNet.Running.BenchmarkRunner.Run<SequenceReaderBenchmark>(args: args);
#endif
    }
}


[SimpleJob(RuntimeMoniker.Net60)]
[SimpleJob(RuntimeMoniker.Net70)] // weird regression here!
[SimpleJob(RuntimeMoniker.Net80)]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByJob, BenchmarkLogicalGroupRule.ByCategory)]
[CategoriesColumn]
public class SequenceReaderBenchmark {
    private const int TotalLength = 1024;
    [Params(4, 128, 1024, -1024)]
    public int SegmentLength { get; set; }

    private System.Buffers.ReadOnlySequence<int> payload;

    [BenchmarkCategory("TryRead")]
    [Benchmark(Baseline = true)]
    public int SystemTryRead() {
        var reader = new System.Buffers.SequenceReader<int>(payload);
        int count = 0;
        while (reader.TryRead(out _)) {
            count++;
        }
        return count;
    }

    [BenchmarkCategory("TryRead")]
    [Benchmark]
    public int CustomTryRead() {
        var reader = new System.Buffers2.SequenceReader<int>(payload);
        int count = 0;
        while (reader.TryRead(out _)) {
            count++;
        }
        return count;
    }

    [BenchmarkCategory("TryPeek")]
    [Benchmark(Baseline = true)]
    public int SystemTryPeek() {
        var reader = new System.Buffers.SequenceReader<int>(payload);
        int count = 0; // doesn't advance, so: loop
        for (int i = 0; i < TotalLength && reader.TryPeek(out _); i++) {
            count++;
        }
        return count;
    }

    [BenchmarkCategory("TryPeek")]
    [Benchmark]
    public int CustomTryPeek() {
        var reader = new System.Buffers2.SequenceReader<int>(payload);
        int count = 0; // doesn't advance, so: loop
        for (int i = 0; i < TotalLength && reader.TryPeek(out _); i++) {
            count++;
        }
        return count;
    }

    [BenchmarkCategory("AdvancePastAny")]
    [Benchmark(Baseline = true)]
    public long SystemAdvancePastAny() {
        var reader = new System.Buffers.SequenceReader<int>(payload);
        return reader.AdvancePastAny(0, 0, 0);
    }

    [BenchmarkCategory("AdvancePastAny")]
    [Benchmark]
    public long CustomAdvancePastAny() {
        var reader = new System.Buffers2.SequenceReader<int>(payload);
        return reader.AdvancePastAny(0, 0, 0);
    }

    [BenchmarkCategory("Position")]
    [Benchmark(Baseline = true)]
    public int SystemPosition() {
        var reader = new System.Buffers.SequenceReader<int>(payload);
        reader.Advance(17);
        Debug.Assert(payload.GetOffset(reader.Position) == 17);
        int chk = 0; // doesn't advance, so: loop
        for (int i = 0; i < TotalLength; i++) {
            chk ^= reader.Position.GetInteger(); // to avoid erasure
        }
        return chk;
    }

    [BenchmarkCategory("Position")]
    [Benchmark]
    public int CustomPosition() {
        var reader = new System.Buffers2.SequenceReader<int>(payload);
        reader.Advance(17);
        Debug.Assert(payload.GetOffset(reader.Position) == 17);
        int chk = 0; // doesn't advance, so: loop
        for (int i = 0; i < TotalLength; i++) {
            chk ^= reader.Position.GetInteger(); // to avoid erasure
            
        }
        return chk;
    }

    [BenchmarkCategory("Advance")]
    [Benchmark(Baseline = true)]
    public void SystemAdvance() {
        var reader = new System.Buffers.SequenceReader<int>(payload);
        Debug.Assert(payload.GetOffset(reader.Position) == 0);
        for (int i = 0; i < TotalLength; i++) {
            Debug.Assert(!reader.End);
            Debug.Assert(payload.GetOffset(reader.Position) == i);
            reader.Advance(1);
        }
        Debug.Assert(payload.GetOffset(reader.Position) == TotalLength);
        if (!reader.End) Throw();
    }

    [BenchmarkCategory("Advance")]
    [Benchmark]
    public void CustomAdvance() {
        var reader = new System.Buffers2.SequenceReader<int>(payload);
        Debug.Assert(payload.GetOffset(reader.Position) == 0);
        for (int i = 0; i < TotalLength; i++) {
            Debug.Assert(!reader.End);
            Debug.Assert(payload.GetOffset(reader.Position) == i);
            reader.Advance(1);
        }
        Debug.Assert(payload.GetOffset(reader.Position) == TotalLength);
        if (!reader.End) Throw();
    }

    [BenchmarkCategory("TryReadTo")]
    [Benchmark(Baseline = true)]
    public void SystemTryReadTo() {
        var reader = new System.Buffers.SequenceReader<int>(payload);
        if (reader.TryReadTo(out ReadOnlySpan<int> _, 255)) Throw();
    }

    [BenchmarkCategory("TryReadTo")]
    [Benchmark]
    public void CustomTryReadTo() {
        var reader = new System.Buffers2.SequenceReader<int>(payload);
        if (reader.TryReadTo(out ReadOnlySpan<int> _, 255)) Throw();
    }

    [DoesNotReturn]
    static void Throw() => throw new InvalidOperationException();

    [GlobalSetup]
    public void Init() {
        if (SegmentLength < 0) {
            payload = new System.Buffers.ReadOnlySequence<int>(new int[TotalLength]);
        }
        else {
            Segment first = new(SegmentLength, null), last = first;
            int remaining = TotalLength - SegmentLength;
            while (remaining != 0) {
                var len = Math.Min(remaining, SegmentLength);
                last = new Segment(len, last);
                remaining -= len;
            }
            payload = new System.Buffers.ReadOnlySequence<int>(first, 0, last, last.Memory.Length);
        }
        if (payload.Length != TotalLength) Throw();

        if (SystemTryRead() != TotalLength) Throw();
        if (CustomTryRead() != TotalLength) Throw();

        if (SystemTryPeek() != TotalLength) Throw();
        if (CustomTryPeek() != TotalLength) Throw();

        if (SystemAdvancePastAny() != TotalLength) Throw();
        if (CustomAdvancePastAny() != TotalLength) Throw();

        SystemAdvance();
        CustomAdvance();

        SystemPosition();
        CustomPosition();

        SystemTryReadTo();
        CustomTryReadTo();
    }

    sealed class Segment : System.Buffers.ReadOnlySequenceSegment<int>
    {
        public Segment(int length, Segment? previous) {
            Memory = new int[length];
            if (previous is null) {
                RunningIndex = 0;
            }
            else {
                RunningIndex = previous.RunningIndex + previous.Memory.Length;
                previous.Next = this;
            }
        }
    }
}