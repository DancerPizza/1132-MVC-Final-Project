using _1132FinalProject.Models;
using _1132FinalProject.Data;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _1132FinalProject.Controllers
{
    public class NewMembersController : Controller
    {
        private readonly CmsContext _context;
        public NewMembersController(CmsContext context)
        {
            _context = context;
        }

        //GET空新生資料表單
        public IActionResult NewRegister()
        {
            return View(new NewMembersModel());
        }
        //POST 處理新生資料
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewRegister(NewMembersModel model)
        {
            if (!ModelState.IsValid)
            {
                // 驗證失敗，回到頁面並顯示錯誤
                return View(model);
            }
            // 註冊時間
            model.RegisteredAt = DateTime.Now;

            // 將資料新增到資料庫
            _context.Table_s1121768_NewMembers.Add(model);
            await _context.SaveChangesAsync();

            TempData["Success"] = "註冊成功！";
            return View(model);
        }
    }
}
