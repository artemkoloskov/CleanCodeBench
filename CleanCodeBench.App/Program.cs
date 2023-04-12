using BenchmarkDotNet.Running;

namespace CleanCodeBench.App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BenchmarkRunner.Run<Benchmarks>();
        }
    }
}