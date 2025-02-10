namespace MauiAppPractice
{
    //App.xaml ファイルの分離コードです
    //実行時のアプリケーションを表します
    public partial class App : Application
    {

        //このクラスのコンストラクターでは、初期ウィンドウを作成して MainPage プロパティに割り当てます
        //このプロパティにより、アプリケーションの実行を開始するときに表示されるページが決定されます
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }

        //起動時やトリガーのライフサイクル イベントをオーバライドできるらしいが
        //ChatGPT曰く、非推奨のコード書いてある？
        //公式でも最初にまた後で説明と書いてあるので、後まわし
        //protected override void OnStart()
        //{
        //    base.OnStart();
        //}

        //protected override void OnResume()
        //{
        //    base.OnResume();
        //}

        //protected override void OnSleep()
        //{
        //    base.OnSleep();
        //}
    }
}