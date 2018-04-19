# GracefulTear　　　　　　　　　　　　　　　　　　　[中文](README.zh-cn.md)

Project GracefulTear Provides Registration, Login, and Authorization for [Erechtheion](https://github.com/dotnet-china/Erechtheion)

## Summary

* .NET CORE SDK >= 2.0
* Visual Studio 2017 Community or JetBrains Rider 2017.3

## Development Guide

* Set GracefulTear.Web as atartup project
* Run the following command in the Package Manager Console

```
add-migration GracefulTear -c GracefulTearDbContext
add-migration Id4Configuration -c ConfigurationDbContext
add-migration Id4PersistedGrants -c PersistedGrantDbContext

```

* Run the following command if success

```
update-database -Context GracefulTearDbContext
update-database -Context PersistedGrantDbMigration
update-database -Context ConfigurationDbMigration
```