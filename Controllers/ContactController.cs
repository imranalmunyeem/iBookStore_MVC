using iBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using iBookStore.Data;

namespace iBookStore.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                // Save the data to the database
                _context.contactModels.Add(model);
                await _context.SaveChangesAsync();
                TempData["success"] = "Your message has been sent successfully!";
                //ViewBag.Message = "Your message has been sent successfully!";
            }
            return View(model);
        }
    }
}