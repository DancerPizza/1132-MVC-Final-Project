using _1132FinalProject.Data;
using _1132FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//註冊razor pages
builder.Services.AddRazorPages();

//取得組態資料庫連線, 名稱要跟appsetting.json一樣
string connectionString = builder.Configuration.GetConnectionString("CmsContext");
//註冊EF Core的CmsContext
builder.Services.AddDbContext<CmsContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

// Add session 要在rounting後
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

// 有Controller也要Map, 綁定builder.Services.AddControllersWithViews();
app.MapControllers();
app.MapRazorPages();
app.Run();