using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Uygulama1.Models;

namespace Uygulama1.Controllers
{
    public class LoginController : Controller
    {

        Context context = new Context();

        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();

        }

        public async Task<IActionResult> GirisYap(Admin p)
        {
            var bilgiler = context.Adminler.FirstOrDefault(x => x.UserName == p.UserName && x.UserPassword == p.UserPassword);
            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {

                    new Claim(ClaimTypes.Name, p.UserName)

                 };
                var useridentity = new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Personel");
            }
            return View();
        }


    }
}
