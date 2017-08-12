using System;

// ・呼び出し元情報の属性(CallerMemberName など)
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/concepts/caller-information
// メソッドの呼び出し元の情報を省略可能な引数として取得できる。
namespace CS5.CallerInformation
{
    class MainClass
    {
        static void Main(string[] args)
        {
            MyMethod();         // message: message
                                // member name: MyMethod
                                // source file path: XXXXX\XXXXX\Program.cs
                                // source line number: 21
            MyProperty = 10;    // MyProperty changed: 0-> 10

            Console.ReadKey();
        }

        static void MyMethod()
        {
            WriteTrace("message");
        }

        private static int _myProperty;
        static int MyProperty
        {
            get { return _myProperty; }
            set { WritePropertyChanged(_myProperty, value); _myProperty = value; }
        }

        static void WriteTrace(string message,
                [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
                [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
                [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0)
        {
            Console.WriteLine(string.Format("message: {0}", message));
            Console.WriteLine(string.Format("member name: {0}", memberName));
            Console.WriteLine(string.Format("source file path: {0}", sourceFilePath));
            Console.WriteLine(string.Format("source line number: {0}", sourceLineNumber));
        }

        static void WritePropertyChanged(object oldValue,
            object newValue,
            [System.Runtime.CompilerServices.CallerMemberName]string name = "")
        {
            Console.WriteLine(string.Format("{0} changed: {1} -> {2}", name, oldValue, newValue));
        }
    }
}
