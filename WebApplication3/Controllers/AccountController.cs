using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class AccountController : Controller
    {
        PatientDbContext db = new PatientDbContext();
        public IActionResult Login()
        {
            return View();
        }

        public ActionResult Validate(Admins admin)
        {
            var _admin = db.Admin.Where(s => s.emailAdmin == admin.emailAdmin);
            if (_admin.Any())
            {
                if (_admin.Where(s => s.passwordAdmin == admin.passwordAdmin).Any())
                {

                    return Json(new { status = true, message = "Login Successfull!" });
                }
                else
                {
                    return Json(new { status = false, message = "Invalid Password!" });
                }
            }
            else
            {
                return Json(new { status = false, message = "Invalid Email!" });
            }
        }

    }
}