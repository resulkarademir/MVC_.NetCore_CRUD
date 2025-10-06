using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Uygulama1.Models;

namespace Uygulama1.Controllers
{
    public class PersonelController : Controller
    {
        Context c= new Context();
        public IActionResult Index()
        {
            var degerler=c.Personeller.Include(x=>x.Birim).ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult PersonelEkle()
        {
            List<SelectListItem> list = (from x in c.Birimler.ToList()
                                         select new SelectListItem
                                         {
                                             Text=x.BirimAd,
                                             Value=x.BirimId.ToString()
                                         }).ToList();
            ViewBag.dgr = list;
            return View();
        }


        [HttpPost]
        public IActionResult PersonelEkle(Personeller p) {

            c.Personeller.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
