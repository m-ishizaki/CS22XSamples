using System;

// ・Null 許容型(Nullable)
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/nullable-types/
// Null 許容型は、基になる値型の値だけでなく、null 値も表すことができる。
namespace CS2.NullableTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int? a = 1;
            a = null;
            Console.WriteLine(a == null);   // True
            a = 1;
            Console.WriteLine(a.Value);     // 1

            Console.ReadKey();
        }
    }
}
