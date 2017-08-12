using System;

// ・拡張メソッド
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
// 既存の型に外からメソッドを追加できる。
namespace CS3.ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "text";
            Console.WriteLine(s.HasValue());    // True
            s = null;
            Console.WriteLine(s.HasValue());    // False

            Console.ReadKey();
        }
    }

    static class StringExtensions
    {
        internal static bool HasValue(this string value)
        {
            return !string.IsNullOrEmpty(value);
        }
    }
}
