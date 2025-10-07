using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Uygulama1.Models;

namespace Uygulama1.Controllers
{
    public class BirimController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Birimler.ToList();
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
            var birim = c.Birimler.Find(id);
            c.Birimler.Remove(birim);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult BirimGetir(int id)
        {
            var birim = c.Birimler.Find(id);
            return View("BirimGetir", birim);
        }
        public IActionResult BirimGuncelle(Birimler birim)
        {

            var dep = c.Birimler.Find(birim.BirimId);
            dep.BirimAd = birim.BirimAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult BirimDetay(int id)
        {
            var degerler = c.Personeller.Where(x=> x.BirimId == id).ToList();
            var brmad= c.Birimler.Where(x=>x.BirimId==id).Select(y=>y.BirimAd).FirstOrDefault();
            ViewBag.brm = brmad;
            return View(degerler);

        }
    }
}
