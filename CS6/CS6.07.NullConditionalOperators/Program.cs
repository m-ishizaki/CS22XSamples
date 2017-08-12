using System;

// ・Null 条件演算子
// https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/operators/null-conditional-operators
// メンバー アクセスおよびインデックス操作のチェーンの 1 つの演算が null を返す場合、チェーンの実行の残りの部分を停止し null を返すショートサーキット。
namespace CS6.NullConditionalOperators
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			string s = "text";
			Console.WriteLine(s.Length.ToString()); // 4
			Console.WriteLine(s.ToCharArray()[0]); // t

			s = null;
			try
			{
				Console.WriteLine(s.Length.ToString()); // 例外発生
				Console.WriteLine(s.ToCharArray()[0]);
			}
			catch (NullReferenceException ex)
			{
				Console.WriteLine(ex.Message);
			}

			Console.WriteLine(s?.Length.ToString() == null); // True
			Console.WriteLine(s?.ToCharArray()[0] == null);  // True

			Console.ReadKey();
        }
    }
}
