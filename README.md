# 1132FinalProject

# 社團網站（ASP.NET MVC + SQL Server, 已改為LocalDB）
學校社團資訊網站：幹部名單、報名表單、基本 CRUD 與登入驗證。

## 功能
- 幹部名單（CRUD）
- 新生註冊（表單驗證 + 管理端審核）
- 登入/權限（範例）

## 技術棧
- ASP.NET MVC
- Entity Framework
- SQL Server LocalDB（Demo 用）
- Bootstrap（UI）

## 
1. clone 本專案  
2. 建立本機資料庫（見 `docs/db-seed.sql` 或 `DbInitializer`）  
3. 設定連線字串（appsettings.Development.json）  
4. 執行：F5 / `dotnet run`

## Demo 資料
- 預設帳號：已顯示於輸入框
- 種子資料：幹部 6 人、新生 3 筆
