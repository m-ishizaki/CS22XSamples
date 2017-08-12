using System;
using System.Threading.Tasks;

// ・オーバーロードの解決の改善
// https://docs.microsoft.com/ja-jp/dotnet/csharp/whats-new/csharp-6#improved-overload-resolution(英語)
// オーバーロードで引数に Action を受け取るメソッドと Func を受け取るメソッドがある場合のコンパイラによる選択が改善した。
namespace CS6.ImprovedOverloadResolution
{
    class MainClass
    {
		static void Main(string[] args)
		{
			Task.Run(() => DoMethod()); // 以前はこう書く必要があった
			Task.Run(DoMethod);         // 今はこう書ける

			Console.ReadKey();
		}

		static Task DoMethod()
		{
			Console.WriteLine("DoMethod");
			return Task.FromResult(0);
		}
    }
}
