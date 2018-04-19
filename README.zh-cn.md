# GracefulTear　　　　　　　　　　　　　　　　　　[English](README.md)

GracefulTear 项目为 dotnet-china 社区论坛项目 [Erechtheion](https://github.com/dotnet-china/Erechtheion) 提供注册、登录与授权服务

## 概述

* .NET CORE SDK >= 2.0
* Visual Studio 2017 社区版或 JetBrains Rider 2017.3

## 开发说明

* 设置 GracefulTear.Web 为启动项目
* 在 Package Manager Console 中运行如下命令

```
add-migration GracefulTear -c GracefulTearDbContext
add-migration Id4Configuration -c ConfigurationDbContext
add-migration Id4PersistedGrants -c PersistedGrantDbContext

```

* 执行成功后再运行

```
update-database -Context GracefulTearDbContext
update-database -Context PersistedGrantDbMigration
update-database -Context ConfigurationDbMigration
```