namespace MauiAppPractice;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    //���ꗗ�E�ҏW��ʂւ̑J��
    private async void OnGoToBlackboardListPage(object sender, EventArgs e)
    {
        //���[�g���Ŏw�肷�邪�E�E
        //ShellContent(MauiAppPractice\AppShell.xaml)�ɓo�^���ꂽ�y�[�W�Ńg�b�v���x���̃y�[�W (ShellContent) �Ƀi�r�Q�[�V��������Ƃ��͐�΃p�X /// �Ŏw�肷��K�v������
        await Shell.Current.GoToAsync("///BlackboardListPage");
    }
}