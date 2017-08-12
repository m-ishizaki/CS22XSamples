using System;
using System.Linq;
using System.Threading.Tasks;

// ・catch/finally ブロック内での await
// https://docs.microsoft.com/ja-jp/dotnet/csharp/whats-new/csharp-6#await-in-catch-and-finally-blocks(英語)
// catch および finally ブロックで await による非同期処理ができる。
// Mac の場合は、プロジェクトテンプレートで「.NET Core > App > Console Application」ではなく、「その他 > .NET > コンソールプロジェクト」で作成し、NuGet で Microsoft HTTP Client Libraries を追加してください。
// ※環境によって下記サンプルがエラーとなります。その場合、別の非同期メソッドで確認してください。
namespace CS6.AwaitInCatchAndFinallyBlocks
{
    class MainClass
    {
		static void Main(string[] args)
		{
			MethodAsync().Wait();   // 非同期メソッドでの取得

			Console.ReadKey();
		}

		static async Task<string> MethodAsync()
		{
			var client = new System.Net.Http.HttpClient();
			var html = await client.GetStringAsync("http://rksoftware.hatenablog.com/about");
			try
			{
				html = html.Substring(0, int.MaxValue);
			}
			catch (ArgumentOutOfRangeException ex)
			{
				Console.WriteLine(ex.Message);
				html = await client.GetStringAsync("http://rksoftware.hatenablog.com/about");
				html = new string(html.Take(100).ToArray());
			}

			Console.WriteLine(html);

			return html;
		}
    }
}
