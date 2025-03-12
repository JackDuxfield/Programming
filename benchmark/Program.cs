using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using AlgoDS.Searching;

        

BenchmarkRunner.Run<MyBenchmark>();


[MemoryDiagnoser] // Shows memory usage in benchmark results
[SimpleJob(iterationCount: 10)] // Runs 10 iterations



public class MyBenchmark
{

    private int[] dataArray;
    private List<int> dataList;

    private const int DataSize = 10000;

    [GlobalSetup]

    public void Setup()
    {
        var random = new Random(42);

        dataArray = new int[DataSize];
        for (int i = 0; i < DataSize; i++)
        {
            dataArray[i] = random.Next();
        }

        dataList = new List<int>(dataArray);
    }

    [Benchmark]
    public void Do()
    {
        AlgoDS.DataStructures.Queue q = new AlgoDS.DataStructures.Queue();
    }
    [Benchmark]
    public int[] ArraySort()
    {
        var cloned = (int[])dataArray.Clone();
        Array.Sort(cloned);
        return cloned;
    }

    [Benchmark]
    public List<int> ListSort()
    {
        var cloned = new List<int>(dataList);
        cloned.Sort();
        return cloned;
    }

    [Benchmark]
    public void TestLinearSearch() {
        int result = LinearSearch.Search(dataArray, 8);
        Console.WriteLine(result);
    }

}
