using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppPractice.MarkupExtensions
{
    //[ContentProperty(nameof(SizeKey))] は SizeKey をデフォルトプロパティにするための属性
    //デフォルトプロパティとは？xamlで参照する際にSizeKey = を省略して XAML を簡潔に書ける
    //nameof(SizeKey) を使うのは型安全性や修正漏れのときにエラーが出る状態を確保し、リファクタリング時のミスを防ぐため
    //SizeKey の名前は自由に決めてOK
    [ContentProperty(nameof(SizeKey))]

    //このアノテーション[AcceptEmptyServiceProvider]はなに？
    //IServiceProviderの機能を使ってるか、使ってないか明示しないと警告が出るので必要
    //IServiceProviderはつかわなくてもProvideValueの引数に必要なので、削除はできない。

    //[RequireService]：IServiceProviderを使うときはこれにしないといけない
    //[AcceptEmptyServiceProvider]：IServiceProviderを使ってないときはこれにする

    //今はつかってないので、[AcceptEmptyServiceProvider]にする
    //今後つかうときに[AcceptEmptyServiceProvider]に変える

    [AcceptEmptyServiceProvider]
    public class GlobalFontSizeExtension : IMarkupExtension
    {
        public string SizeKey { get; set; } = "Default";

        //ProvideValueの名前はIMarkupExtension インターフェースで定義されているメソッド名で変更不可
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            //C#でのSwitch文：SizeKeyという名前で受け取った名前と一致した値を返す
            return SizeKey switch
            {
                "MainPage.Title" => 24.0,
                "MainPage.MenuFont" => 18.0,
                _ => 16.0, // デフォルトフォントサイズ
            };
        }
    }

}
