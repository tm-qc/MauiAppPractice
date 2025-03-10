using MauiAppPractice.Helpers;
using MauiAppPractice.Models;

namespace MauiAppPractice;

public partial class BlackboardListPage : ContentPage
{
	public BlackboardListPage()
	{
		InitializeComponent();
	}

    /// <summary>
    /// DB確認テスト用
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnAddDataClicked(object sender, EventArgs e)
    {
        var setting = new BlackboardSetting
        {
            BusinessName = "テスト事業",
            SiteName = "テスト現場",
            WorkType = 1, // 作業中
            ForestSmallTeam = "林小班",
            SmallTeam = "小班"
        };

        App.BlackboardRepo.AddBlackboardSetting(setting);
        DisplayAlert("成功", "データが追加されました", "OK");
    }

    /// <summary>
    /// 追加データを確認
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnGetDataClicked(object sender, EventArgs e)
    {
        var settings = App.BlackboardRepo.GetAllBlackboardSettings();

        string result = "データ一覧:\n";
        foreach (var setting in settings)
        {
            result += $"ID: {setting.Id}, 事業名: {setting.BusinessName}, 現場名: {setting.SiteName}\n";
        }

        DisplayAlert("データ一覧", result, "OK");
    }

    /// <summary>
    /// SQLiteの保存先の確認
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnShowDbPathClicked(object sender, EventArgs e)
    {
        string dbPath = FileAccessHelper.GetLocalFilePath("workphoto.db");
        DisplayAlert("DBの保存場所", dbPath, "OK");
    }
}