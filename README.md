# practice-log4net.cs

log4netの学習用プロジェクト。  
特に難しいことはない。  

## 使い方

```cs
logger.Debug("デバッグ情報");
logger.Info("通常情報");
logger.Warn("注意情報");
logger.Error("エラー情報");
logger.Fatal("障害(致命的エラー)情報");
```

## 脆弱性関連情報

- [jvn.jp](https://jvn.jp/ta/JVNTA94851885/)

## 参考文献

- [公式ドキュメント](https://logging.apache.org/log4net/)
