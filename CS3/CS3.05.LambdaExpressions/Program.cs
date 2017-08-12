using System;

// ・ラムダ式
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/statements-expressions-operators/lambda-expressions
// 匿名関数。引数として渡したり関数呼び出しの結果値として返すことができるローカル関数を記述できる。あらゆる場所で使われるが、LINQ を使用する際に特に重要。
namespace CS3.LambdaExpressions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            System.Threading.Timer t = new System.Threading.Timer(
			    // delegate (object state) { Console.WriteLine("delegate"); } // delegate による匿名メソッド
			    state => Console.WriteLine("lambda") // ラムダ式による匿名メソッド
			                                         // (object state) => { Console.WriteLine("lambda"); } // <- このような記述も可能
			    , null, 0, 1000
			);
            // "lambda" を繰り返し出力

            Console.ReadKey();
        }
    }
}
