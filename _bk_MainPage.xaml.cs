namespace MauiAppPractice
{
    //MainPage.xamlの分離コード
    public partial class _bk_MainPage : ContentPage
    {
        //int count = 0;

        public _bk_MainPage()
        {
            InitializeComponent();
        }


        //イベント メソッドの決まり

        //・値を返すことはできません。メソッドは void でなければなりません
        //・2 つのパラメーターを受け取る必要があります
        //  ※object sender, EventArgs eは定型文でOK
        //　　※object sende：イベントを発生元の要素
        //　　※EventArgs e：イベント元に渡された引数
        //・イベント ハンドラーは private にするべきです。 これは強制ではありませんが、意図されない呼び出しを防ぐために推奨されます
        //・イベント ハンドラーは、非同期操作を実行する必要がある場合は async にすることができます
        //・メソッドの名前は標準規則に従います。On の後にコントロールの名前、その後にイベントの名前

        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    //音声読み上げが必要な時に記載。ビューへの表示だけなら不要
        //    //SemanticScreenReader.Announce(CounterBtn.Text);
        //}
    }

}
