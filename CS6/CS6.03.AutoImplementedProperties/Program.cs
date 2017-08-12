using System;

// ・自動実装プロパティの初期化
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties
// フィールドと同様に自動実装プロパティを初期化することができる。
namespace CS6.AutoImplementedProperties
{
    class MainClass
    {
		static void Main(string[] args)
		{
			int i = MyProperty;
			Console.WriteLine(i);   // 10

			Console.ReadKey();
		}

		static int MyProperty { get; set; } = 10;
    }
}
