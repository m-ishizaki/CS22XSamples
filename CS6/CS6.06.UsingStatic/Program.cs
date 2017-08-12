using System;
using static System.Math;

// ・using static ディレクティブ
// https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/using-static
// static メソッドなどへアクセスする際、名前空間と同様に型名も指定せずに使用できる using の記述ができる。
namespace CS6.UsingStatic
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.WriteLine(Math.PI); // 3.14159265358979
			Console.WriteLine(PI);      // 3.14159265358979

			Console.ReadKey();
        }
    }
}
