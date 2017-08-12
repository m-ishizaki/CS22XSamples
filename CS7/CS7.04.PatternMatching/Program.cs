using System;

// ・パターンマッチ(Pattern matching)
// https://docs.microsoft.com/ja-jp/dotnet/csharp/pattern-matching
// is および switch で型を判断しての処理が簡潔に書ける。
namespace CS7.PatternMatching
{
    class MainClass
    {
		static void Main(string[] args)
		{
			string textIs = IsPattern(10);
			Console.WriteLine(textIs);              // 引数は int の 10 です

			string textSwitch = SwitchPattern("10");
			Console.WriteLine(textSwitch);          // 引数は string の 10 です

			Console.ReadKey();
		}

		static string IsPattern(object arg)
		{
			if (arg is int i) { return $"引数は int の {i} です"; }
			if (arg is double d) { return $"引数は double の {d} です"; }
			if (arg is string s) { return $"引数は string の {s} です"; }
			return "unknown";
		}

		static string SwitchPattern(object arg)
		{
			switch (arg)
			{
				case int i: return $"引数は int の {i} です";
				case double d: return $"引数は double の {d} です";
				case string s: return $"引数は string の {s} です";
				default: return "unknown";
			}
		}
    }
}
