using System;

// ・配列の型推論(暗黙的に型指定される配列)
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
// 配列の宣言時に暗黙の型指定を行える。コンパイラが型を推論してくれる。
namespace CS3.ImplicitlyTypedArrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			var ints = new[] { 0, 20, 30 }; // ints は int 型の配列
			ints[0] = 10;     // <- これはできる
							  // ints[0] = "text"; <- これはできない
			foreach (var i in ints)
			{
				Console.WriteLine(i); // 10
									  // 20
									  // 30
			}

			Console.ReadKey();
        }
    }
}
