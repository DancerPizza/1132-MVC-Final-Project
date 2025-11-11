using Microsoft.AspNetCore.Mvc;
using System;
using _1132FinalProject.Data;
using _1132FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace _1132FinalProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly CmsContext _context;
        public ContactController(CmsContext context)
        {
            _context = context;
        }

        // GET: /Contact
        public async Task<IActionResult> ContactCommittee()
        {
            var list = await _context.Table_s1121768_CommitteeMembers.ToListAsync();
            return View(list);
        }
    }
}