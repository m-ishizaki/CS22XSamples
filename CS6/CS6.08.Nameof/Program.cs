using System;

// ・nameof
// https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/nameof
// 変数、型、またはメンバーの名前を文字列として取得できる。
namespace CS6.Nameof
{
	class Program
	{
		static void Main(string[] args)
		{
			int variable;

			Console.WriteLine(nameof(Program));     // Program
			Console.WriteLine(nameof(variable));    // variable
			Console.WriteLine(nameof(MyMethod));    // MyMethod
			Console.WriteLine(nameof(MyProperty));  // MyProperty

			Console.ReadKey();
		}

		static void MyMethod() {; }
		static int MyProperty { get; set; }
	}
}
