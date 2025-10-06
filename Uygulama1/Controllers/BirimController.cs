using Microsoft.AspNetCore.Mvc;
using Uygulama1.Models;

namespace Uygulama1.Controllers
{
    public class BirimController : Controller
    {
        Context c=new Context();
        public IActionResult Index()
        {
            var degerler=c.Birimler.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult BirimEkle()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult BirimEkle(Birimler b)
        {
            c.Birimler.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult BirimSil(int id)
        {
            var birim =c.Birimler.Find(id);
            c.Birimler.Remove(birim);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
