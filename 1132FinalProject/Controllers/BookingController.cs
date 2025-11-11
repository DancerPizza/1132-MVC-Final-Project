using _1132FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace _1132FinalProject.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult BookingSpace()
        {
            // 回傳空的 ViewModel
            return View(new BookingViewModel());
        }

        // POST: /Booking/BookingSpace  （如果你想改为 POST 处理表单）
        [HttpPost]
        [ValidateAntiForgeryToken]

        //vm:參數名稱
        public IActionResult BookingSpace(BookingViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            return View(vm);
        }
    }
}
