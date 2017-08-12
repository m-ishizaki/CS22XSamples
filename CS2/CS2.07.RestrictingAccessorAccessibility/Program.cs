using System;

// ・プロパティの get/set 個別のアクセスレベル
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/restricting-accessor-accessibility
// プロパティの get アクセサーと set で異なるアクセス レベルを設定できる。
namespace CS2.RestrictingAccessorAccessibility
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            // a.PropertyA = 1; <- これはできない
            a.SetPropertyA(10);
            int propertyValue = a.PropertyA;
            Console.WriteLine(propertyValue);   // 10

            Console.ReadKey();
        }
    }

    class A
    {
        public int PropertyA { get; private set; }
        public void SetPropertyA(int value) { PropertyA = value; }
    }
}
