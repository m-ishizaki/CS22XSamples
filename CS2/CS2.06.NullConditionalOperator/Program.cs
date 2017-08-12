using System;

// ・?? 演算子
// https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/operators/null-conditional-operator
// null 合体演算子と呼ばれる。左側のオペランドが null 値でない場合には左側のオペランドを返し、null 値である場合には右側のオペランドを返す。
namespace CS2.NullConditionalOperator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			string a = "a";
			string b = null;
			Console.WriteLine(a);   // a
			Console.WriteLine(b ?? "b is null");    // b is null

			Console.ReadKey();
        }
    }
}
