using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(LogInViewModel model)
        {
            if (model.UserName=="mohammadfr78" && model.PassWord=="123")
            {
                return RedirectToAction("index", "home");
            }
            return RedirectToAction("Login");
        }
    }
}