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
    /// DB�m�F�e�X�g�p
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnAddDataClicked(object sender, EventArgs e)
    {
        var setting = new BlackboardSetting
        {
            BusinessName = "�e�X�g����",
            SiteName = "�e�X�g����",
            WorkType = 1, // ��ƒ�
            ForestSmallTeam = "�я���",
            SmallTeam = "����"
        };

        App.BlackboardRepo.AddBlackboardSetting(setting);
        DisplayAlert("����", "�f�[�^���ǉ�����܂���", "OK");
    }

    /// <summary>
    /// �ǉ��f�[�^���m�F
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnGetDataClicked(object sender, EventArgs e)
    {
        var settings = App.BlackboardRepo.GetAllBlackboardSettings();

        string result = "�f�[�^�ꗗ:\n";
        foreach (var setting in settings)
        {
            result += $"ID: {setting.Id}, ���Ɩ�: {setting.BusinessName}, ���ꖼ: {setting.SiteName}\n";
        }

        DisplayAlert("�f�[�^�ꗗ", result, "OK");
    }

    /// <summary>
    /// SQLite�̕ۑ���̊m�F
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnShowDbPathClicked(object sender, EventArgs e)
    {
        string dbPath = FileAccessHelper.GetLocalFilePath("workphoto.db");
        DisplayAlert("DB�̕ۑ��ꏊ", dbPath, "OK");
    }
}