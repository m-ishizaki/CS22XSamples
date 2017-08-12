using System;

// ・:: 演算子
// https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/operators/namespace-alias-qualifer
// 名前空間エイリアス修飾子として global を指定すると、常にグローバル名前空間で検索が実行される。
namespace CS2.NamespaceAliasQualifer
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("csharp");         // MyMethod
            global::System.Console.WriteLine("csharp"); // csharp

            global::System.Console.ReadKey();
        }
    }

    class System
    {
        internal class Console
        {
            internal static void WriteLine(string text)
            {
                global::System.Console.WriteLine("MyMethod");
            }
        }
    }
}
