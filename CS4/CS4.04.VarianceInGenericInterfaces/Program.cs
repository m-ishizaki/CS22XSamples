using System;

// ・ジェネリックの共変性と反変性
// https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/in-generic-modifier
// https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/out-generic-modifier
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/concepts/covariance-contravariance/variance-in-generic-interfaces
// 共変性により、ジェネリック型の変数に型パラメータがサブクラスにであるオブジェクトを代入できる。 反変性によりジェネリック型の変数に型パラメータがスーパークラスにであるオブジェクトを代入できる。
namespace CS4.VarianceInGenericInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // 反変 実体のメソッド Set(object) に、Set(string) で string をパラメーターとしても問題ない
            IA<string> a = new A<object>();
            a.Set("text");

            // 共変 実体の戻り値 string を、object 変数に代入しても問題ない
            IB<object> b = new B<string>();
            object o = b.Get();

            Console.ReadKey();
        }
    }

    interface IA<in T>
    {
        void Set(T t);
    }

    class A<T> : IA<T>
    {
        public void Set(T t) {; }
    }

    interface IB<out T>
    {
        T Get();
    }

    class B<T> : IB<T>
    {
        private T _t;
        public void Set(T t) { _t = t; }
        public T Get() { return _t; }
    }
}
