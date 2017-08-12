using System;

// ・分解(Deconstruction)
// https://docs.microsoft.com/ja-jp/dotnet/csharp/tuples
// タプルを"分解"し項目を展開した状態で、変数を作成できる。
namespace CS7.Deconstruction
{
    class MainClass
    {
		static void Main(string[] args)
		{
			// 分解していない書き方
			{
				var tuple = Method();
				Console.WriteLine($"{tuple.text}, {tuple.length}");     // text, 4
			}
			// 以降、分解している書き方
			{
				var (text, length) = Method();
				Console.WriteLine($"{text}, {length}");                 // text, 4
			}
			{
				(var text, var length) = Method();
				Console.WriteLine($"{text}, {length}");                 // text, 4
			}
			{
				(string text, int length) = Method();
				Console.WriteLine($"{text}, {length}");                 // text, 4
			}

			Console.ReadKey();
		}

		static (string text, int length) Method()
		{
			string text = "text";
			return (text: text, length: text.Length);
		}
    }
}
