using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknikServis.DAL;
using TeknikServis.UI.Models;
using TeknikServis.UI.Services;

namespace TeknikServis.UI.Controllers
{
    public class YeniServisKaydiController : Controller
    {
        TekServisEntities ts = new TekServisEntities();
        // GET: YeniServisKaydi
        public ActionResult Index()
        {
            List<Islem> detay = DataService.Service.DetayService.SelectAll();
            return View(detay);
        }
        public ActionResult Ekle()
        {
            ViewBag.Ariza = DataService.Service.ArizaService.SelectAll();
            ViewBag.ServisYeri = DataService.Service.ServisYeriService.SelectAll();
            ViewBag.ServisDurum = DataService.Service.ServisDurumService.SelectAll();
            ViewBag.UrunTeslim = DataService.Service.UrunTeslimService.SelectAll();
            ViewBag.Urun = DataService.Service.UrunService.SelectAll();
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(DetayDTO d)
        {
            if (ModelState.IsValid)
            {
                Islem detay = new Islem()
                {
                    UrunId = d.UrunId,
                    ArizaId = d.ArizaId,
                    ServisDurumId = d.ServisDurumId,
                    ServisYeriId = d.ServisyeriId
                };
                DataService.Service.DetayService.Insert(detay);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public void Sil(int id)
        {
            Islem detay = ts.Islems.FirstOrDefault(x => x.Id == id);
            ts.Islems.Remove(detay);
            ts.SaveChanges();
        }

    }
}