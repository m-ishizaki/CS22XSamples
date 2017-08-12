using System;
using System.Collections.Generic;

// ・ジェネリック
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/generics/
// List<T> クラスなどの T の機能。List<int> とすると int 型しか格納できないタイプセーフな List を使用できる。
namespace CS2.Generics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			List<int> ints = new List<int>();
			// ints.Add("text"); <- これはできない
			ints.Add(1);
			int i = ints[0];
			Console.WriteLine(i);

			List<string> strings = new List<string>();
			// strings.Add(1); <- これはできない
			strings.Add("text");
			string s = strings[0];
			Console.WriteLine(s);

			Console.ReadKey();
        }
    }
}
