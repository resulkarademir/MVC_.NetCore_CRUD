using Microsoft.AspNetCore.Mvc;

namespace Uygulama1.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
