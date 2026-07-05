using Microsoft.AspNetCore.Mvc;
using _1132FinalProject.Data;
using _1132FinalProject.Models;
using X.PagedList;
using X.PagedList.Extensions;

namespace _1132FinalProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly CmsContext _context;
        private readonly IConfiguration _configuration;

        public AdminController(CmsContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        private bool IsAdminLoggedIn() =>
            HttpContext.Session.GetString("IsAdmin") == "true";

        // GET: /Admin/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // 登入專區
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Login(string username, string password)
        {
            var adminUser = _configuration["Admin:Username"];
            var adminPass = _configuration["Admin:Password"];

            if (username == adminUser && password == adminPass)
            {
                HttpContext.Session.SetString("IsAdmin", "true");
                return RedirectToAction("List");
            }
            ModelState.AddModelError("", "帳號或密碼錯誤");
            return View();
        }

        // 登出
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction(nameof(Login));
        }

        // 分頁顯示資料
        public IActionResult List(int page = 1, int pageSize = 2)
        {
            if (!IsAdminLoggedIn())
                return RedirectToAction("Login");

            var query = _context.Table_s1121768_NewMembers.OrderBy(m => m.StuId);
            var paged = query.ToPagedList(page, pageSize);
            return View("NewMembersList", paged);
        }

        // 詳細資料/{stuId}
        public IActionResult Details(string id)
        {
            if (!IsAdminLoggedIn())
                return RedirectToAction("Login");
            var m = _context.Table_s1121768_NewMembers.Find(id);
            if (m == null) return NotFound();
            return View(m);
        }

        // 新增資料/{stuId}
        [HttpGet]
        public IActionResult Create()
        {
            if (!IsAdminLoggedIn())
                return RedirectToAction("Login");
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NewMembersModel m)
        {
            if (!IsAdminLoggedIn())
                return RedirectToAction("Login");
            if (!ModelState.IsValid) return View(m);

            m.RegisteredAt = DateTime.Now;
            _context.Table_s1121768_NewMembers.Add(m);
            await _context.SaveChangesAsync();
            return RedirectToAction("List");
        }

        // GET: 編輯資料/{stuId}
        [HttpGet]
        public IActionResult Edit(string id)
        {
            if (!IsAdminLoggedIn())
                return RedirectToAction("Login");
            var m = _context.Table_s1121768_NewMembers.Find(id);

            if (m == null) return NotFound();
            return View(m);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, NewMembersModel m)
        {
            if (!IsAdminLoggedIn())
                return RedirectToAction("Login");

            if (!ModelState.IsValid)
            {
                return View(m);
            }

            var existing = _context.Table_s1121768_NewMembers.Find(id);
            if (existing == null) return NotFound();

            existing.Name = m.Name;
            existing.NickName = m.NickName;
            existing.Department = m.Department;
            existing.Section = m.Section;
            existing.IG_Account = m.IG_Account;

            await _context.SaveChangesAsync();

            TempData["UpdateSuccess"] = "更新成功！";
            return RedirectToAction("List");
        }

        // 刪除資料/{stuId}
        [HttpGet]
        public IActionResult Delete(string id)
        {
            if (!IsAdminLoggedIn())
                return RedirectToAction("Login");
            var m = _context.Table_s1121768_NewMembers.Find(id);
            if (m == null) return NotFound();
            return View(m);
        }

        [HttpPost, ActionName("Delete"), ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (!IsAdminLoggedIn())
                return RedirectToAction("Login");

            var m = _context.Table_s1121768_NewMembers.Find(id);
            if (m == null) return NotFound();

            _context.Table_s1121768_NewMembers.Remove(m);
            await _context.SaveChangesAsync();

            TempData["UpdateSuccess"] = "刪除資料成功！";
            return RedirectToAction("List");
        }
    }
}
