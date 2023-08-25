using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Security.Cryptography;

namespace MyBenchmarks
{
	public class Bench
	{
		private static readonly int N = 1000;
		private readonly List<KeyValuePair<string, object?>> _list;

		public Bench()
		{
			_list = new List<KeyValuePair<string, object?>>(N);
			for (int i = 0; i < N; i++)
			{
				_list.Add(new KeyValuePair<string, object?>($"key_{N}", "value_" + RandomNumberGenerator.GetInt32(100500)));
			}
		}

		[Benchmark(Baseline = true)]
		public (int count, object? value, string str) List()
		{
			var log = new HttpRequestLog(_list);
			return (log.Count, log[N / 2], log.ToString());
		}

		[Benchmark]
		public (int count, object? value, string str) IFace()
		{
			var log = new HttpRequestLogIface(_list);
			return (log.Count, log[N / 2], log.ToString());
		}
	}

	public class Program
	{
		public static void Main(string[] args)
		{
			var summary = BenchmarkRunner.Run<Bench>();
		}
	}
}