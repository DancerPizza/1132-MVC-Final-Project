# 1132FinalProject

社團資訊網站（ASP.NET Core MVC 8 + EF Core + SQL Server LocalDB）。完全本機、非公開，供本機 host 測試。

## 功能
- 聯絡幹部：人物卡展示（DB 種子資料）
- 新生登記：表單驗證 + 寫入 DB
- 時程表：靜態社課時間表
- 場地租借：純前端暫存展示（不落地 DB）
- 管理員專區：Session 登入 + 新生資料 CRUD + 分頁

## 技術棧
- ASP.NET Core MVC 8（net8.0）
- Entity Framework Core 8
- SQL Server LocalDB
- Bootstrap 5、jQuery、X.PagedList

## 快速開始（本機）
```powershell
# 1. 安裝 EF 工具（僅第一次）
dotnet tool install --global dotnet-ef

# 2. 建立/更新本機資料庫
dotnet ef database update --project 1132FinalProject

# 3. 執行
dotnet run --project 1132FinalProject
```

- 預設網址：`http://localhost:5247`
- 連線字串：`1132FinalProject/appsettings.json` → `ConnectionStrings:CmsContext`
- 管理員帳密：`appsettings.json` → `Admin:Username` / `Admin:Password`（本機 demo 用）

## Demo 資料
- 幹部 6 人、新生 3 筆（EF Migration 種子資料自動寫入）
- IG 連結：僅 Pizza（`dancer_pizza`）為真實連結，其餘為假資料

## 文件
詳細規格、Agent 準則與開發流程見 [`docs/README.md`](docs/README.md)。

## Demo 影片
- https://youtu.be/D1KBVtSMbmU?si=6zovF_Wd1PgVRW2A
