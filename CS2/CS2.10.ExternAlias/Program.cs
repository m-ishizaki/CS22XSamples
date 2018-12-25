using System;

// ・extern エイリアス
// https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/extern-alias
// 同じ完全修飾型名を持つ、2 つアセンブリを参照する場合に名前空間のエイリアスを設定できる。
// [コード例なし] 同じ完全修飾型名を持つアセンブリを用意し参照する際の機能で、コードだけでは示せない。
namespace CS2.ExternAlias
{
	extern alias DllA;
	extern alias DllB;

	class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(DllA::CS2.ExternAliasDll.MyClass.Text);   // DllA
			Console.WriteLine(DllB::CS2.ExternAliasDll.MyClass.Text);   // DllB

			Console.ReadKey();
        }
    }
}
