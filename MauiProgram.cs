using Microsoft.Extensions.Logging;

//各ネイティブ プラットフォームには、アプリケーションを作成して初期化するさまざまな開始点があります
//このコードは、プロジェクトの Platforms フォルダー内にあります

//最後に静的 MauiProgram クラスの CreateMauiApp メソッドを呼び出します

//多分各プラットフォームの開始地点が最終的にここに集約するということ

namespace MauiAppPractice
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            //多分アプリ全体の設定を書くのかな？
            //アプリ ビルダーには、フォントの登録、依存関係の挿入のためのサービスの構成、コントロールのカスタム ハンドラーの登録などのタスクのメソッドも用意されています
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                //次のコードは、アプリ ビルダーを使用してフォントを登録する例を示しています
                //アプリの実行を開始するときに、フォント フォルダーに追加されたすべてのフォントをアプリ ビルダー オブジェクトに登録する必要があります
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
