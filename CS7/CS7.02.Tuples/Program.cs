using System;

// ・タプル(Tuples)
// https://docs.microsoft.com/ja-jp/dotnet/csharp/tuples
// 複数の値を 1 つのオブジェクトに簡単にパッケージできる。 [注意] この機能を使用するには NuGet で System.ValueTuple を追加する必要がある。
namespace CS7.Tuples
{
    class MainClass
    {
		static void Main(string[] args)
		{
			string text;
			int length;
			(text, length) = MethodA();

			var tupleA = MethodA();
			var tupleB = MethodB();

			Console.WriteLine($"{text}, {length}");                 // textA, 5
			Console.WriteLine($"{tupleA.Item1}, {tupleA.Item2}");   // textA, 5
			Console.WriteLine($"{tupleB.text}, {tupleB.length}");   // textB, 5

			Console.ReadKey();
		}

		static (string, int) MethodA()
		{
			string text = "textA";
			return (text, text.Length);
		}

		static (string text, int length) MethodB()
		{
			string text = "textB";
			return (text: text, length: text.Length);
		}
    }
}
