using System;

// ・数値リテラルの表記の改善(Literal improvements)
// https://docs.microsoft.com/ja-jp/dotnet/csharp/whats-new/csharp-7#numeric-literal-syntax-improvements(英語)
// 2進数表記でのリテラルを記述できる。数値リテラルの桁数などをわかりやすく記述できる。
namespace CS7.LiteralImprovements
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int nenshu = 50_000_000;
			Console.WriteLine($"年収 {nenshu} 億円");

			int shoyo = 0b0100_0110_0101;
			Console.WriteLine($"賞与 {shoyo} 万円");

			Console.ReadKey();
        }
    }
}
