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
    public class UrunlerController : Controller
    {
        TekServisEntities ts = new TekServisEntities();
        // GET: Urunler
        public ActionResult Index()
        {
            List<Urun> urun = DataService.Service.UrunService.SelectAll();
            return View(urun);
        }
        public ActionResult UrunEkle()
        {
            ViewBag.Kategori = DataService.Service.KategoriService.SelectAll();
            ViewBag.Marka = DataService.Service.MarkaService.SelectAll();
            ViewBag.Model = DataService.Service.ModelService.SelectAll();
            
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(UrunDTO u)
        {
            if (ModelState.IsValid)
            {
                Urun urun = new Urun()
                {
                    IslemNo=u.IslemNo,
                    MarkaId=u.MarkaId,
                    ModelId=u.ModelId,
                    KategoriId=u.KategoriId,
                    GirisTarihi=u.GirisTarihi,
                    Garantilimi=u.Garantilimi
                };
                DataService.Service.UrunService.Insert(urun);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public void Sil(int id)
        {
            Urun urun = ts.Uruns.FirstOrDefault(x => x.Id == id);
            ts.Uruns.Remove(urun);
            ts.SaveChanges();
        }
        
    }
}