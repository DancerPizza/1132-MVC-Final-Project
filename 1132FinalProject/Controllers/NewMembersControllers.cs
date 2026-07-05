using _1132FinalProject.Models;
using _1132FinalProject.Data;
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

        // GET 空新生資料表單
        public IActionResult NewRegister()
        {
            return View(new NewMembersModel
            {
                StuId = string.Empty,
                Name = string.Empty,
                NickName = string.Empty,
                Department = string.Empty,
                Section = string.Empty,
                IG_Account = string.Empty
            });
        }

        // POST 處理新生資料
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewRegister(NewMembersModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.RegisteredAt = DateTime.Now;
            _context.Table_s1121768_NewMembers.Add(model);
            await _context.SaveChangesAsync();

            TempData["Success"] = "註冊成功！";
            return RedirectToAction(nameof(NewRegister));
        }
    }
}
