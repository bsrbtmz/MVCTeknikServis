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
    [Authorize]
    public class MusterilerController : Controller
    {
        TekServisEntities ts = new TekServisEntities();
        // GET: Musteriler
        public ActionResult Index()
        {
            List<Musteri> musteri = DataService.Service.MusteriService.SelectAll();
            return View(musteri);
        }
        public ActionResult MusteriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MusteriEkle(MusteriDTO m)
        {
            if (ModelState.IsValid)
            {
                Musteri musteri = new Musteri()
                {
                    Adi=m.Adi,
                    Soyadi=m.Soyadi,
                    Email=m.Email,
                    Telefon=m.Telefon
                };
                DataService.Service.MusteriService.Insert(musteri);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public void Sil(int id)
        {
            Musteri musteri = ts.Musteris.FirstOrDefault(x => x.Id == id);
            ts.Musteris.Remove(musteri);
            ts.SaveChanges();
        }
    }
} 