using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//公式から引用で追加
//MauiProgram.csにとうとつにFileAccessHelper.GetLocalFilePathが出てきた

//OS に依存せず、適切なフォルダ(DBのパス)を取得できるようにするために必要
namespace MauiAppPractice.Helpers
{
    internal class FileAccessHelper
    {
        public static string GetLocalFilePath(string filename)
        {
            return System.IO.Path.Combine(FileSystem.AppDataDirectory, filename);
        }
    }
}
