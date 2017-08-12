using System;

// ・デリゲートの分散(共変性と反変性)
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/concepts/covariance-contravariance/using-variance-in-delegates
// 共変性により、メソッドの戻り値の型をデリゲートに定義されている型のサブクラスにできる。 反変性によりメソッドのパラメーター型をデリゲートのパラメーターの型のスーパークラスにできる。
namespace CS2.UsingVarianceInDelegates
{
    class Program
    {
        class A { }
        class A2 : A { }
        class A3 : A { }

        delegate A2 MyDelegate(A2 a2);

        static void Main(string[] args)
        {
            MyDelegate deleg1 = Method1;    // <- これはできる
            A a = deleg1(new A2());
            //MyDelegate deleg2 = Method2;    <- これはできない
            //MyDelegate deleg3 = Method3;    < -これはできない

            Console.ReadKey();
        }

        static A2 Method1(A a)
        {
            return null;
        }

        static A2 Method2(A3 a)
        {
            return null;
        }

        static A Method3(A2 a)
        {
            return null;
        }
    }
}
