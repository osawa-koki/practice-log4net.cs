using log4net;
using System;
using System.Reflection;

namespace practice_log4net.cs
{
  internal class Program
  {
    static void Main()
    {
      var logger = LogManager.GetLogger(Assembly.GetExecutingAssembly().FullName);

      // ログ出力
      logger.Debug("デバッグ：処理の中間情報");
      logger.Info("情報：操作履歴");
      logger.Warn("注意：現在は正常に動作が続けられるがデータ不整合の可能性がある操作。");
      logger.Error("エラー：復旧可能な障害。継続できるが処理はロールバックされる。");
      logger.Fatal("障害：アプリケーションが強制終了する障害");

      Console.ReadLine();
    }
  }
}
