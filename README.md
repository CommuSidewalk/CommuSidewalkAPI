# CommuSidewalkAPI

## Develop

Create appsettings.json
```json
{
  ...
  "ConnectionStrings": {
    "SidewalkDatabase": "Host=YOUR_HOST;Username=YOUR_USERNAME;Password=YOUR_PASSWORD;Database=YOUR_DB"
  }
}
```
## Roadmap

目標上是當作 commusidewalk-app 網頁後端，可能的問題是 Neon 資料庫和 .NET 後端的物理距離，而且 Neon 不能使用 PostGIS。

### 基本資料篩選

1. GET 日期區間 filter
2. GET 行政區（AD） filter
3. GET 分數 filter

### 取代 sveltekit 後端

### 儲存其他 table

事故資料等
