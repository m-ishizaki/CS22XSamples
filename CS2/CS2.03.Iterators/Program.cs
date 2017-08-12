using System;
using System.Collections.Generic;

// ・反復子(yield)
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/concepts/iterators
// 反復子を使用して、リストや配列などのコレクションをステップ実行することができる。
namespace CS2.Iterators
{
    class MainClass
    {
        static void Main(string[] args)
        {
            foreach (int number in Values())
            {
                Console.WriteLine(number.ToString());    // 1
                                                         // 2
                                                         // 3
            }

            Console.ReadKey();
        }

        public static IEnumerable<int> Values()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }
    }
}
