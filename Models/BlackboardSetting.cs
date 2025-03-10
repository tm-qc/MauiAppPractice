using System; // 基本の .NET クラス（DateTime などを使用するとき）
using SQLite; // SQLiteを使うときに必要
using System.ComponentModel.DataAnnotations.Schema;// [Column], [Table] などを使用
using System.ComponentModel.DataAnnotations;// [Key], [Required] などのEF Coreアノテーションを使用

namespace MauiAppPractice.Models
{
    public class BlackboardSetting
    {
        // 主キー
        //[Key]：このアノテーションは省略可能（Id という名前のプロパティは自動的に主キーとして認識される）
        public int Id { get; set; }

        // 事業名
        // DB上そのまま "BusinessName" にしたい場合はアノテーションは省略可能
        // DB上のカラム名を例えばsnake_caseにしたいときはアノテーション指定する
        //[Column("business_name")]

        // バリデーションの設定
        // アノテーションでクライアント、サーバー双方でバリデーション可能
        // Requiredは必須、ErrorMessage{0}はプロパティ名、{1}は検証条件などを表示できる
        // 
        // コントローラーで検証結果検知「if (ModelState.IsValid)」
        //
        // この警告どうする？
        // 'MaxLength' は、'System.ComponentModel.DataAnnotations.MaxLengthAttribute' と 'SQLite.MaxLengthAttribute' 間のあいまいな参照です
        //
        // SQLite.MaxLengthだけだとDBだけになるらしいので、両方使うでとりあえず。
        // なので、SQLite.MaxLength(100)と記載しておく
        [Required(ErrorMessage = "{0}は必須です"), SQLite.MaxLength(100)]

        //null許容警告がでるので、nullでいいのか？nullはだめで必須なのかを記載しないといけないので、
        //型定義の前にrequiredを記載する
        public required string BusinessName { get; set; }

        // 現場名
        [Required(ErrorMessage = "{0}は必須です"), SQLite.MaxLength(100)]
        public required string SiteName { get; set; }

        // 作業種：作業前、作業中、作業後等の状態を int で管理
        // TODO：intもいいが、Enumを使った方が型の安全性的に良さそうなので、基盤が出来たら変更する
        [Required(ErrorMessage = "{0}は必須です"), SQLite.MaxLength(100)]
        public required int WorkType { get; set; }

        // 林小班
        [Required(ErrorMessage = "{0}は必須です"), SQLite.MaxLength(100)]
        public required string ForestSmallTeam { get; set; }

        // 小班
        [Required(ErrorMessage = "{0}は必須です"), SQLite.MaxLength(100)]
        public required string SmallTeam { get; set; }
    }
}
