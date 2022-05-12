using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _2021_MazlovaYelena.Models;
using _2021_MazlovaYelena.Data;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace _2021_MazlovaYelena.Controllers
{
    public class LoginController : Controller
    {
        private DataContextClass _context;
        public LoginController(DataContextClass context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task <IActionResult> Autorisation(LoginViewModel model)
        {
            if(!ModelState.IsValid)
            {
               return View();
            }

           var user = _context.Users.FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);
           if (user == null)
           {
                return View();
           }

            await Authenticate(model.Email);
            return RedirectToAction("Temp_heath", "Home");
           
        }
        public IActionResult Autorisation ()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Registration(LoginRegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (_context.Users.Any(x => x.Email == model.Email))
            {
                return View();
            }

            var user = new User
            {
                Name = model.Name,
                Age = model.Age,
                Email = model.Email,
                Password = model.Password,

            };

            _context.Users.Add(user);
            _context.SaveChanges();

            await Authenticate(model.Email);
            return RedirectToAction("Temp_heath", "Home");
        }

        public IActionResult Registration()
        {
            return View();
        }

        public async Task <IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Autorisation");
        }

        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}
