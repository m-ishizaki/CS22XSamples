using System;
using System.Threading.Tasks;

// ・一般的な型での非同期メソッドの戻り値(ValueTask)(Generalized async return types)
// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7#generalized-async-return-types(英語)
// async 非同期メソッド内で非同期処理が必要である場所を通らなかった場合、Task オブジェクトを作らない事ができる。 [注意] この機能を使用するには NuGet で System.Threading.Tasks.Extensions を追加する必要がある。
namespace CS7.GeneralizedAsyncReturnTypes
{
    class MainClass
    {
		static void Main(string[] args)
		{
			int a = Func(true).Result;
			int b = Func(false).Result;
			Console.WriteLine(a);
			Console.WriteLine(b);

			Console.ReadKey();
		}

		static async ValueTask<int> Func(bool b)
		{
			if (b) return 0;
			await Task.Delay(1).ConfigureAwait(false);
			return 1;
		}
    }
}
