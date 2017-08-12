using System;
using System.Collections;
using System.Collections.Generic;

// ・拡張メソッドでコレクション初期化子
// https://docs.microsoft.com/ja-jp/dotnet/csharp/whats-new/csharp-6#extension-add-methods-in-collection-initializers(英語)
// Add メソッドが拡張メソッドで定義されている型も、初期化子を指定できる。
namespace CS6.ExtensionAddMethodsInCollectionInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            MyChass c = new MyChass() { "saitama", "gunma", "ibaraki" };
            Console.WriteLine(c);   // saitama, gunma, ibaraki

            Console.ReadKey();
        }
    }

    class MyChass : IEnumerable<string>
    {
        private List<string> _texts = new List<string>();

        internal void Push(string text)
        {
            _texts.Add(text);
        }

        public override string ToString()
        {
            return string.Join(", ", _texts);
        }

        public IEnumerator<string> GetEnumerator()
        {
            return _texts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _texts.GetEnumerator();
        }
    }

    static class MyClassExtension
    {
        internal static void Add(this MyChass c, string text)
        {
            c.Push(text);
        }
    }
}
