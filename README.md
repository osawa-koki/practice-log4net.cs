# practice-log4net.cs

log4netの学習用プロジェクト。  
特に難しいことはない。  

## 使い方

```log4net.config
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <log4net>

    <appender name="RollingLogFileAppender" type="log4net.Appender.RollingFileAppender">
      <file value="application.log" />
      <appendToFile value="true" />
      <rollingStyle value="Size" />
      <maxSizeRollBackups value="10" />
      <maximumFileSize value="1MB" />
      <layout type="log4net.Layout.PatternLayout">
        <conversionPattern value="%d{yyyy-MM-ddTHH:mm:ss} [%-5level] - %message%newline" />
      </layout>
    </appender>

    <root>
      <level value="DEBUG" />
      <appender-ref ref="RollingLogFileAppender" />
    </root>

  </log4net>
</configuration>
```

```cs
var logger = LogManager.GetLogger(Assembly.GetExecutingAssembly().FullName);

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
