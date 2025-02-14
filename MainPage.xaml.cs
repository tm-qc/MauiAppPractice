namespace MauiAppPractice;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    //黒板一覧・編集画面への遷移
    private async void OnGoToBlackboardListPage(object sender, EventArgs e)
    {
        //ルート名で指定するが・・
        //ShellContent(MauiAppPractice\AppShell.xaml)に登録されたページでトップレベルのページ (ShellContent) にナビゲーションするときは絶対パス /// で指定する必要がある
        await Shell.Current.GoToAsync("///BlackboardListPage");
    }
}