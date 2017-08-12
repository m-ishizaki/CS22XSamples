using System;

// ・部分型定義 (Partial クラス/構造体)
// https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/partial-type
// クラス、構造体、またはインターフェイスの定義を複数のファイルに分割することができる。
namespace CS2.PartialType
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.A1(); // A1
            a.A2(); // A2

            Console.ReadKey();
        }
    }

    partial class A
    {
        public void A1() { Console.WriteLine("A1"); }
    }

    partial class A
    {
        public void A2() { Console.WriteLine("A2"); }
    }
}
