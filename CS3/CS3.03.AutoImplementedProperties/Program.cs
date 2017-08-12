using System;

// ・自動実装プロパティ
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties
// 値の取得または設定時にロジックが必要ない場合、プロパティを簡潔に宣言できる。
namespace CS3.AutoImplementedProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone p = new Phone();
            p.Name = "窓スマ";
            p.Size = 5.0;
            Console.WriteLine(string.Format("{0}, {1} インチ", p.Name, p.Size));    // 窓スマ, 5 インチ

            Console.ReadKey();
        }
    }

    class Phone
    {
        internal string Name { get; set; }
        internal double Size { get; set; }
    }
}
