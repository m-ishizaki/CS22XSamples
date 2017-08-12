using System;

// ・get アクセサーのみの自動実装プロパティ を式本体の定義
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/properties
// 読み取り専用プロパティの場合に get アクセサーを式形式のメンバーとして実装できる。
namespace CS6.Properties
{
    class MainClass
    {
		static void Main(string[] args)
		{
			FirstName = "埼玉";
			LastName = "太郎";
			Console.WriteLine(FullName);   // 埼玉 太郎

			Console.ReadKey();
		}

		static string FirstName { get; set; }
		static string LastName { get; set; }
		static string FullName => $"{FirstName} {LastName}";
    }
}
