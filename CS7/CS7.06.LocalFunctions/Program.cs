using System;

// ・ローカル関数(Local functions)
// https://docs.microsoft.com/ja-jp/dotnet/csharp/whats-new/csharp-7#local-functions(英語)
// メソッド内でメソッドを定義できる。
namespace CS7.LocalFunctions
{
    class MainClass
    {
		static void Main(string[] args)
		{
			LocalFunctionSample();  // 1
									// 2
									// 3
			OldStyleSample();       // 1
									// 2
									// 3

			Console.ReadKey();
		}

		static void LocalFunctionSample()
		{
			func(0);
			return;

			// 新しいスタイル
			void func(int v) { Console.WriteLine(++v); if (v < 3) { func(v); } }
		}

		static void OldStyleSample()
		{
			// 以前のスタイル
			Action<int> func = null;
			func = v => { Console.WriteLine(++v); if (v < 3) { func(v); } };

			func(0);
			return;
		}
    }
}
