using System;
using System.Linq;
using System.Threading.Tasks;

// ・非同期処理(async/await)
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/concepts/async/
// 同期メソッドの作成とほぼ同様の容易さで、非同期メソッドを作成できる。
// Mac の場合は、プロジェクトテンプレートで「.NET Core > App > Console Application」ではなく、「その他 > .NET > コンソールプロジェクト」で作成し、NuGet で Microsoft HTTP Client Libraries を追加してください。
// ※環境によって下記サンプルがエラーとなります。その場合、別の非同期メソッドで確認してください。
namespace CS5.Async
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Method();               // 同期メソッドでの取得
            MethodAsync().Wait();   // 非同期メソッドでの取得

            Console.ReadKey();
        }

        /// <summary>
        /// 非同期メソッドでの取得
        /// </summary>
        /// <returns></returns>
        static async Task<string> MethodAsync()
        {
            Console.WriteLine("Start MethodAsync");

            var client = new System.Net.Http.HttpClient();
            var html = await client.GetStringAsync("http://rksoftware.hatenablog.com/");

            Console.WriteLine(html.Take(100).ToArray());

            Console.WriteLine("End MethodAsync");

            return html;
        }

        /// <summary>
        /// 同期メソッドでの取得
        /// </summary>
        static void Method()
        {
            Console.WriteLine("Start Method");

            var client = new System.Net.WebClient();
            client.DownloadStringCompleted +=
                (object sender, System.Net.DownloadStringCompletedEventArgs e) =>
                {
                    Console.WriteLine("Start Client_DownloadStringCompleted");

                    Console.WriteLine(new string(e.Result.Take(100).ToArray()));

                    Console.WriteLine("End Client_DownloadStringCompleted");
                };
            client.DownloadStringAsync(new Uri("http://rksoftware.hatenablog.com/"));

            Console.WriteLine("End Method");
        }
    }
}
