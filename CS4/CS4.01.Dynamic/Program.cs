using System;

// ・dynamic 型
// https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/dynamic
// dynamic 型はコンパイル時の型チェックを行わず、実行時に解決される。
namespace CS4.Dynamic
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			try
			{
				dynamic a = 1;
				Console.WriteLine(a);                   // 1
				Console.WriteLine(a.GetType().Name);    // Int32

				a = a + 1;
				Console.WriteLine(a);                   // 2

				a = "text";
				a = a + 1;
				Console.WriteLine(a);                   // text1
				Console.WriteLine(a.GetType().Name);    // String
				Console.WriteLine(a.ToString());        // text1

				Console.WriteLine(a.ToString2());       // <- 実行時エラー「'string' に 'ToString2' の定義がありません」
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			Console.ReadKey();
        }
    }
}
