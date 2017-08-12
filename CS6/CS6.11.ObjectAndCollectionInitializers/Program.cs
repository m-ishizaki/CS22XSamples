using System;
using System.Collections.Generic;

// ・インデックス初期化(Dictionary 初期化)
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
// 単純なコレクションだけでなく、作成をサポートするコレクション(Dictionary)も初期化子を指定できる。
namespace CS6.ObjectAndCollectionInitializers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>
			{
			    "saitama",
			    "gunma",
			    "ibaraki"
			};

            Dictionary<int, string> dictionary = new Dictionary<int, string>
            {
                [101] = "saitama",
                [201] = "gunma",
                [301] = "ibaraki"
            };

            Console.WriteLine(list[0]);         // saitama
            Console.WriteLine(dictionary[201]); // gunma

            Console.ReadKey();
        }
    }
}
