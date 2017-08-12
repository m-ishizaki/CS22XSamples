using System;

// ・throw 式(Throw expressions)
// https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/throw
// throw を、式およびステートメントとして使用できる。
namespace CS7.ThrowExpressions
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				MyClass c = new MyClass(null);
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine(ex.Message);  // 値が有効な範囲にありません。
			}

			Console.ReadKey();
		}
	}

	class MyClass
	{
		internal MyClass(string value) => _value = value ?? throw new ArgumentException();

		private string _value;
		internal string Value
		{
			get => _value;
			set => _value = value ?? throw new ArgumentException();
		}

		internal string GetValue() => throw new ArgumentException();
		internal void SetValue(string value) => _value = value ?? throw new ArgumentException();
	}
}
