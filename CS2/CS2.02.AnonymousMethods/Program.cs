using System;

// ・匿名メソッド
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/statements-expressions-operators/anonymous-methods
// [推奨されません(※)] delegate をインライン コードで生成できる。 (※)C# 3.0 で追加されたラムダ式を使用してください。
namespace CS2.AnonymousMethods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            System.Threading.Timer t = new System.Threading.Timer(
                delegate (object state) { Console.WriteLine("delegate"); } // 匿名メソッド
                , null, 0, 1000
                );
            // "delegate" を繰り返し出力

            Console.ReadKey();
        }
    }
}
