using System;

// ・式形式のメンバー
// https://docs.microsoft.com/ja-jp/dotnet/csharp/methods#expr
// メソッドの本文が 1 つのステートメントの場合、=> を使用した構文ショートカットが使用できる。
namespace CS6.MethodsExpr
{
    class MainClass
    {
		static void Main(string[] args)
		{
			MyClass c = new MyClass();
			c.FirstName = "埼玉";
			c.LastName = "太郎";
			Console.WriteLine(c.ToString());   // 埼玉 太郎

			Console.ReadKey();
		}

		class MyClass
		{
			internal string FirstName { get; set; }
			internal string LastName { get; set; }
			public override string ToString() => $"{FirstName} {LastName}";
		}
    }
}
