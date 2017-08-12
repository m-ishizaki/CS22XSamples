using System;
using System.Linq;

// ・LINQ
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/concepts/linq/query-syntax-and-method-syntax-in-linq
// データソースからデータを取得する。その際、変換や集計、グループ化などを行うことも可能。クエリ式とメソッド式という 2 つの形式があるが、一般にメソッド式が使われる。下記はメソッド式の例。
namespace CS3.QuerySyntaxAndMethodSyntaxInLinq
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int[] data = new[] { 1, 2, 3, 4, 5, 6 };

			var evens = data.Where(x => x % 2 == 0);        // 偶数だけ取り出す
			foreach (var i in evens)
			{
				Console.Write(i);  // 246
			}

			Console.WriteLine();

			var ws = data.Select(x => x * 2);               // 全てに 2 を乗算する
			foreach (var i in ws)
			{
				Console.Write(i);     // 24681012
			}

			Console.WriteLine();

			var evensws = data.Where(x => x % 2 == 0).Select(x => x * 2);   // 偶数だけ取り出し 2 を乗算する
			foreach (var i in evensws)
			{
				Console.Write(i);     // 4812
			}

			Console.WriteLine();

			Console.WriteLine(data.Max());  // 6;
			Console.WriteLine(data.Min());  // 1;
			Console.WriteLine(data.Sum());  // 21

			Console.ReadKey();
        }
    }
}
