using System;

// ・参照返り値と参照ローカル変数(Ref returns and locals)
// https://docs.microsoft.com/ja-jp/dotnet/csharp/whats-new/csharp-7#ref-locals-and-returns(英語)
// 値型の参照を返り値として返すことができる。
namespace CS7.RefLocalsAndReturns
{
    class MainClass
    {
		static void Main(string[] args)
		{
			// 単純な値
			int value = 10;
			ref int vr = ref Method(ref value);

			Console.WriteLine($"{value}, {vr}"); // 11, 11
			value = 20;
			Console.WriteLine($"{value}, {vr}"); // 20, 20
			vr = 30;
			Console.WriteLine($"{value}, {vr}"); // 30, 30

			// 配列の要素
			int[] values = { 10, 20 };
			ref int sr = ref Method(values);

			Console.WriteLine($"{values[0]}, {sr}"); // 10, 10
			values[0] = 20;
			Console.WriteLine($"{values[0]}, {sr}"); // 20, 20
			sr = 30;
			Console.WriteLine($"{values[0]}, {sr}"); // 30, 30

			Console.ReadKey();
		}

		static ref int Method(ref int arg)
		{
			arg++;
			return ref arg;
		}

		static ref int Method(int[] arg)
		{
			return ref arg[0];
		}
    }
}
