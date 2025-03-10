using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using MauiAppPractice.Models;//モデルクラスを使用するために追加

namespace MauiAppPractice.Repository
{

    // internal は C# のアクセス修飾子
    // internal は同じアセンブリ内からのみアクセス可能
    // App.xaml.cs からアクセスするために public に変更している
    public class BlackboardSettingRepository
    {
        //nullk許容警告がでるので、?のnull許容演算子を追加した
        private SQLiteConnection? conn;
        private readonly string _dbPath;

        //コンストラクタ
        public BlackboardSettingRepository(string dbPath)
        {
            _dbPath = dbPath;
            Init();
        }

        //DB接続するときに最初に動かす関数
        //MauiProgram.csで設定したdbPath(DBの保存先)をコンストラクタで受け取ってDBに接続する
        //workphoto.db というSQLiteデータベースファイルをローカルに作成
        private void Init()
        {
            //これにより、SQLite データベースの初期化コードは 1 回しか実行されなくなります
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<BlackboardSetting>();
        }

        //データを取得するメソッド
        public List<BlackboardSetting> GetAllBlackboardSettings()
        {
            Init();
            //C:\data\MauiAppPractice\Models\BlackboardSetting.csでrequiredがあるからエラーが出る。あとで確認
            //return conn.Table<BlackboardSetting>().ToList();

            //仮のデータをリストで返す
            return new List<BlackboardSetting>
            {
                new BlackboardSetting
                {
                    Id = 1,
                    BusinessName = "テスト事業",
                    SiteName = "テスト現場",
                    WorkType = 0, // 作業前
                    ForestSmallTeam = "小班A",
                    SmallTeam = "チーム1"
                }
            };
        }

        //データを追加するメソッド
        public int AddBlackboardSetting(BlackboardSetting setting)
        {
            Init();
            //Initでnullにならないようにしてるので、conn!でnull許容演算子を追加
            return conn!.Insert(setting);

            //本当はバリデーション結果の判定が必要？
            //Insertに渡すオブジェクトは本当はresult = conn.Insert(new Person { Name = name });こんな感じ？
            //try catchでエラー処理が必要？
        }

    }

}
