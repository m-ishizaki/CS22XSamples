using System;

// ・例外をフィルター処理する述語式(when)
// https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/try-catch
// 処理対象の例外をフィルターする際に、例外オブジェクトの型の評価に続いて、述語式を使用して例外をフィルターできる。
namespace CS6.TryCatch
{
    class MainClass
    {
		static void Main(string[] args)
		{
			MethodA(null, "text");  // text1:Null または Empty です
									// パラメーター名: text1
			MethodA("text", null);  // text2:Null または Empty です
									// パラメーター名: text2
			Console.ReadKey();
		}
		static void MethodA(string text1, string text2)
		{
			try
			{
				MethodB(text1, text2);
			}
			catch (ArgumentException ex) when (ex.ParamName == "text1")
			{
				Console.WriteLine($"{nameof(text1)}:{ex.Message}");
			}
			catch (ArgumentException ex) when (ex.ParamName == "text2")
			{
				Console.WriteLine($"{nameof(text2)}:{ex.Message}");
			}
		}

		static void MethodB(string text1, string text2)
		{
			if (string.IsNullOrEmpty(text1)) throw new ArgumentException("Null または Empty です", nameof(text1));
			if (string.IsNullOrEmpty(text2)) throw new ArgumentException("Null または Empty です", nameof(text2));
		}
    }
}
