using System;

// ・自動実装プロパティ get アクセサーのみの宣言
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties
// get アクセサーのみを宣言し、変更できないプロパティの作成できる。
namespace CS6.AutoImplementedProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass c = new MyClass();
            int i = c.MyProperty;   // <- これはできる
            Console.WriteLine(i);   // 10
									// c.MyProperty = 20; <- これはできない

			Console.ReadKey();
        }
    }

    class MyClass
    {
        internal int MyProperty { get; }
        public MyClass()
        {
            MyProperty = 10;    // コンストラクター内では初期化できる
        }
    }
}
