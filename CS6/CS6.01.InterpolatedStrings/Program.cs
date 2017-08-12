using System;

// ・挿入文字列
// https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/interpolated-strings
// 含まれる挿入式をその文字列表現に置き換えた文字列を返す。
namespace CS6.InterpolatedStrings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			string firstName = "埼玉";
			string lastName = "太郎";
			Console.WriteLine($"{firstName} {lastName}");   // 埼玉 太郎

			Console.ReadKey();
        }
    }
}
