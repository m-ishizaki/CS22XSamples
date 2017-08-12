using System;

// ・式形式のメンバーの追加(More expression bodied members)
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members(英語)
// コンストラクター、ファイナライザー、プロパティの setter・getter、メソッドを式で定義できる。
namespace CS7.MoreExpressionBodiedMembers
{
	class Program
	{
		static void Main(string[] args)
		{
			MyClass a = new MyClass("saitama");
			MyClass b = new MyClass("gunma");
			Console.WriteLine(object.Equals(a, b));    // False

			Console.ReadKey();
		}
	}

	class MyClass
	{
		internal MyClass(string value) => _value = value;
		~MyClass() => Value = null;

		private string _value;
		internal string Value
		{
			get => _value;
			set => _value = value;
		}

		public override bool Equals(object obj) => obj is MyClass c && this.Value == c.Value;
		public override int GetHashCode() => base.GetHashCode();
	}
}
