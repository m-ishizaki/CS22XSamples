using System;

// ・Conditional 属性
// https://msdn.microsoft.com/ja-jp/library/aa664622(v=vs.71).aspx
// 条件付きコンパイル シンボルによる条件付きメソッドを定義ができる。シンボルが定義されていない場合、メソッドの呼び出しが行われない。
namespace CS2.ConditionalAttribute
{
    class MainClass
    {
        static void Main(string[] args)
        {
            WriteDebug();   // デバッグ時のみ実行される
            Console.WriteLine("END");

            Console.ReadKey();
        }

        [System.Diagnostics.Conditional("DEBUG")]
        public static void WriteDebug()
        {
            Console.WriteLine("Debug Mode");
        }
    }
}
