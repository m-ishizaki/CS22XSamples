using System;

// ・省略可能な引数 (オプション引数)
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments
// メソッドなどのパラメーターに規定値を設定し、省略可能にできる。
namespace CS4.NamedAndOptionalArguments
{
    class MainClass
    {
		static void Main(string[] args)
		{
			AddAndWriteLine(10, 20, "計算結果 => {0}"); // 計算結果 => 30
			AddAndWriteLine(10, 20);                   // 結果は 30 です.
			AddAndWriteLine(1);                        // 結果は 3 です.

			Console.ReadKey();
		}

		static int AddAndWriteLine(int a, int b = 2, string format = "結果は {0} です.")
		{
			var c = a + b;
			Console.WriteLine(string.Format(format, c));
			return c;
		}
    }
}
