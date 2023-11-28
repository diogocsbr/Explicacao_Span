using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace Explicacao_Span;


//[SimpleJob(RuntimeMoniker.NativeAot60)]
//[SimpleJob(RuntimeMoniker.NativeAot70)]
//[SimpleJob(RuntimeMoniker.NativeAot80)]

[SimpleJob(RuntimeMoniker.Net60)]
[SimpleJob(RuntimeMoniker.Net70)]
[SimpleJob(RuntimeMoniker.Net80, baseline: true)]

[RPlotExporter]

[MemoryDiagnoser(true)]
public class Logica
{

    private int[] _data;

    [GlobalSetup]
    public void Setup()
    {
        _data = new int[1000];
        for (int i = 0; i < _data.Length; i++)
        {
            _data[i] = i;
        }
    }

    [Benchmark]
    public void ComSpan()
    {
        Span<int> span = _data.AsSpan();
        for (int i = 0; i < span.Length; i++)
        {
            span[i] = span[i] * 2;
        }
    }

    [Benchmark]
    public void SemSpan()
    {
        for (int i = 0; i < _data.Length; i++)
        {
            _data[i] = _data[i] * 2;
        }
    }
}