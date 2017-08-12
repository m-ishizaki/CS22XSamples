using System;

// ・匿名型
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/anonymous-types
// 明示的に型を定義することなく、複数の読み取り専用プロパティを持ったオブジェクトを生成できる。 各プロパティの型はコンパイラにより推論される。
namespace CS3.AnonymousTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			var p = new { Name = "窓スマ", Size = 5.0 };

			Console.WriteLine(string.Format("{0}, {1} インチ", p.Name, p.Size));    // 窓スマ, 5 インチ
			Console.WriteLine(string.Format("p is {0}", p.GetType().Name));    // p is <>f__AnonymousType0`2
			Console.WriteLine(string.Format("Name is {0}", p.Name.GetType().Name));    // Name is String
			Console.WriteLine(string.Format("Size is {0}", p.Size.GetType().Name));    // Name is Double

			Console.ReadKey();
        }
    }
}
