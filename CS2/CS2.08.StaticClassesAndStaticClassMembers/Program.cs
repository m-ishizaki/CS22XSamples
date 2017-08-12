using System;

// ・static クラス
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members
// new キーワードを使用して、そのクラス型の変数を作成できないクラスを定義できる。
namespace CS2.StaticClassesAndStaticClassMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            // A a = new A(); <- これはできない
            A.PropertyA = 1;
            int a = A.PropertyA;
            Console.WriteLine(a);   // 1

            Console.ReadKey();
        }
    }

    static class A
    {
        public static int PropertyA { get; set; }
    }
}
