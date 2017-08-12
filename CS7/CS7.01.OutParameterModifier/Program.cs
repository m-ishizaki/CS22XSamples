using System;

// ・out 変数をメソッド呼び出しの引数リスト内で宣言(Out variables)
// https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/out-parameter-modifier
// out 引数を含むメソッドの呼び出しの際に、out 変数を、メソッド呼び出しの引数リスト内で宣言できる。
namespace CS7.OutParameterModifier
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			string text = "10";
			if (!int.TryParse(text, out int i))
			{
				Console.WriteLine($"{text} を int にパースできませんでした");

				Console.ReadKey();
				return;
			}
			Console.WriteLine($"{text} を int: {i} にパースできました");  // 10 を int: 10 にパースできました

			Console.ReadKey();
        }
    }
}
