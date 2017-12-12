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
    public class UrunTeslimController : Controller
    {
        TekServisEntities ts = new TekServisEntities();
        // GET: UrunTeslim
        public ActionResult Index()
        {
            List<UrunTeslim> urun = DataService.Service.UrunTeslimService.SelectAll();
            return View(urun);
        }
        public ActionResult UrunTeslimKayitEkle()
        {
            ViewBag.Urun = DataService.Service.UrunService.SelectAll();
            ViewBag.Musteri = DataService.Service.MusteriService.SelectAll();
            ViewBag.Personel = DataService.Service.PersonelService.SelectAll();

            return View();
        }
        [HttpPost]
        public ActionResult UrunTeslimKayitEkle(UrunTeslimDTO u)
        {
            if (ModelState.IsValid)
            {
                UrunTeslim urun = new UrunTeslim()
                {
                    TeslimEdenPersonelId=u.TeslimEdenPersonelId,
                    ServisBedeli=u.ServisBedeli,
                    TeslimBedeli=u.TeslimBedeli,
                    UrunId=u.UrunId,
                    MusteriId=u.MusteriId,
                    TeslimTarihi=u.TeslimTarihi
                };
                DataService.Service.UrunTeslimService.Insert(urun);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public void Sil(int id)
        {
            UrunTeslim ut = ts.UrunTeslims.FirstOrDefault(x => x.Id == id);
            ts.UrunTeslims.Remove(ut);
            ts.SaveChanges();
        }
    }
}