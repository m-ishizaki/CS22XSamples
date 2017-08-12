using System;
using System.Linq;

// ・オブジェクト初期化子
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
// オブジェクトの作成時にプロパティに、値を割り当てることができる。匿名型の使用時にも使われる。
namespace CS3.ObjectAndCollectionInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint p = new MyPoint() { X = 10, Y = 20 };
            Console.WriteLine(string.Format("{0}, {1}", p.X, p.Y)); // 10, 20

            var anonymous = new[] { 1, 2, 3 }.Select(x => new { Source = x, W = x * 2 });
            foreach (var m in anonymous)
            {
                Console.WriteLine(string.Format("{0}, {1}", m.Source, m.W)); // 1, 2
                                                                             // 2, 4
                                                                             // 3, 6
            }

            Console.ReadKey();
        }
    }

    class MyPoint
    {
        internal int X { get; set; }
        internal int Y { get; set; }
    }
}
